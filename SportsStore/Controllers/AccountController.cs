using SportsStore.Infrastructure.Abstract;
using SportsStore.Models;

using System;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class AccountController : Controller
    {
        private IAuthProvider authProvider;

        public AccountController(IAuthProvider provider)
        {
            this.authProvider = provider;
        }

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, String returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (this.authProvider.Authenticate(model.UserName, model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}