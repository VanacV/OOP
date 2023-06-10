using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace fireflower_backend.Storage.Entity
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public string address { get; set; }
        public int Sum_cost { get; set; }
        public int payment_info { get; set; }
        public int deliveryTime { get; set; }
        [JsonIgnore]
        [ForeignKey("User")]
        public int UserId { get; set; }
        [JsonIgnore]
        public Users Users { get; set; }
        
        [JsonIgnore]
        [ForeignKey("Product")]
        public int Product_id { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
    }
}
