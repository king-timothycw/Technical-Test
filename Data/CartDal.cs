using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalTest.Models;

namespace TechnicalTest.Data
{
    public class CartDal
    {
        private static readonly List<Product> _database = new();

        public static Product[] GetCart()
        {
            return _database.ToArray();
        }

        public static void AddProduct(int productId)
        {
            // TODO: Add product to _database
        }

        public static void RemoveProduct(int productId)
        {
            // TODO: Remove product from _database
        }
    }
}