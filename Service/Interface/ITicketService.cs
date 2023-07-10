using Domain.Domain;

namespace Service.Interface
{
    public interface ITicketService
    {
        public Task<List<Ticket>> GetAll();
        public Task<Ticket> Insert(Ticket ticket);
    }
}
