using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItem>
{
  
    public void Configure(EntityTypeBuilder<SaleItem> builder)
    {
        builder.ToTable("SaleItem");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");


        builder.Property(u => u.Product).IsRequired().HasMaxLength(100);
        builder.Property(u => u.UnitPrice).HasColumnType("decimal(18,2)");
        builder.Property(u => u.Discount).HasColumnType("decimal(18,2)");
        builder.Property(u => u.TotalAmount).HasColumnType("decimal(18,2)");
        builder.Property(u => u.SaleId).HasColumnType("uuid");
        builder.Property(u => u.Quantity).IsRequired();


    }
}
