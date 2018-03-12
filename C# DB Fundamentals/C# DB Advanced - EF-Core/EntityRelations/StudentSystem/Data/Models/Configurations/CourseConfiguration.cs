using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P01_StudentSystem.Data.Models.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(e => e.CourseId);

            builder.Property(e => e.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(80);

            builder.Property(e => e.Description)
                .IsRequired(false)
                .IsUnicode(false);

            builder.Property(e => e.StartDate)
                .IsRequired()
                .HasColumnType("DATETIME2");

            builder.Property(e => e.EndDate)
                .IsRequired()
                .HasColumnType("DATETIME2");

            builder.Property(e => e.Price)
                .IsRequired();
        }
    }
}
