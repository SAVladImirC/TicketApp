using Domain.Domain;
using Repository.Interface;

namespace Repository.Implementation
{
    public class OrderRepository : GeneralRepository<Order>, IOrderRepository
    {
        public OrderRepository(TicketAppDbContext context) : base(context)
        {
        }
    }
}
