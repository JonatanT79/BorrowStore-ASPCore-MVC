using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BorrowStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BorrowStore.Controllers
{
    public class Products : Controller
    {
        public IActionResult AllProducts()
        {
            var ProductList = TestData.ProductList();
            return View(ProductList);
        }
    }

    static class TestData
    {
        public static List<Product> ProductList()
        {
            List<Product> ProductList = new List<Product>()
            {
                new Product {ID = 1, Name = "Book", Description = "Cool Book"},
                new Product {ID = 2, Name = "Spel", Description = "Action Game"}
            };

            return ProductList;
        }
    }
}
