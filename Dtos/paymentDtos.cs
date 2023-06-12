using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Dtos;

public class paymentDtos
{
   
    public string address { get; set; }
    public int Sum_cost { get; set; }
    public int payment_info { get; set; }
    public int deliveryTime { get; set; }

    [ForeignKey("User")] public int UserId { get; set; }



    [ForeignKey("Product")] public int Product_id { get; set; }


}