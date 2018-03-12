namespace BusTicketSystem.Data.Configurations
{
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(b => b.TownId);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(b => b.Country)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
