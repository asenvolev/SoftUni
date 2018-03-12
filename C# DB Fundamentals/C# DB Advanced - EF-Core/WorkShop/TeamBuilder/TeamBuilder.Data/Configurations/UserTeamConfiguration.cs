

namespace TeamBuilder.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;

    public class UserTeamConfiguration : IEntityTypeConfiguration<UserTeam>
    {
        public void Configure(EntityTypeBuilder<UserTeam> builder)
        {
            builder.HasKey(b => new { b.TeamId, b.UserId });

            builder.HasOne(b => b.User)
                .WithMany(b => b.UserTeams)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.Team)
                .WithMany(b => b.UserTeams)
                .HasForeignKey(b => b.TeamId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}