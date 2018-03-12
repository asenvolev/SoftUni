namespace BusTicketSystem.Data.Configurations
{
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(b => b.BankAccountId);

            builder.Property(b => b.Balance)
                .IsRequired();

            builder.HasOne(b => b.Customer)
                .WithMany(b => b.BankAccounts)
                .HasForeignKey(b => b.CustomerId);
        }
    }
}
