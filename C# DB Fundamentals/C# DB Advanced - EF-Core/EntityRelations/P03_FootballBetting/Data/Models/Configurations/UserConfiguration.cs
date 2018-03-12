using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P03_FootballBetting.Data.Models.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(b => b.UserId);

            builder.Property(b => b.Username)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(b => b.Username)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
