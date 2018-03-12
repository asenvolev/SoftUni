namespace TeamBuilder.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;

    internal class TeamEventConfiguration : IEntityTypeConfiguration<TeamEvent>
    {
        public void Configure(EntityTypeBuilder<TeamEvent> builder)
        {
            builder.HasKey(b => new { b.TeamId, b.EventId });

            builder.HasOne(b => b.Event)
                .WithMany(b => b.ParticipatingEventTeams)
                .HasForeignKey(b => b.EventId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.Team)
                .WithMany(b => b.Events)
                .HasForeignKey(b => b.TeamId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}