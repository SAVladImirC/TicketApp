using Domain.Domain;
using Domain.Join;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasOne(t => t.Movie)
                .WithOne(m => m.Ticket)
                .HasForeignKey<Ticket>(t => t.MovieId)
                .IsRequired(false);

            builder
                .HasMany(t => t.Carts)
                .WithMany(c => c.Tickets)
                .UsingEntity<CartItem>();
        }
    }
}
