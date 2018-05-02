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
            UserStatus status = bal.GetUserValidity(u);
            Boolean isAdmin = false;
            if (status == UserStatus.AuthenticatedAdmin)
            {
                isAdmin = true;
            }
            else if (status == UserStatus.AuthenticatedUser)
            {
                isAdmin = false;
            }
            else
            {
                ModelState.AddModelError("CredentialError", "Invalid username or Password");
                Session.Remove("IsAdmin");
                return View("Login");
            }
            FormsAuthentication.SetAuthCookie(u.UserName, false);
            Session["IsAdmin"] = isAdmin;
            return RedirectToAction("Index", "Employee");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

    }
}