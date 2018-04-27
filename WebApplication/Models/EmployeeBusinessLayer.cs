namespace WebApplication.Models
{
    #region using directive

    using System;
    using System.Collections.Generic;
    using DataAccessLayer;
    using System.Linq;

    #endregion 

    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }

        public Employee SaveEmployee(Employee input)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(input);
            salesDal.SaveChanges();
            return input;
        }

    }
}