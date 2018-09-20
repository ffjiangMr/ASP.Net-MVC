using System;
using System.Collections.Generic;

namespace EssentialTools.Models
{
    public interface IValueCalculator
    {
        Decimal ValueProducts(IEnumerable<Product> products);
    }
}
