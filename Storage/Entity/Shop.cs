namespace Project.Storage.Entity
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public Shop_Rating Shop_Rating { get; set; }
    }
}
