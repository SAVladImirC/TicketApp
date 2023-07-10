using Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name).HasMaxLength(256);

            builder.Property(m => m.Director).HasMaxLength(256);

            builder
                .HasOne(m => m.Ticket)
                .WithOne(m => m.Movie)
                .HasForeignKey<Movie>(m => m.TicketId)
                .IsRequired(false);
        }
    }
}
