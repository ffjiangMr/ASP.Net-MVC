using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;
using EssentialTools.Infrastructure;

namespace EssentialTools.Test
{
    [TestClass]
    public class UnitTest1
    {

        private IDiscountHelper GetTestObject()
        {
            return new MinimumDiscountHelper();
        }

        [TestMethod]
        [Owner("ffjiang")]
        public void Discount_Above_100()
        {
            IDiscountHelper target = this.GetTestObject();
            Decimal total = 200;

            var discountTotal = target.ApplyDiscount(total);

            Assert.AreEqual(total * 0.9M, discountTotal);
        }
    }
}
