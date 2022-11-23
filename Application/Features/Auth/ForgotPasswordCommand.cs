using Domain.Services;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth
{
    public class ForgotPasswordValidator : AbstractValidator<ForgotPasswordCommand>
    {
        public ForgotPasswordValidator()
        {
            RuleFor(command => command.Email).NotEmpty().NotNull().EmailAddress();
        }
    }

    public class ForgotPasswordCommand : IRequest
    {
        public string Email { get; set; }
    }

    public class ForgotPasswordCommandHandler : IRequestHandler<ForgotPasswordCommand, Unit>
    {
        private readonly IUserService userService;
        private readonly IEmailService emailService;

        public ForgotPasswordCommandHandler(IUserService userService, IEmailService emailService)
        {
            this.userService = userService;
            this.emailService = emailService;
        }

        public async Task<Unit> Handle(ForgotPasswordCommand command, CancellationToken cancellationToken)
        {
            var user = await userService.GetByEmailAsync(command.Email);
            var resetToken = await userService.GeneratePasswordResetTokenAsync(user);

            await emailService.SendPasswordResetEmailAsync(resetToken, user.Id, user.Name, user.Email);

            return Unit.Value;
        }
    }

}
