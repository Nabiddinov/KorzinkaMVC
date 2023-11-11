using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Supermarket.Domain.Entities;

namespace Supermarket.Infrastructure.Persistence.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(500)
                .IsRequired();
            builder.Property(p => p.Description)
                .HasMaxLength(500)
                .IsRequired(false);
            builder.Property(p => p.IncomePrice)
                .HasColumnType("money");
            builder.Property(p => p.SalePrice)
                .HasColumnType("money");

            builder.HasMany(p => p.Categories)
                .WithOne(pc => pc.Product)
                .HasForeignKey(pc => pc.ProductId);
            builder.HasMany(p => p.SaleItems)
                .WithOne(si => si.Product)
                .HasForeignKey(si => si.ProductId);
        }
    }
}
