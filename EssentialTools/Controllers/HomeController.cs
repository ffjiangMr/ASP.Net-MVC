﻿using EssentialTools.Models;
using System;
using System.Web.Mvc;
using Ninject;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;

        public HomeController(IValueCalculator calcParam, IValueCalculator calcParam2)
        {
            this.calc = calcParam;
        }

        private Product[] products = new Product[] {
                                                    new Product (){ Name="Kayak",Category="Watersports",Price=275M },
                                                    new Product (){ Name="Lifejacket",Category="Watersports",Price=48.95M },
                                                    new Product (){ Name="Soccer ball",Category="Soccer",Price=19.50M },
                                                    new Product (){ Name="Corner flag",Category="Soccer",Price=34.95M },
                                                   };
        
        // GET: Home
        public ActionResult Index()
        {           
            ShoppingCart cart = new ShoppingCart(this.calc) { Products = products };
            Decimal totalVale = cart.CalculateProductTotal();
            return View(totalVale);
        }
    }
}