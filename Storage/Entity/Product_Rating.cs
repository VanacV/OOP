﻿namespace fireflower_backend.Storage.Entity
{
    public class Product_Rating
    {
        public int Id { get; set; }
        public double Rate { get; set; }
        public string Comment { get; set; }
        public int product_id { get; set; }
        public Product Product { get; set; }
    }
}
