namespace Project.Storage.Entity
{
    public class Product_Rating
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
        public int product_id { get; set; }
        public Product Product { get; set; }
    }
}
