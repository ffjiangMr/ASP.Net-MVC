namespace WebApplication.Models
{
    #region using directive

    using DataAccessLayer;
    using System.Collections.Generic;
    using System.Linq;
    using System;

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

        public Boolean IsValidUser(UserDetails u)
        {
            if (u.UserName == "Admin" && u.Password == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UserStatus GetUserValidity(UserDetails u)
        {
            if ((u.UserName == "Admin") && (u.Password == "Admin"))
            {
                return UserStatus.AuthenticatedAdmin;
            }
            else if ((u.UserName == "Sukesh") && (u.Password == "Sukesh"))
            {
                return UserStatus.AuthenticatedUser;
            }
            else
            {
                return UserStatus.NonAuthenticatedUser;
            }
        }


    }
}