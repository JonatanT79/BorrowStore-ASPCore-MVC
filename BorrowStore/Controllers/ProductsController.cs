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
        public async Task<IActionResult> AllProducts(string searchString)
        {
            ProductVM productVM = new ProductVM();
            List<Product> allProducts = await productService.GetAllProducts();
            productVM.productCount = allProducts.Count();

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                productVM.productList = await productService.GetAllSearchedProducts(searchString);
                return View(productVM);
            }
            else
            {
                productVM.productList = allProducts;
                return View(productVM);
            }
        }
        public async Task<IActionResult> ViewProduct(int ID)
        {
            var product = await productService.GetProductByID(ID);
            return View(product);
        }
    }
}
//TODO:
//Lägg till lite javascript
//CSS - design
