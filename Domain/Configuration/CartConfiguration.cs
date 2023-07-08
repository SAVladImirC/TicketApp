using Domain.Domain;
using Domain.Join;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .HasOne(c => c.Owner)
                .WithOne(u => u.Cart)
                .HasForeignKey<Cart>(c => c.OwnerId);

            builder
                .HasMany(c => c.Tickets)
                .WithMany(t => t.Carts)
                .UsingEntity<CartItem>();
        }
    }
}
