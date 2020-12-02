using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }          
        public string Img { get; set; }
        public string Category { get; set; }
        public int? Sizeid { get; set; }
        public virtual ICollection<Size> Sizes { get; set; }

    }
}
