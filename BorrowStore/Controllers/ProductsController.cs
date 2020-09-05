using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BorrowStore.Models;
using BorrowStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;

namespace BorrowStore.Controllers
{
    public class ProductsController : Controller
    {
        ProductService _productservice = new ProductService();
        public async Task<IActionResult> AllProducts()
        {
            var ProductList = await _productservice.GetAllProducts();
            return View(ProductList);
        }
        public async Task<IActionResult> ViewProduct(int ID)
        {
            var ProductList = await _productservice.GetAllProducts();

            var product = (from e in ProductList
                           where e.ID == ID
                           select e).SingleOrDefault();

            return View(product);
        }
    }
}
//Försök göra ett sökfält?
//Fixa till bilderna