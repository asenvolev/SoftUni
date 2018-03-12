namespace ProductsShop.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductsShop.Models;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(b => b.Price)
                .IsRequired();

            builder.HasOne(b => b.Buyer)
                .WithMany(b => b.ProductsBought)
                .HasForeignKey(b => b.BuyerId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(b => b.Seller)
                .WithMany(b => b.ProductsSold)
                .HasForeignKey(b => b.SellerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}