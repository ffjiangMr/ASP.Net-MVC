using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Controllers
{
    [Authorize]
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
        public ActionResult Edit(Product product, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    product.ImageMimeType = image.ContentType;
                    product.ImageData = new Byte[image.ContentLength];
                    image.InputStream.Read(product.ImageData, 0, product.ImageData.Length);
                }
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