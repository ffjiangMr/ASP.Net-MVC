using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        private String name;
        public String Name { get { return this.ProductID.ToString() + this.name; } set { this.name = value; } }
        public Int32 ProductID { get; set; }
        public String Description { get; set; }
        public Decimal Price { get; set; }
        public String Category { get; set; }
    }
}