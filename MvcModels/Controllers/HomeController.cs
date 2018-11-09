using MvcModels.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MvcModels.Controllers
{
    public class HomeController : Controller
    {
        private Person[] personData =
            {
            new Person(){FirstName = "Adam" , LastName ="Freeman",Role =Role.Admin},
            new Person(){FirstName = "Jacqui" , LastName ="Griffyth",Role =Role.User},
            new Person(){FirstName = "John" , LastName ="Smith",Role =Role.User},
            new Person(){FirstName = "Anne" , LastName ="Jones",Role =Role.Guest},
        };

        [HttpGet]
        public ActionResult Index(Int64 input)
        {
            Person dataItem = this.personData.Where(item => item.PersonId == input).FirstOrDefault();
            return View(dataItem);
        }

        public ActionResult DisplaySummary(AddressSummary summary)
        {
            return View(summary);
        }

    }
}