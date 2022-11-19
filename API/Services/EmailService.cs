using Application.Services;
using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;
using System.Text;
using Domain.Models;
using System.Web;

namespace API.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration configuration;

        public EmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task SendOrderConfirmationEmailAsync(Order order, string name, string email)
        {
            var subject = $"Order {order.Id}";

            var productList = "";

            foreach(var cartItem in order.Cart.CartItems)
            {
                productList += $"<li>{cartItem.Product.Name}\t${cartItem.Product.Price}</li><br/>";
            }

            var body = @$"Dear <b>{name}</b>,
                          <br/>
                          <br/>
                          Thank you for choosing our webshop! 
                          <br/>
                          Your order was completed successfully. We'll try to deliver the products to you as soon as possible.
                          <br/>
                          <br/>
                          You ordered the following product(s):
                          <ul>
                            {productList}
                          </ul>
                          <br/>
                          Consider choosing us next time as well!
                          <br/>
                          <br/>
                          Shop";

            await SendEmailAsync(email, subject, body);
        }

        public async Task SendSharedOrderConfirmationEmailAsync(SharedOrder order, string name, string email, bool isOrderPlacingUser)
        {
            var subject = $"Shared order {order.Id}";
            var deliveryMessage = isOrderPlacingUser ? "" : "<br/>" +
                "The products will be delivered to another member of the shared cart. When the package arrives, we'll let you know as well.";

            var productList = "";

            foreach (var cartItem in order.SharedCart.CartItems)
            {
                productList += $"<li>{cartItem.Product.Name}\t${cartItem.Product.Price}</li><br/>";
            }

            var body = @$"Dear <b>{name}</b>,
                          <br/>
                          <br/>
                          Thank you and the other members of your shared cart for choosing our webshop! 
                          <br/>
                          Your order was completed successfully. We'll try to deliver the products to you as soon as possible.
                          {deliveryMessage}
                          <br/>
                          <br/>
                          You ordered the following product(s) altogether:
                          <ul>
                            {productList}
                          </ul>
                          <br/>
                          Consider choosing us next time as well!
                          <br/>
                          <br/>
                          Shop";

            await SendEmailAsync(email, subject, body);
        }

        public async Task SendPasswordResetEmailAsync(string resetToken, Guid userId, string name, string email)
        {
            var subject = "Reset password";
            // Without HttpUtility.UrlEncode, we would get an Invalid token error caused by + characters in the token
            var resetLink = $"{configuration["Frontend:BaseUrl"]}/reset-password?token={HttpUtility.UrlEncode(resetToken)}&id={userId}";

            var body = @$"Dear <b>{name}</b>,
                          <br/>
                          <br/>
                          You requested us to reset your password. In case you didn't initiate the password reset process, ignore this message.
                          <br/>
                          Click <a href='{resetLink}'>here</a> to reset your password!
                          <br/>
                          <br/>
                          Shop";

            await SendEmailAsync(email, subject, body);
        }

        private async Task SendEmailAsync(string email, string subject, string body)
        {
            var fromEmail = configuration["Email:FromEmail"];
            var smtpHost = configuration["Email:SmtpHost"];
            var smtpPort = int.Parse(configuration["Email:SmtpPort"]);

            var message = new MailMessage(fromEmail, email, subject, body)
            {
                BodyEncoding = Encoding.UTF8,
                IsBodyHtml = true
            };

            var client = new SmtpClient(smtpHost, smtpPort)
            {
                Credentials = CredentialCache.DefaultNetworkCredentials,
                EnableSsl = false
            };

            await client.SendMailAsync(message);
        }
    }
}
