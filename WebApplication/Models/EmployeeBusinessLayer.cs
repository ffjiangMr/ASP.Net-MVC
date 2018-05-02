﻿namespace WebApplication.Models
{
    #region using directive

    using DataAccessLayer;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

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