namespace FinalProject.Models
{
    public class Result
    {
        public string id { get; set; }
        public string resultType { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class MovieAPI
    {
        public string searchType { get; set; }
        public string expression { get; set; }
        public List<Result> results { get; set; }
        public string errorMessage { get; set; }
    }


}
