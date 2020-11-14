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
        ProductService productService = new ProductService();
        public async Task<IActionResult> AllProducts()
        {
            var productList = await productService.GetAllProducts();
            return View(productList);
        }
        public async Task<IActionResult> ViewProduct(int ID)
        {
            var product = await productService.GetProductByID(ID);
            return View(product);
        }
    }
}
//TODO:
//Försök göra ett sökfält
//CSS - design