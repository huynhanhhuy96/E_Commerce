namespace EC.Cross.NativeInjectorBootStrapper
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using EC.Repo.Context;
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddDbContext<ECContext>((DbContextOptionsBuilder options)=> options.UseSqlServer(
                connectionString: "Server=.\\SQLEXPRESS;Database=E-Commerce;Trusted_Connection=True"
            ));
        }
    }
}