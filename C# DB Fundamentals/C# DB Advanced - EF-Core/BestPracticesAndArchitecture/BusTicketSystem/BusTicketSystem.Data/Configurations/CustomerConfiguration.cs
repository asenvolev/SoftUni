namespace BusTicketSystem.Data.Configurations
{
    using System;
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(b => b.CustomerId);

            builder.Property(b => b.FirstName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(30);

            builder.Property(b => b.LastName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(30);

            builder.Property(b => b.DateOfBirth)
                .HasColumnType("DATETIME2");

            builder.Property(b => b.Gender)
                .IsRequired();

            builder.HasOne(b => b.HomeTown)
                .WithMany(h => h.Customers)
                .HasForeignKey(b => b.HomeTownId);
        }
    }
}
