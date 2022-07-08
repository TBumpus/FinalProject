using FinalProject.Models;

namespace FinalProject.Services.Interfaces
{
    public interface IIMDBService
    {
        Task<MovieAPI> GetMovieByName(string searchTerm);
    }
}
