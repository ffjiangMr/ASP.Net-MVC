using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class NavController : Controller
    {

        private IProductsRepository repository;

        public NavController(IProductsRepository repo)
        {
            this.repository = repo; 
        }

        public PartialViewResult Menu(String category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<String> categories = this.repository.Products.Select(item => item.Category)
                                                                     .Distinct()
                                                                     .OrderBy(item => item);
            return PartialView(categories);
        }
    }
}