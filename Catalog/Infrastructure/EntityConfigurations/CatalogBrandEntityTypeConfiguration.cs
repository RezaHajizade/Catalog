using Catalog.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.EntityConfigurations
{
    public class CatalogBrandEntityTypeConfiguration : IEntityTypeConfiguration<CatalogBrand>
    {
        public void Configure(EntityTypeBuilder<CatalogBrand> builder)
        {
            builder.ToTable(CatalogBrand.TableName);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Brand)
                .HasMaxLength(100)
                .IsRequired(true);
        }
    }
}
