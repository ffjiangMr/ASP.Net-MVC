
namespace WebApplication.Models
{
    #region using directive

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    #endregion 

    public class Employee
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Int32 Salary { get; set; }
    }
}