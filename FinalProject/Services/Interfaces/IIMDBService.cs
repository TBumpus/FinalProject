using FinalProject.Models;

namespace FinalProject.Services.Interfaces
{
    public interface IIMDBService
    {
        Task<Movie> GetMovieByName(string searchTerm);
    }
}
