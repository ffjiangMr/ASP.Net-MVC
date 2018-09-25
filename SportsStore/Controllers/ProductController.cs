﻿using SportsStore.Domain.Abstract;
using System.Web.Mvc;
using System;
using System.Linq;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        public Int32 pageSize = 4;

        public ProductController(IProductsRepository productRepository)
        {
            this.repository = productRepository;
        }

        [HttpGet]
        public ViewResult List(String category, Int32 page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel()
            {
                Products = this.repository.Products.Where(item => String.IsNullOrEmpty(category) || (item.Category == category))
                                                   .OrderBy(item => item.ProductID)
                                                   .Skip((page - 1) * this.pageSize)
                                                   .Take(this.pageSize),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = page,
                    ItemsPerpage = this.pageSize,
                    TotalItems = this.repository.Products.Count(),                   
                },
                CurrentCategory = category,
            };
            return View(model);

        }
    }
}