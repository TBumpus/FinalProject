using FinalProject.Models;
using FinalProject.Services.Interfaces;

namespace FinalProject.Services
{
    public class IMDBService : IIMDBService
    {
        //Get Movie by Name 
        //This is where you insert the API key, etc similar to Angular. 
        public async Task<Movie> GetMovieByName(string searchTerm)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://imdb-api.com/api");

            var response = await client.GetFromJsonAsync<Movie>("?t=" + searchTerm + "&apiKey=k_mse6n4lw");

            return response; 
        }

     
    }
}
