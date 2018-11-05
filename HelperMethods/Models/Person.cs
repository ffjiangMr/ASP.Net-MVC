using System;
using System.Web.Mvc;

namespace HelperMethods.Models
{
    public class Person
    {
        [HiddenInput]
        public Int32 PersonId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Address HomeAdderss { get; set; }
        public Boolean IsApproved { get; set; }
        public Role Role { get; set; }
    }

    public class Address
    {
        public String Line1 { get; set; }
        public String Line2 { get; set; }
        public String City { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
    }

    public enum Role
    {
        Admin,
        User,
        Guest,
    }

}