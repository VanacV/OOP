namespace Project.Storage.Entity
{
    public class Shop_Rating
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string comment { get; set; }
        public int Shop_Id { get; set; }
        public Shop Shop { get; set; }
    }
}
