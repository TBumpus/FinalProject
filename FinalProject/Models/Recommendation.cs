using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Recommendation
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        [NotMapped]
        public string UserName { get; set; }
        public string ImageURL { get; set; }
        
        public string Title { get; set; }
        public string IMDBId { get; set;}


    }
}
