using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Storage.Entity
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public string address { get; set; }
        public int Sum_cost { get; set; }
        public bool WithPostCard { get; set; }
        public string postCard { get; set; }
        public int payment_info { get; set; }
        public int deliveryTime { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public Users Users { get; set; }

        [ForeignKey("Product")]
        public int Product_id { get; set; }
        public Product Product { get; set; }
    }
}
