namespace FinalProject.Models
{
    public class Recommendation
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Suggestion { get; set; }
        
    }
}
