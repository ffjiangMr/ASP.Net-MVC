using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;

        public ProductController(IProductsRepository productRepository)
        {
            this.repository = productRepository;
        }

        [HttpGet]
        public ViewResult List()
        {
            return View(this.repository.Products);

        }
    }
}