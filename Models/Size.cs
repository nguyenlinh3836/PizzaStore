using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public class Size
    {
        public int SizeId { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        public long ProductId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
