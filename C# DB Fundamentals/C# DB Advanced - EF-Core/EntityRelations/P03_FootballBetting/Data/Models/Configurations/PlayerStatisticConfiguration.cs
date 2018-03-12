using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P03_FootballBetting.Data.Models.Configurations
{
    public class PlayerStatisticConfiguration : IEntityTypeConfiguration<PlayerStatistic>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistic> builder)
        {
            builder.HasKey(b => new { b.GameId, b.PlayerId });

            builder.HasOne(b => b.Player)
                .WithMany(p => p.PlayerStatistics)
                .HasForeignKey(b => b.PlayerId);

            builder.HasOne(b => b.Game)
                .WithMany(g => g.PlayerStatistics)
                .HasForeignKey(b => b.GameId);
        }
    }
}
