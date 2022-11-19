using Application.Services;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth
{
    public class ResetPasswordValidator : AbstractValidator<ResetPasswordCommand>
    {
        public ResetPasswordValidator()
        {
            RuleFor(command => command.UserId).NotEmpty().NotNull();
            RuleFor(command => command.NewPassword).NotEmpty().NotNull();
            RuleFor(command => command.NewPasswordConfirm).NotEmpty().NotNull().Equal(command => command.NewPassword);
            RuleFor(command => command.ResetToken).NotEmpty().NotNull();
        }
    }

    public class ResetPasswordCommand : IRequest
    {
        public Guid UserId { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirm { get; set; }
        public string ResetToken { get; set; }
    }

    public class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand, Unit>
    {
        private readonly IUserService userService;

        public ResetPasswordCommandHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<Unit> Handle(ResetPasswordCommand command, CancellationToken cancellationToken)
        {
            var user = await userService.GetByIdAsync(command.UserId);

            await userService.ResetPasswordAsync(user, command.ResetToken, command.NewPassword);

            return Unit.Value;
        }
    }

}
