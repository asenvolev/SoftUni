namespace Instagraph.Data.Configurations
{
    using Instagraph.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserFollowerConfiguration : IEntityTypeConfiguration<UserFollower>
    {
        public void Configure(EntityTypeBuilder<UserFollower> builder)
        {
            builder.HasKey(b => new { b.UserId, b.FollowerId });

            builder.HasOne(b => b.Follower)
                .WithMany(b => b.UsersFollowing)
                .HasForeignKey(b => b.FollowerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.User)
                .WithMany(b => b.Followers)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}