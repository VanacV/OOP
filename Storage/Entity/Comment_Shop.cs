namespace fireflower_backend.Storage.Entity;

public class Comment_Shop
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int Product_Rating_id { get; set; }
    public Product_Rating Product_Rating { get; set; }
}