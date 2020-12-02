using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public class ProductSize
    {
        public long ProductID { get; set; }
        public Product Product { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
    }
}
