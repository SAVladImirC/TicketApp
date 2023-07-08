using Domain.Identity;

namespace Domain.Domain
{
#nullable disable
    public class Order
    {
        public Guid Id { get; set; }

        public string OrderedById { get; set; }
        public virtual ApplicationUser OrderedBy { get; set; }
    }
}
