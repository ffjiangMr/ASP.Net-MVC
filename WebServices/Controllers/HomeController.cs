using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class HomeController:AsyncController
    {
        private ReservationRepository repo = ReservationRepository.Current;

        public ViewResult Index()
        {
            return View(this.repo.GetAll());
        }
        
    }
}