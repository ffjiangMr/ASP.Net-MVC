namespace WebApplication.ViewModels
{
    #region using directive

    using System;
    using System.Collections.Generic;

    #endregion 

    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; } = new List<EmployeeViewModel>();
    }
}