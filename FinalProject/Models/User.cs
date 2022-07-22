namespace FinalProject.Models
{
    public class User
    {
        public int Id { get; set; }

        public string AuthId  { get; set; }
        public string UserName { get; set; }    

        public User()
        {

        }
        public User(int id, string userName, string authId)
        {
            Id = id;
            UserName = userName;
            AuthId = authId;
        }
    }
}
