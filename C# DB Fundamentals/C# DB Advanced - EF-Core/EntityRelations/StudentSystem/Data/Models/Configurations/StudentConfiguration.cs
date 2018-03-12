﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P01_StudentSystem.Data.Models.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.StudentId);

            builder.Property(e => e.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(100);

            builder.Property(e => e.PhoneNumber)
                .IsRequired(false)
                .IsUnicode(false)
                .HasColumnType("char(10)");

            builder.Property(e => e.RegisteredOn)
                .IsRequired()
                .HasColumnType("DATETIME2");

            builder.Property(e => e.Birthday)
                .HasColumnType("DATETIME2");
        }
    }
}
