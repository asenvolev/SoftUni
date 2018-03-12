using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamBuilder.Models;

namespace TeamBuilder.Data.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(b => b.Id);

            builder.HasAlternateKey(b => b.Name);

            builder.HasOne(b => b.Creator)
                .WithMany(b => b.CreatedTeams)
                .HasForeignKey(b => b.CreatorId);
        }
    }
}