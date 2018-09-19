using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static Decimal TotalPrices(this IEnumerable<Product> cartParam)
        {
            Decimal total = 0;
            foreach (Product item in cartParam)
            {
                total += item.Price;
            }
            return total;
        }

        public static IEnumerable<Product> FilterByCategory(this IEnumerable<Product> productEnum, String categoryParam)
        {
            foreach (Product item in productEnum)
            {
                if (item.Category == categoryParam)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<Product> Filter(this IEnumerable<Product> productEnum, Func<Product, Boolean> selecorParam)
        {
            foreach (Product item in productEnum)
            {
                if (selecorParam(item))
                {
                    yield return item;
                }
            }
        }
    }
}