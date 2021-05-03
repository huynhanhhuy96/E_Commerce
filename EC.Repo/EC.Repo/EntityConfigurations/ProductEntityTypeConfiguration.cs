namespace EC.Repo.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using EC.Core.Models;

    public class ProductEntityTypeConfiguration: IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable(name: "TBL_PRODUCT_MASTER");
            builder.HasKey(c => c.Id).HasName(name: "ID");
            builder.Property(c => c.Id).HasColumnName(name: "ID").ValueGeneratedOnAdd();
        }
    }
}