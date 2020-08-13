using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BorrowStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BorrowStore.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult AllProducts()
        {
            var ProductList = TestData.ProductList();
            return View(ProductList);
        }

        public IActionResult ViewProduct(int ID)
        {
            var product = (from e in TestData.ProductList()
                          where e.ID == ID
                          select e).SingleOrDefault();

            return View(product);
        }
    }

    static class TestData
    {
        public static List<Product> ProductList()
        {
            List<Product> ProductList = new List<Product>()
            {
                new Product {ID = 1, Name = "Bok", Description = "Cool Book"},
                new Product {ID = 2, Name = "Spel", Description = "Action Game"},
                new Product {ID = 3, Name = "Dator", Description = "Arbets dator"},
                new Product {ID = 4, Name = "Gitarr", Description = "Hög kvalitet"}
            };

            return ProductList;
        }
    }
}
