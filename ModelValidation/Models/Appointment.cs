using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation.Models
{
    public class Appointment
    {
        public String ClientName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public Boolean TermsAccepted { get; set; }
    }
}