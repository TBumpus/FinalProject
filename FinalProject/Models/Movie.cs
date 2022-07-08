using FinalProject.Enums;

namespace FinalProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Auth0Id { get; set; }
        public string IMDBId { get; set; }
        public string Title { get; set; } = null!;
        public MovieCategory Category { get; set; }

      
        public Movie (int id, string auth0id, string imdbId, string title, MovieCategory category)
        {
            Id = id;
            Auth0Id = auth0id;
            IMDBId = imdbId;
            Title = title;
            Category = category;
        }
    }
}
