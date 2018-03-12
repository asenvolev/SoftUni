using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    public class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.HasKey(b => b.CreditCardId);

            builder.Property(b => b.Limit)
                .IsRequired();

            builder.Property(b => b.MoneyOwed)
                .IsRequired();

            builder.Ignore(b => b.LimitLeft);

            builder.Ignore(b => b.PaymentMethodId);

            builder.Property(b => b.ExpirationDate)
                .IsRequired()
                .HasColumnType("DATETIME2");
        }
    }
}
