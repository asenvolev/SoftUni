using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P03_FootballBetting.Data.Models.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(b => b.ColorId);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}
