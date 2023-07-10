using Domain.Domain;

namespace Service.Interface
{
    public interface IMovieService
    {
        public Task<List<Movie>> GetAll();
    }
}
