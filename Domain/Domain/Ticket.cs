using Domain.Join;

namespace Domain.Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public DateTime ValidFrom { get; set; } = DateTime.Now;
        public DateTime ValidTo { get; set; } = DateTime.Now;
        public float Price { get; set; }
        public int SeatNumber { get; set; }

        public Guid? MovieId { get; set; }
        public Movie? Movie { get; set; }

        public virtual List<Cart> Carts { get; set; } = new();

        public virtual List<CartItem> CartItems { get; set; } = new();
    }
}