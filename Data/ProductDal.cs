using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalTest.Models;

namespace TechnicalTest.Data
{
    public static class ProductDal
    {
        private static readonly List<Product> _database = new()
        {
            new Product()
            {
                ProductId = 1,
                Title = "Product 1",
                Description = "Description 1"
            },
            new Product()
            {
                ProductId = 2,
                Title = "Product 2",
                Description = "Description 2"
            },
            new Product()
            {
                ProductId = 3,
                Title = "Product 3",
                Description = "Description 3"
            }
        };


        public static Product[] GetProducts()
        {
            return _database.ToArray();
        }

        public static int CountProducts()
        {
            return _database.Count;
        }
    }
}