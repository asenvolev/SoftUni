namespace BusTicketSystem.Data.Configurations
{
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BusStationConfiguration : IEntityTypeConfiguration<BusStation>
    {
        public void Configure(EntityTypeBuilder<BusStation> builder)
        {
            builder.HasKey(b => b.BusStationId);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(b => b.Town)
                .WithMany(b => b.BusStations)
                .HasForeignKey(b => b.TownId);
        }
    }
}
