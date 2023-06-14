using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fireflower_backend.Storage.Entity;

public class Payment
{
    [Key] public int Id { get; set; }
    public string address { get; set; }
    public int Sum_cost { get; set; }
    public string payment_info { get; set; }

    [ForeignKey("User")] public int UserId { get; set; }

    public Users Users { get; set; }


    [ForeignKey("Product")] public int Product_id { get; set; }

    public Product Product { get; set; }
}