using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Product product, Int32 quantity)
        {
            CartLine line = lineCollection.Where(item => item.Product.ProductID == product.ProductID).FirstOrDefault();
            if (line == null)
            {
                this.lineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product)
        {
            this.lineCollection.RemoveAll(item => item.Product.ProductID == product.ProductID);
        }

        public Decimal ComputeTotalValue()
        {
            return this.lineCollection.Sum(item => item.Quantity * item.Product.Price);
        }

        public void Clear()
        {
            this.lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines { get { return this.lineCollection; } }

    }

    public class CartLine
    {
        public Product Product { get; set; }
        public Int32 Quantity { get; set; }
    }

}
