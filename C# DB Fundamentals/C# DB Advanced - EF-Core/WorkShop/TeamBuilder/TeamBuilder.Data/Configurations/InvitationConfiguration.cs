namespace TeamBuilder.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;

    public class InvitationConfiguration : IEntityTypeConfiguration<Invitation>
    {
        public void Configure(EntityTypeBuilder<Invitation> builder)
        {
            builder.HasKey(b => b.Id);

            builder.HasOne(b => b.InvitedUser)
                .WithMany(u => u.ReceivedInvitations)
                .HasForeignKey(b => b.InvitedUserId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(b => b.Team)
                .WithMany(t => t.Invitations)
                .HasForeignKey(b => b.TeamId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}