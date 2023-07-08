using Domain.Join;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configuration.Join
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(ci => new { ci.CartId, ci.TicketId });

            builder
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(ci => ci.CartId);

            builder
                .HasOne(ci => ci.Ticket)
                .WithMany(t => t.CartItems)
                .HasForeignKey(ci => ci.TicketId);
        }
    }
}
