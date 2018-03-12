namespace Instagraph.Data.Configurations
{
    using Instagraph.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(b => b.Id);

            builder.HasOne(b => b.User)
                .WithMany(b => b.Comments)
                .HasForeignKey(b => b.UserId);

            builder.HasOne(b => b.Post)
                .WithMany(b => b.Comments)
                .HasForeignKey(b => b.PostId);
        }
    }
}