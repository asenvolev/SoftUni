namespace Employees.Data
{
    using Employees.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(b => b.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(b => b.Salary)
                .IsRequired();

            builder.Property(b => b.BirthDay)
                .HasColumnType("DATETIME2");

            builder.HasOne(b => b.Manager)
                .WithMany(b => b.ManagedEmployees)
                .HasForeignKey(b => b.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}