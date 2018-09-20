using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        Decimal ApplyDiscount(Decimal totalParam);
    }
}
