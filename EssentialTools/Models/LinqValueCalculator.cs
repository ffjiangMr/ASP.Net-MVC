using System;
using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discountHelper;
        private static Int32 counter = 0;

        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            this.discountHelper = discountParam;
            System.Diagnostics.Debug.WriteLine($"Instance {counter ++} created");
        }

        public Decimal ValueProducts(IEnumerable<Product> products)
        {
            return this.discountHelper.ApplyDiscount(products.Sum(item => item.Price));
        }
    }
}