using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SportsStore.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public Int32 ProductID { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public String Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a description")]
        public String Description { get; set; }

        [Required]
        [Range(0.01, Double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public Decimal Price { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public String Category { get; set; }

        public Byte[] ImageData { get; set; }

        public String ImageMimeType { get; set; }
    }
}
