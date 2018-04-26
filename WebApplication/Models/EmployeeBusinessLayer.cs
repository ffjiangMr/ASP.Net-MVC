namespace WebApplication.Models
{
    #region using directive

    using System;
    using System.Collections.Generic;

    #endregion 

    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            var result = new List<Employee>();

            Employee emp = new Employee();
            emp.FirstName = "johnson";
            emp.LastName = " fernandes";
            emp.Salary = 14000;
            result.Add(emp);

            emp = new Employee();
            emp.FirstName = "michael";
            emp.LastName = "jackson";
            emp.Salary = 16000;
            result.Add(emp);

            emp = new Employee();
            emp.FirstName = "robert";
            emp.LastName = " pattinson";
            emp.Salary = 20000;
            result.Add(emp);

            return result;
        }
    }
}