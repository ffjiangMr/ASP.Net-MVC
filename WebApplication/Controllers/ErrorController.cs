namespace WebApplication.Controllers
{
    #region using directive

    using System;
    using System.Web.Mvc;

    #endregion

    [AllowAnonymous]
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            Exception e = new Exception("Invalid Controller or/and Action Name");
            HandleErrorInfo errorInfo = new HandleErrorInfo(e, "Unknow", "Unknow");
            return View("Error", errorInfo);
        }
    }
}