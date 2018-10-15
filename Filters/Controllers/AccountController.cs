using System;
using System.Web.Mvc;
using System.Web.Security;

namespace Filters.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(String userName, String password, String returnUrl)
        {
            Boolean result = FormsAuthentication.Authenticate(userName, password);
            if (result)
            {
                FormsAuthentication.SetAuthCookie(userName, false);
                return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
            }
            else
            {
                ModelState.AddModelError("","Incorrect userName or password");
                return View();
            }
        }

    }
}