namespace WebApplication.Controllers
{
    #region using directive

    using System;
    using System.Web.Mvc;
    using System.Web.Security;
    using WebApplication.Models;

    #endregion

    public class AuthenticationController : Controller
    {
        // GET: Authentication        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoLogin(UserDetails u)
        {
            EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
            if (bal.IsValidUser(u))
            {
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                ModelState.AddModelError("CredentialError", "Invalid username or Password");
                return View("Login");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

    }
}