using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P03_FootballBetting.Data.Models
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(b => b.GameId);

            builder.Property(b => b.DateTime)
                .HasColumnType("DATETIME2");

            builder.HasOne(b => b.HomeTeam)
                .WithMany(h => h.HomeGames)
                .HasForeignKey(b => b.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.AwayTeam)
                .WithMany(a => a.AwayGames)
                .HasForeignKey(b => b.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
