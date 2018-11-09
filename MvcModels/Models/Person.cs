using System;

namespace MvcModels.Models
{
    public class Person
    {
        public Int64 PersonId { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public Address HomeAddress { get; set; }

        public Boolean IsApproved { get; set; }

        public Role Role { get; set; }
    }

    public class Address
    {
        public String Line1 { get; set; }

        public String Line2 { get; set; }

        public String City { get; set; }

        public String PostlCode { get; set; }

        public String Country { get; set; }
    }

    public enum Role
    {
        Admin,
        User,
        Guest,
    }

}