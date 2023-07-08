using Domain.Join;

namespace Domain.Domain
{
#nullable disable
    public class Ticket
    {
        public Guid Id { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int SeatNumber { get; set; }

        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

        public virtual List<Cart> Carts { get; set; }

        public virtual List<CartItem> CartItems { get; set; }
    }
}