using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sales");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");


        builder.Property(u => u.SaleNumber);
        builder.Property(u => u.SaleDate).HasColumnType("timestamp").HasDefaultValueSql("now()");
        builder.Property(u => u.TotalAmount).HasColumnType("decimal(18,2)");
        builder.Property(u => u.IsCancelled).HasDefaultValue(false);
        builder.Property(u => u.Customer).HasMaxLength(100);
        builder.Property(u => u.Branch).HasMaxLength(100);
        builder.HasMany(s => s.Items)
            .WithOne()
            .HasForeignKey(si => si.SaleId)
            .OnDelete(DeleteBehavior.Cascade);
       
    }

}
