using Domain.Configuration;
using Domain.Configuration.Join;
using Domain.Domain;
using Domain.Identity;
using Domain.Join;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class TicketAppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        public TicketAppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new CartConfiguration().Configure(builder.Entity<Cart>());
            new MovieConfiguration().Configure(builder.Entity<Movie>());
            new OrderConfiguration().Configure(builder.Entity<Order>());
            new TicketConfiguration().Configure(builder.Entity<Ticket>());
            new CartItemConfiguration().Configure(builder.Entity<CartItem>());
        }
    }
}