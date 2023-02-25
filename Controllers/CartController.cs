using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Data;

namespace TechnicalTest.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = CartDal.GetCart();

            return View(cart);
        }

        public void AddProduct(int productId)
        {
            CartDal.AddProduct(productId);
        }

        public void RemoveProduct(int productId)
        {
            CartDal.RemoveProduct(productId);
        }

        public IActionResult RemoveFromCart(int productId)
        {
            RemoveProduct(productId);
            return RedirectToAction("Index");
        }
    }
}