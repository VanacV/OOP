using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Dtos;

public class RatingShopDtos
{
    public int Id { get; set; }
    public double Rate { get; set; }
    public string comment { get; set; }
    public int Shop_Id { get; set; }
    // public Shop Shop { get; set; }
}