﻿namespace WebApplication.ViewModels
{
    #region using directive

    using System;

    #endregion

    public class CreateEmployeeViewModel:BaseViewModel
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Salary { get; set; }
    }
}