namespace Project.Storage.Entity
{
    public class Users_With_Mailing
    {
        public int Id { get; set; }
        public string email { get; set; }
        public int User_Id { get; set; }
        public Users Users { get; set; }
    }
}
