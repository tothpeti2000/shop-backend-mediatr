using Application.Services;
using Domain.Repositories;

namespace API.Services
{
    public class PasscodeGenerator : IPasscodeGenerator
    {
        private readonly ISharedCartRepository sharedCartRepository;
        private readonly string digits = "0123456789";
        private readonly Random random = new();

        public PasscodeGenerator(ISharedCartRepository sharedCartRepository)
        {
            this.sharedCartRepository = sharedCartRepository;
        }

        public async Task<string> GeneratePasscode(int length, CancellationToken cancellationToken)
        {
            var cartPasscodes = await sharedCartRepository.GetAllPasscodesAsync(cancellationToken);
            var passcode = CreateCode(length);

            while (cartPasscodes.Contains(passcode))
            {
                passcode = CreateCode(length);
            }

            return passcode;
        }

        private string CreateCode(int length)
        {
            var code = "";

            for (int i = 0; i < length; i++)
            {
                var digit = digits[random.Next(0, digits.Length)];
                code += digit;
            }

            return code;
        }
    }
}
