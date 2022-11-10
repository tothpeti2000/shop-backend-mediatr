using Application.Services;
using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;
using System.Text;
using Domain.Models;

namespace API.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration configuration;

        public EmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task SendOrderConfirmationEmail(Order order, string email)
        {
            var subject = $"Order {order.Id}";

            var productList = "";

            foreach(var cartItem in order.Cart.CartItems)
            {
                productList += $"<li>{cartItem.Product.Name}\t${cartItem.Product.Price}</li><br/>";
            }

            var body = @$"Dear <b>{order.FirstName} {order.LastName}</b>,
                          <br/>
                          <br/>
                          Thank you for choosing our webshop! 
                          <br/>
                          Your order was completed successfully. We'll try to deliver the products to you as soon as possible.
                          <br/>
                          <br/>
                          You ordered the following products:
                          <ul>
                            {productList}
                          </ul>
                          <br/>
                          Consider choosing us next time as well!
                          <br/>
                          Shop";

            await SendEmail(email, subject, body);
        }

        private async Task SendEmail(string email, string subject, string body)
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
