namespace TeamBuilder.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TeamBuilder.Models;

    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsUnicode();

            builder.Property(b => b.Description)
                .IsUnicode();

            builder.Property(b => b.StartDate)
                .HasColumnType("DATETIME2");

            builder.Property(b => b.EndDate)
                .HasColumnType("DATETIME2");

            builder.HasOne(b => b.Creator)
                .WithMany(b => b.CreatedEvents)
                .HasForeignKey(b => b.CreatorId);
        }
    }
}