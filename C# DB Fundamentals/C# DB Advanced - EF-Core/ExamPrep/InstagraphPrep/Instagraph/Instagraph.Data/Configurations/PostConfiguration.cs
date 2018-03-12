namespace Instagraph.Data.Configurations
{
    using Instagraph.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(b => b.Id);

            builder.HasOne(b => b.User)
                .WithMany(b => b.Posts)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.Picture)
                .WithMany(b => b.Posts)
                .HasForeignKey(b => b.PictureId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}