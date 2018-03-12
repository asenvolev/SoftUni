using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P03_FootballBetting.Data.Models.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(b => b.CountryId);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}
