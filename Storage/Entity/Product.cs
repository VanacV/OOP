namespace Project.Storage.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int price { get; set; }

        public int shop_id { get; set; }
        public Shop Shop { get; set; }
        public Product_Rating Product_Rating { get; set; }
        public Payment Payment { get; set; }
    }
}
