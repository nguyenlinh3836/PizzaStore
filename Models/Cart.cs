using System.Collections.Generic;
using System.Linq;

namespace PizzaStore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem(Product product, int quantity, Size size)
        {
            CartLine line = Lines
                .Where(p => p.Product.ProductId == product.ProductId).Where(p=>p.Size.SizeId == size.SizeId)
                .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity,
                    Size = size
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product, Size size)
            => Lines.RemoveAll(l => l.Product.ProductId == product.ProductId && l.Size.SizeId == size.SizeId);

        public decimal ComputeTotalValue()
            => Lines.Sum(e => e.Size.Price * e.Quantity);

        public void Clear()
            => Lines.Clear();
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Size Size { get; set; }
    }
}
