namespace WebApplication.ViewModels
{
    #region using directive

    using System;

    #endregion

    public class BaseViewModel
    {
        public String UserName { get; set; }
        public FooterViewModel FooterData { get; set; }
    }
}