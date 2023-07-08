using Domain.Domain;
using Repository.Interface;

namespace Repository.Implementation
{
    public class TicketRepository : GeneralRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(TicketAppDbContext context) : base(context)
        {
        }
    }
}
