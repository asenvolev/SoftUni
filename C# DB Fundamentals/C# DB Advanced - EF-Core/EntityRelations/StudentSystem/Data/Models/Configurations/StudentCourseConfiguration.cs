﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P01_StudentSystem.Data.Models.Configurations
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(e => new { e.StudentId, e.CourseId });

            builder.HasOne(e => e.Student)
                .WithMany(s => s.CourseEnrollments)
                .HasForeignKey(e => e.StudentId);

            builder.HasOne(e => e.Course)
                .WithMany(c => c.StudentsEnrolled)
                .HasForeignKey(e => e.CourseId);
        }
    }
}
