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
            var product = await _productservice.GetProductByID(ID);
            return View(product);
        }
    }
}
//create orderservice
//Fixa att ordern registrerass
//Fixa inlämning
//fixa försening om man lämnar in sent
//Försök göra ett sökfält
//CSS - design