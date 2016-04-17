using WebApplication1.Contracts;

namespace WebApplication1.Services
{
    public class TestService : ITestService
    {
        public int GetTest()
        {
            return 111;
        }
    }
}
