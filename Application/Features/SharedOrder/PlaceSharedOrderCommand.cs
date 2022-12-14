using Application.Mapping.Profiles;
using Application.Mapping;
using Domain.Services;
using Domain.Interfaces;
using Domain.Models;
using Domain.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Hubs;

namespace Application.Features.SharedOrder
{
    public class PlaceSharedOrderValidator : AbstractValidator<PlaceSharedOrderCommand>
    {
        public PlaceSharedOrderValidator()
        {
            RuleFor(command => command.SharedCartId).NotEmpty().NotNull();

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

    public class PlaceSharedOrderCommand : IRequest
    {
        public Guid SharedCartId { get; set; }
        public CustomerDetails CustomerData { get; set; }
        public DeliveryDetails DeliveryData { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }

    public class PlaceSharedOrderCommandHandler : IRequestHandler<PlaceSharedOrderCommand, Unit>
    {
        private readonly ISharedOrderRepository sharedOrderRepository;
        private readonly ISharedCartRepository sharedCartRepository;
        private readonly IProductRepository productRepository;
        private readonly IUnitOfWork uow;
        private readonly IUserService userService;
        private readonly IPaymentService paymentService;
        private readonly IEmailService emailService;
        private readonly ISharedCartHub sharedCartHub;
        private readonly Mapper<SharedOrderProfile> mapper = new();

        public PlaceSharedOrderCommandHandler(
            ISharedOrderRepository sharedOrderRepository,
            ISharedCartRepository sharedCartRepository,
            IProductRepository productRepository,
            IUnitOfWork uow,
            IUserService userService,
            IPaymentService paymentService,
            IEmailService emailService,
            ISharedCartHub sharedCartHub)
        {
            this.sharedOrderRepository = sharedOrderRepository;
            this.sharedCartRepository = sharedCartRepository;
            this.productRepository = productRepository;
            this.uow = uow;
            this.userService = userService;
            this.paymentService = paymentService;
            this.emailService = emailService;
            this.sharedCartHub = sharedCartHub;
        }

        public async Task<Unit> Handle(PlaceSharedOrderCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var cart = await sharedCartRepository.GetCartByIdAsync(command.SharedCartId, cancellationToken);

            if (cart.Status == SharedCartStatus.Completed)
            {
                throw new InvalidOperationException("You can't place the order since the cart has been marked as completed already.");
            }

            var outOfStockProductNames = await GetOutOfStockProductNames(cart.CartItems, cancellationToken);

            if (outOfStockProductNames != null)
            {
                throw new InvalidOperationException("Looks like we don't have enough products in stock to complete your order. " +
                    $"You requested too many items of the following product(s): {string.Join(", ", outOfStockProductNames)}");
            }

            foreach (var cartItem in cart.CartItems)
            {
                await productRepository.DecreaseStockAsync(cartItem.ProductId, cartItem.Amount, cancellationToken);
            }

            var order = mapper.Map<PlaceSharedOrderCommand, Domain.Models.SharedOrder>(command);

            if (command.PaymentMethod != PaymentMethod.OnDelivery)
            {
                await paymentService.StartPaymentTransaction();
                order.Paid = true;
            }

            cart.Status = SharedCartStatus.Completed;
            order.SharedCart = cart;
            await sharedOrderRepository.AddAsync(order, cancellationToken);

            foreach (var user in cart.Users)
            {
                var isOrderPlacingUser = user.Id == userId;
                await emailService.SendSharedOrderConfirmationEmailAsync(order, user.Name, user.Email, isOrderPlacingUser);
            }

            await uow.SaveChangesAsync();

            await sharedCartHub.OrderPlaced(cart.Id);

            return Unit.Value;
        }

        private async Task<List<string>?> GetOutOfStockProductNames(List<SharedCartItem> cartItems, CancellationToken cancellationToken)
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
