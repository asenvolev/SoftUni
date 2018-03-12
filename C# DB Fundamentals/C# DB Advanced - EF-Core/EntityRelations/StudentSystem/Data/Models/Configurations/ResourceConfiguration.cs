using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P01_StudentSystem.Data.Models.Configurations
{
    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(e => e.ResourceId);

            builder.Property(e => e.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

            builder.Property(e => e.Url)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.ResourceType)
                .IsRequired();

            builder.HasOne(e => e.Course)
                .WithMany(c => c.Resources)
                .HasForeignKey(e => e.CourseId);
        }
    }
}
