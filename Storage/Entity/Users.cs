namespace Project.Storage.Entity
{
    public class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int Auth_id { get; set; }
        public Auth Auth { get; set; }
        public Payment Payment { get; set; }
        public Users_With_Mailing Malling { get; set; }
    }
}
