﻿using Filters.Infrastructure;

using System;
using System.Web.Mvc;

namespace Filters.Controllers
{

    public class HomeController : Controller
    {

        [CustomAuth(true)]
        public String Index()
        {
            return "This is the Index action on the home controller";
        }

        //[GoogleAuth]
        [CustomAuth(true)]
        [HttpGet]
        public String List()
        {            
            return "This is the List action on the Home controller";
        }

        [HttpGet]
        [RangeException]
        public String RangeTest(Int32 id)
        {
            if (id > 100)
            {
                return $"The id value is : {id}";
            }
            else {
                throw new ArgumentOutOfRangeException("id",id,"");
            }
        }

    }
}