﻿using ModelValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelValidation.Controllers
{
    public class HomeController : AsyncController
    {
        [HttpGet]
        public ViewResult MakeBooking()
        {
            return View(new Appointment() { Date = DateTime.Now });
        }

        [HttpPost]
        public ViewResult MakeBooking(Appointment appt)
        {
            return View("Completed", appt);
        }

    }
}