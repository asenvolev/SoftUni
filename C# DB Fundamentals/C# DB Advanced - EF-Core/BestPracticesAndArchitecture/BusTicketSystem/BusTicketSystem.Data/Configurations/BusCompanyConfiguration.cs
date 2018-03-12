namespace BusTicketSystem.Data.Configurations
{
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BusCompanyConfiguration : IEntityTypeConfiguration<BusCompany>
    {
        public void Configure(EntityTypeBuilder<BusCompany> builder)
        {
            builder.HasKey(b => b.BusCompanyId);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(b => b.Nationality)
                .HasMaxLength(30);
        }
    }
}
