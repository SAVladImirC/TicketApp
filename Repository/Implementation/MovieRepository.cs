using Domain.Domain;
using Repository.Interface;

namespace Repository.Implementation
{
    public class MovieRepository : GeneralRepository<Movie>, IMovieRepository
    {
        public MovieRepository(TicketAppDbContext context) : base(context)
        {
        }
    }
}
