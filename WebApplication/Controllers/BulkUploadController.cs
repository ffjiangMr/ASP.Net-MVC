namespace WebApplication.Controllers
{

    #region using directive

    using System.Web.Mvc;
    using WebApplication.Filters;
    using WebApplication.ViewModels;
    using System.Collections.Generic;
    using WebApplication.Models;
    using System.IO;
    using System;
    using System.Threading.Tasks;

    #endregion

    public class BulkUploadController : AsyncController
    {
        // GET: BulkUpload
        [HeaderFooterFilter]
        [AdminFilter]
        public ActionResult Index()
        {
            return View(new FileUploadViewModel());
        }

        [AdminFilter]
        public async Task<ActionResult> Upload(FileUploadViewModel model)
        {
            List<Employee> employees = await Task.Run(() => this.GetEmployees(model));
            EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
            bal.UploadEmployees(employees);
            return RedirectToAction("index", "employee");
        }

        private List<Employee> GetEmployees(FileUploadViewModel model)
        {
            List<Employee> employees = new List<Employee>();
            using (StreamReader reader = new StreamReader(model.fileUpload.InputStream))
            {
                var buffer = reader.ReadLine();
                while (!String.IsNullOrEmpty(buffer))
                {
                    var values = buffer.Split(',');
                    Employee e = new Employee();
                    e.FirstName = values[0];
                    e.LastName = values[1];
                    Int32 temmValue;
                    Int32.TryParse(values[2], out temmValue);
                    e.Salary = temmValue;
                    employees.Add(e);
                    buffer = reader.ReadLine();
                }
                return employees;
            }
        }
    }
}