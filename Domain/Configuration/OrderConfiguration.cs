using Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder
            .HasOne(c => c.OrderedBy)
            .WithMany(u => u.Orders)
            .HasForeignKey(c => c.OrderedById);
        }
    }
}
