using Domain.Domain;
using Repository.Interface;
using Service.Interface;

namespace Service.Implementation
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task<List<Ticket>> GetAll()
        {
            return await _ticketRepository.FindAll(t => true);
        }

        public async Task<Ticket> Insert(Ticket ticket)
        {
            return await _ticketRepository.Insert(ticket);
        }
    }
}
