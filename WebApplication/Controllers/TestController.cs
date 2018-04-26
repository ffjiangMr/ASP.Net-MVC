namespace WebApplication.Controllers
{
    #region using directive

    using System;
    using System.Text;
    using System.Web.Mvc;
    using WebApplication.Models;
    using WebApplication.ViewModels;

    #endregion

    public class Customer
    {
        public String CustomerName { get; set; }
        public String Address { get; set; }

        public override String ToString()
        {
            StringBuilder message = new StringBuilder();
            message.Append(this.CustomerName).Append("|").Append(this.Address);
            return message.ToString();
        }
    }
    public class TestController : Controller
    {

        public Customer GetCustomer()
        {
            var customer = new Customer();
            customer.CustomerName = "Customer 1";
            customer.Address = "Address 1";
            return customer;
        }
        [NonAction]
        public String GetString()
        {
            return "Hello world is old now. It's time for wassup bro";
        }

        public ActionResult GetView()
        {
            var employeeList = new EmployeeBusinessLayer();
            EmployeeListViewModel viewListModel = new EmployeeListViewModel();
            foreach (var employee in employeeList.GetEmployees())
            {
                var employeeViewModel = new EmployeeViewModel();
                employeeViewModel.EmployeeName = employee.FirstName + " " + employee.LastName;
                employeeViewModel.Salary = employee.Salary.ToString("c");
                if (employee.Salary > 15000)
                {
                    employeeViewModel.SalaryColor = "yellow";
                }
                else
                {
                    employeeViewModel.SalaryColor = "green";
                }
                viewListModel.Employees.Add(employeeViewModel);
            }
            viewListModel.UserName = "Administrator";
            return View("MyView", viewListModel);
        }
    }
}