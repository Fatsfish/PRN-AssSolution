using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace BusinessObject
{
    [Table("OrderDetail", Schema ="dbo")]
    public class OrderDetailObject
    {

        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public Double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

    }
}
