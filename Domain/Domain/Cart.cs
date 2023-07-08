using Domain.Identity;
using Domain.Join;

namespace Domain.Domain
{
#nullable disable
    public class Cart
    {
        public Guid Id { get; set; }

        public string OwnerId { get; set; }
        public virtual ApplicationUser Owner { get; set; }

        public virtual List<Ticket> Tickets { get; set; }

        public virtual List<CartItem> CartItems { get; set; }
    }
}
