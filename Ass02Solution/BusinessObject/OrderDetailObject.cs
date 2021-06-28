using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BusinessObject
{
    public class OrderDetailObject
    {
        [Key, ForeignKey("Order")]
        public int OrderId { get; set; }
        [Key, ForeignKey("Product")]
        public int ProductId { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        public virtual OrderObject Order { get; set; }

        public virtual ProductObject Product { get; set; }
    }
}
