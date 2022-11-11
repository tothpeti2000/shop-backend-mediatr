using Application.Services;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Profile
{

    public class EditProfileValidator : AbstractValidator<EditProfileCommand>
    {
        public EditProfileValidator()
        {
            RuleFor(u => u.Name).NotEmpty().NotNull();
            RuleFor(u => u.CurrentPassword).NotEmpty().NotNull();
            RuleFor(u => u.NewPassword).NotEmpty().When(u => u.NewPassword != null);
        }
    }

    public class EditProfileCommand : IRequest
    {
        public string Name { get; set; }
        public string CurrentPassword { get; set; }
        public string? NewPassword { get; set; }
    }

    public class EditProfileCommandHandler : IRequestHandler<EditProfileCommand, Unit>
    {
        private readonly IUserService userService;

        public EditProfileCommandHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<Unit> Handle(EditProfileCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var user = await userService.GetByIdAsync(userId);

            if (user.Name != command.Name)
            {
                await userService.UpdateNameAsync(userId, command.Name);
            }

            if (command.NewPassword != null)
            {
                await userService.UpdatePasswordAsync(userId, command.CurrentPassword, command.NewPassword);
            }

            return Unit.Value;
        }
    }

}
