namespace Instagraph.Data.Configurations
{
    using Instagraph.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(b => b.Id);

            builder.HasAlternateKey(b => b.Username);

            builder.HasOne(b => b.ProfilePicture)
                .WithMany(b => b.Users)
                .HasForeignKey(b => b.ProfilePictureId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}