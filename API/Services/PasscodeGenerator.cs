using Application.Services;
using Domain.Repositories;

namespace API.Services
{
    public class PasscodeGenerator : IPasscodeGenerator
    {
        private readonly string digits = "0123456789";
        private readonly Random random = new();

        public string GeneratePasscode(int length)
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
