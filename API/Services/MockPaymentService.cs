using Application.Services;

namespace API.Services
{
    public class MockPaymentService : IPaymentService
    {
        public async Task StartPaymentTransaction()
        {
            Console.WriteLine("Starting payment process");
            await Task.Delay(5000);
            Console.WriteLine("Payment completed");
        }
    }
}
