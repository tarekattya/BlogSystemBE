using BlogSystemAPI;

namespace BlogSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDependencies(builder.Configuration);
            var app = builder.Build();

            app.Run();
        }
    }
}
