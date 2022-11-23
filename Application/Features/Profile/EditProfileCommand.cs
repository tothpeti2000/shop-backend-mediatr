using Domain.Services;
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
            RuleFor(u => u.Name).NotEmpty().When(u => u.Name != null);
            RuleFor(u => u.CurrentPassword).NotEmpty().NotNull();
            RuleFor(u => u.NewPassword).NotEmpty().When(u => u.NewPassword != null);
            RuleFor(u => u.NewPasswordConfirm)
                .NotEmpty().When(u => u.NewPassword != null)
                .Equal(u => u.NewPassword).When(u => u.NewPassword != null);
        }
    }

    public class EditProfileCommand : IRequest
    {
        public string? Name { get; set; }
        public string CurrentPassword { get; set; }
        public string? NewPassword { get; set; }
        public string? NewPasswordConfirm { get; set; }
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

            var passwordValid = await userService.CheckPasswordAsync(user, command.CurrentPassword);

            if (!passwordValid)
            {
                throw new InvalidOperationException("The given current password is incorrect");
            }

            if (!string.IsNullOrEmpty(command.Name) && user.Name != command.Name)
            {
                await userService.UpdateNameAsync(userId, command.Name);
            }

            if (!string.IsNullOrEmpty(command.NewPassword))
            {
                await userService.UpdatePasswordAsync(userId, command.CurrentPassword, command.NewPassword);
            }

            return Unit.Value;
        }
    }

}
