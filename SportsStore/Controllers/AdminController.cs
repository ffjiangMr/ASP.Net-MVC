using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Controllers
{
    public class AdminController : Controller
    {
        private IProductsRepository repository;

        public AdminController(IProductsRepository repo)
        {
            this.repository = repo;
        }

        public ViewResult Index()
        {
            return View(this.repository.Products);
        }

        public ViewResult Edit(Int32 productId)
        {
            Product product = this.repository.Products.FirstOrDefault(item => item.ProductID == productId);
            return View(product);
        }
    }
}