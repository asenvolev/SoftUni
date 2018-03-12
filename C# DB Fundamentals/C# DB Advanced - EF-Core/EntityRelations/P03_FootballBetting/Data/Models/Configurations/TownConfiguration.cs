using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P03_FootballBetting.Data.Models.Configurations
{
    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(b => b.TownId);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(40);

            builder.HasOne(b => b.Country)
                .WithMany(c => c.Towns)
                .HasForeignKey(b => b.CountryId);
        }
    }
}
