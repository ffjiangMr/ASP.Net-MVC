using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsStore.Models
{
    public class PagingInfo
    {
        public Int32 TotalItems { get; set; }
        public Int32 ItemsPerpage { get; set; }
        public Int32 CurrentPage { get; set; }
        public Int32 TotalPages { get { return (Int32)Math.Ceiling((Decimal)TotalItems / ItemsPerpage); } }
    }
}