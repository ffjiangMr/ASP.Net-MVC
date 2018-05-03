namespace WebApplication.Filters
{
    #region using directive

    using System;
    using System.Web.Mvc;
    using WebApplication.Logger;

    #endregion

    public class EmployeeExceptionFilter : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            FileLogger logger = new FileLogger();
            logger.LogException(filterContext.Exception);
            base.OnException(filterContext);
        }
    }
}