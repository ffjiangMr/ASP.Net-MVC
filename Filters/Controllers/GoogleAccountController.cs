using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Filters.Controllers
{
    public class GoogleAccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(String userName, String password, String returnUrl)
        {
            if (userName.EndsWith("@google.com") && password == "secret")
            {
                FormsAuthentication.SetAuthCookie(userName, false);
                return Redirect(returnUrl ?? Url.Action("Index", "Home"));
            }
            else
            {
                ModelState.AddModelError("", "Incorrect userName or password");
                return View();
            }

        }

    }
}