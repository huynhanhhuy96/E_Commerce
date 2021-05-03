namespace EC.Repo.Context
{
    using Microsoft.EntityFrameworkCore;
    using EC.Repo.EntityConfigurations;
    public partial class ECContext: DbContext
    {
        public ECContext(DbContextOptions options) : base(options: options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder: modelBuilder);

            modelBuilder.ApplyConfiguration(configuration: new ProductEntityTypeConfiguration());
        }
    }
}