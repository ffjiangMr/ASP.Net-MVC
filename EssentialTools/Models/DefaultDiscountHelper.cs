using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class DefaultDiscountHelper : IDiscountHelper
    {
        public Decimal DiscountSize { get; set; }

        public Decimal ApplyDiscount(Decimal totalParam)
        {
            return (totalParam - (this.DiscountSize / 100m * totalParam));
        }
    }
}