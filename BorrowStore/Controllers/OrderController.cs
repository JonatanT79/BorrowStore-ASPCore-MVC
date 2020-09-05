using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BorrowStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace BorrowStore.Controllers
{
    public class OrderController : Controller
    {
        ProductService _productservice = new ProductService();
        public async Task<IActionResult> ConfirmOrder(int ID)
        {
            var ProductList = await _productservice.GetAllProducts();

            var product = (from e in ProductList
                           where e.ID == ID
                           select e).SingleOrDefault();

            return View(product);
        }
        public IActionResult CompleteOrder()
        {
            return View();
        }
    }
}
