using System;
using System.ComponentModel.DataAnnotations;

namespace ClientFeatures.Models
{
    public class Appointment
    {
        [Required]
        public String ClientName { get; set; }

        public Boolean TermAccepted { get; set; }
    }
}