using Domain.Domain;

namespace Domain.Join
{
#nullable disable
    public class CartItem
    {
        public Guid CartId { get; set; }
        public virtual Cart Cart { get; set; }

        public Guid TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }

        public int Quantity { get; set; }
    }
}
