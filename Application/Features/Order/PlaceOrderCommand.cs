using Application.Mapping;
using Application.Mapping.Profiles;
using Application.Services;
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
                    details.RuleFor(data => data.FirstName).NotNull().NotEmpty();
                    details.RuleFor(data => data.LastName).NotNull().NotEmpty();
                    details.RuleFor(data => data.Phone).NotNull().NotEmpty();
                });

            RuleFor(command => command.DeliveryData).NotNull()
                .ChildRules(details =>
                {
                    details.RuleFor(data => data.ZipCode).NotNull().NotEmpty();
                    details.RuleFor(data => data.City).NotNull().NotEmpty();
                    details.RuleFor(data => data.Address).NotNull().NotEmpty();
                });

            RuleFor(command => command.PaymentMethod).NotNull().IsInEnum();
        }
    }

    public class PlaceOrderCommand : IRequest
    {
        public CustomerDetails CustomerData { get; set; }
        public DeliveryDetails DeliveryData { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public class CustomerDetails
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
        }

        public class DeliveryDetails
        {
            public string ZipCode { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
        }
    }

    public class PlaceOrderCommandHandler : IRequestHandler<PlaceOrderCommand, Unit>
    {
        private readonly IOrderRepository orderRepository;
        private readonly ICartRepository cartRepository;
        private readonly IProductRepository productRepository;
        private readonly IUnitOfWork uow;
        private readonly IUserService userService;
        private readonly IPaymentService paymentService;
        private readonly IEmailService emailService;
        private readonly Mapper<OrderProfile> mapper = new();

        public PlaceOrderCommandHandler(
            IOrderRepository orderRepository, 
            ICartRepository cartRepository, 
            IProductRepository productRepository,
            IUnitOfWork uow,
            IUserService userService,
            IPaymentService paymentService,
            IEmailService emailService)
        {
            this.orderRepository = orderRepository;
            this.cartRepository = cartRepository;
            this.productRepository = productRepository;
            this.uow = uow;
            this.userService = userService;
            this.paymentService = paymentService;
            this.emailService = emailService;
        }

        public async Task<Unit> Handle(PlaceOrderCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var email = await userService.GetUserEmailAsync(userId);
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

            await uow.SaveChangesAsync();

            await emailService.SendOrderConfirmationEmail(order, email);

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
