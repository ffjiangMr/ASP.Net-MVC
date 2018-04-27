namespace WebApplication.Models
{
    #region using directive

    using System;
    using System.ComponentModel.DataAnnotations;

    #endregion 

    public class Employee
    {
        [Key]
        public Int32 EmployeeId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Int32 Salary { get; set; }
    }
}