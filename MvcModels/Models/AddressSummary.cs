using System;
using System.Web.Mvc;

namespace MvcModels.Models
{
    public class AddressSummary
    {
        public String City { get; set; }

        [HiddenInput]
        public String Country { get; set; }
    }
}