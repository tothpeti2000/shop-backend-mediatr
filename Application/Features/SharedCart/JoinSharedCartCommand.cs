using Application.Hubs;
using Application.Mapping;
using Application.Mapping.Profiles;
using Application.Services;
using DAL.Repositories;
using Domain.Interfaces;
using Domain.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.SharedCart
{
    public class JoinSharedCartValidator : AbstractValidator<JoinSharedCartCommand>
    {
        public JoinSharedCartValidator()
        {
            RuleFor(command => command.Passcode).NotEmpty().NotNull();
        }
    }

    public class JoinSharedCartCommand : IRequest<JoinSharedCartResponse>
    {
        public string Passcode { get; set; }
    }

    public class JoinSharedCartResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class JoinSharedCartCommandHandler : IRequestHandler<JoinSharedCartCommand, JoinSharedCartResponse>
    {
        private readonly ISharedCartRepository repository;
        private readonly IUserService userService;
        private readonly ISharedCartHub sharedCartHub;
        private readonly IUnitOfWork uow;
        private readonly Mapper<SharedCartProfile> mapper = new();

        public JoinSharedCartCommandHandler(
            ISharedCartRepository repository, 
            IUserService userService, 
            ISharedCartHub sharedCartHub, 
            IUnitOfWork uow)
        {
            this.repository = repository;
            this.userService = userService;
            this.sharedCartHub = sharedCartHub;
            this.uow = uow;
        }

        public async Task<JoinSharedCartResponse> Handle(JoinSharedCartCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var user = await userService.GetByIdAsync(userId);

            var cart = await repository.GetByPasscodeAsync(command.Passcode, cancellationToken);

            if (cart.Users.Contains(user))
            {
                throw new InvalidOperationException("You can't join this shared cart because you're already a member of it");
            }

            cart.Users.Add(user);
            await uow.SaveChangesAsync();

            var actionDetails = new ActionDetails
            {
                CartId = cart.Id,
                Message = $"{user.Name} has joined the {cart.Name} shared cart"
            };

            await sharedCartHub.UserJoinedCart(actionDetails);

            return mapper.Map<Domain.Models.SharedCart, JoinSharedCartResponse>(cart);
        }
    }

}
