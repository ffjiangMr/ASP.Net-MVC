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
        [Required(ErrorMessage ="Enter First Name")]
        public String FirstName { get; set; }
        [StringLength(5,ErrorMessage ="Last Name length should not be greater than 5")]
        public String LastName { get; set; }
        public Int32 Salary { get; set; }
    }
}