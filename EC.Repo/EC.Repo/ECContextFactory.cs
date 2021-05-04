namespace EC.Repo
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using EC.Repo.Context;

    public class ECContextFactory : IDesignTimeDbContextFactory<ECContext>
    {
        public ECContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ECContext>();
            optionsBuilder.UseSqlServer(connectionString: "Server=.\\SQLEXPRESS;Database=E-Commerce;Trusted_Connection=True");

            return new ECContext(options: optionsBuilder.Options);
        }
    }
}