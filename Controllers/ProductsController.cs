using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Data;
using TechnicalTest.Models;

namespace TechnicalTest.Controllers
{
    public class ProductsController : Controller
    {
        public Product[] Index()
        {
            return ProductDal.GetProducts();
        }

        public int Count()
        {
            return ProductDal.CountProducts();
        }
    }
}