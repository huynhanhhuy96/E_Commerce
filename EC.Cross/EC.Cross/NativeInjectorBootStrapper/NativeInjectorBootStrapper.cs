namespace EC.Cross.NativeInjectorBootStrapper
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using OS.Repo.Context;
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddDbContext<ECContext>((DbContextOptionsBuilder options)=> options.UseSqlServer(
                connectionString: "Server=.\\SQLEXPRESS;Database=EC;Trusted_Connection=True"
            ));
        }
    }
}