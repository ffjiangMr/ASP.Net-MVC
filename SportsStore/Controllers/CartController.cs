﻿using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class CartController : Controller
    {
        private IProductsRepository repository;

        public CartController(IProductsRepository repo)
        {
            this.repository = repo;
        }

        public ViewResult Index(String returnUrl)
        {
            return View(new CartIndexViewModel()
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl,
            });
        }

        public RedirectToRouteResult AddToCart(Int32 productId, String returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(item => item.ProductID == productId);
            if (product != null)
            {
                GetCart().AddItem(product, 1);
            }
            return RedirectToAction("Index","Cart", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Int32 productId, String returnUrl)
        {
            Product product = this.repository.Products.FirstOrDefault(item => item.ProductID == productId);
            if (product != null)
            {
                GetCart().RemoveLine(product);
            }
            return RedirectToAction("Index", "Cart", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

    }
}