using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P03_FootballBetting.Data.Models.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(b => b.TeamId);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(b=>b.Initials)
                .HasColumnType("NCHAR(3)");

            builder.HasOne(b => b.PrimaryKitColor)
                .WithMany(p => p.PrimaryKitTeams)
                .HasForeignKey(p => p.PrimaryKitColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.SecondaryKitColor)
                .WithMany(p => p.SecondaryKitTeams)
                .HasForeignKey(p => p.SecondaryKitColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(b => b.LogoUrl)
                .IsUnicode(false);

            builder.HasOne(b => b.Town)
                .WithMany(t => t.Teams)
                .HasForeignKey(b => b.TownId);
        }
    }
}
