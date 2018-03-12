using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P01_StudentSystem.Data.Models.Configurations
{
    public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.HasKey(e => e.HomeworkId);

            builder.Property(e => e.Content)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.ContentType)
                .IsRequired();

            builder.Property(e => e.SubmissionTime)
                .IsRequired()
                .HasColumnType("DATETIME2");

            builder.HasOne(e => e.Student)
                .WithMany(s => s.HomeworkSubmissions)
                .HasForeignKey(e => e.StudentId);

            builder.HasOne(e => e.Course)
                .WithMany(c => c.HomeworkSubmissions)
                .HasForeignKey(e => e.CourseId);
        }
    }
}
