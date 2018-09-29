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

        [HttpGet]
        public ViewResult Edit(Int32 productId)
        {
            Product product = this.repository.Products.FirstOrDefault(item => item.ProductID == productId);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                this.repository.SaveProduct(product);
                TempData["message"] = $"{product.Name} has been saved";
                return Redirect("Index");
            }
            else
            {
                return View(product);
            }
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View("Edit", new Product());
        }

        [HttpPost]
        public ActionResult Delete(Int32 productId)
        {
            Product entity = this.repository.DeleteProduct(productId);
            if (entity != null)
            {
                TempData["message"] = $"{entity.Name} was deleted";
            }

            return RedirectToAction("Index");
        }
    }
}