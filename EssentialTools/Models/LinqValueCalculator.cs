using System;
using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    public class LinqValueCalculator:IValueCalculator
    {
        public Decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(item => item.Price);
        }
    }
}