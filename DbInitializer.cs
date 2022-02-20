using LoanNet.Models;

namespace LoanNet
{
    public static class DbInitializer
    {
        public static void Initialize(MyDbContext context)
        {
            context.Database.EnsureCreated();
            
        }
    }
}
