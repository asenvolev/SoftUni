using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P03_FootballBetting.Data.Models.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(b => b.PlayerId);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(b => b.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(b => b.PlayerId);

            builder.HasOne(b => b.Position)
                .WithMany(p => p.Players)
                .HasForeignKey(b => b.PlayerId);
        }
    }
}
