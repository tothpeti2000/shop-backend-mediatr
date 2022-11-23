using Application.Mapping;
using Application.Mapping.Profiles;
using Domain.Services;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Domain.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Order
{
    public class PlaceOrderValidator : AbstractValidator<PlaceOrderCommand>
    {
        public PlaceOrderValidator()
        {
            RuleFor(command => command.CustomerData).NotNull()
                .ChildRules(details =>
                {
                    details.RuleFor(data => data.FirstName).NotEmpty().NotNull();
                    details.RuleFor(data => data.LastName).NotEmpty().NotNull();
                    details.RuleFor(data => data.Phone).NotEmpty().NotNull();
                });

            RuleFor(command => command.DeliveryData).NotNull()
                .ChildRules(details =>
                {
                    details.RuleFor(data => data.ZipCode).NotEmpty().NotNull();
                    details.RuleFor(data => data.City).NotEmpty().NotNull();
                    details.RuleFor(data => data.Address).NotEmpty().NotNull();
                });

            RuleFor(command => command.PaymentMethod).NotNull().IsInEnum();
        }
    }

    public class PlaceOrderCommand : IRequest
    {
        public CustomerDetails CustomerData { get; set; }
        public DeliveryDetails DeliveryData { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }

    public class PlaceOrderCommandHandler : IRequestHandler<PlaceOrderCommand, Unit>
    {
        private readonly IOrderRepository orderRepository;
        private readonly ICartRepository cartRepository;
        private readonly IProductRepository productRepository;
        private readonly IUserService userService;
        private readonly IPaymentService paymentService;
        private readonly IEmailService emailService;
        private readonly Mapper<OrderProfile> mapper = new();

        public PlaceOrderCommandHandler(
            IOrderRepository orderRepository, 
            ICartRepository cartRepository, 
            IProductRepository productRepository,
            IUserService userService,
            IPaymentService paymentService,
            IEmailService emailService)
        {
            this.orderRepository = orderRepository;
            this.cartRepository = cartRepository;
            this.productRepository = productRepository;
            this.userService = userService;
            this.paymentService = paymentService;
            this.emailService = emailService;
        }

        public async Task<Unit> Handle(PlaceOrderCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var user = await userService.GetByIdAsync(userId);
            var cart = await cartRepository.GetCartOfUserAsync(userId, cancellationToken);

            var outOfStockProductNames = await GetOutOfStockProductNames(cart.CartItems, cancellationToken);

            if(outOfStockProductNames != null)
            {
                throw new InvalidOperationException("Looks like we don't have enough products in stock to complete your order. " +
                    $"You requested too many items of the following product(s): {string.Join(", ", outOfStockProductNames)}");
            }

            foreach(var cartItem in cart.CartItems)
            {
                await productRepository.DecreaseStockAsync(cartItem.ProductId, cartItem.Amount, cancellationToken);
            }

            var order = mapper.Map<PlaceOrderCommand, Domain.Models.Order>(command);

            if (command.PaymentMethod != PaymentMethod.OnDelivery)
            {
                await paymentService.StartPaymentTransaction();
                order.Paid = true;
            }

            cart.Completed = true;
            order.Cart = cart;
            await orderRepository.AddAsync(order, cancellationToken);

            await cartRepository.CreateCartForUserAsync(userId, cancellationToken);

            await emailService.SendOrderConfirmationEmailAsync(order, user.Name, user.Email);

            return Unit.Value;
        }

        private async Task<List<string>?> GetOutOfStockProductNames(List<CartItem> cartItems, CancellationToken cancellationToken)
        {
            var productNames = new List<string>();

            foreach (var cartItem in cartItems)
            {
                var enoughInStock = await productRepository.CheckStockAsync(cartItem.ProductId, cartItem.Amount, cancellationToken);

                if (!enoughInStock)
                {
                    productNames.Add(cartItem.Product.Name);
                }
            }

            return productNames.Count > 0 ? productNames : null;
        }
    }

}
