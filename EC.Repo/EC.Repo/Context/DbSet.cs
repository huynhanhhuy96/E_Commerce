namespace EC.Repo.Context
{
    using Microsoft.EntityFrameworkCore;
    using EC.Core.Models;

    public partial class ECContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
    }
}