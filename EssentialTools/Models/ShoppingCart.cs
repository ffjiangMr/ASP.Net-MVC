using System;
using System.Collections.Generic;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calc;
        public ShoppingCart(IValueCalculator calcParam)
        {
            this.calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public Decimal CalculateProductTotal() {
            return calc.ValueProducts(Products);
        }
    }
}