using Domain.Domain;
using Repository.Interface;
using System.Linq.Expressions;

namespace Repository.Implementation
{
    public class CartRepository : GeneralRepository<Cart>, ICartRepository
    {
        public CartRepository(TicketAppDbContext context) : base(context)
        {
        }

    }
}
