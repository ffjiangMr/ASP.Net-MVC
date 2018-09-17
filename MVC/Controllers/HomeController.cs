using MVC.Models;
using System;
using System.Web.Mvc;
using System.Web;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home        
        public ActionResult Index()
        {
            Int32 time = DateTime.Now.Hour;
            ViewBag.Greeting = time < 12 ? "Good morning" : "Good afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

    }
}