namespace FinalProject.Models
{
    public class User
    {
        public int Id { get; set; }

        public int AuthId  { get; set; }
        public string UserName { get; set; }    

        public User()
        {

        }
        public User(int id, string userName, int authId)
        {
            Id = id;
            UserName = userName;
            AuthId = authId;
        }
    }
}
