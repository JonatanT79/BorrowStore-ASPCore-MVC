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

        [HttpGet]
        public async Task<IActionResult> ConfirmOrder(int ID)
        {
            var product = await _productservice.GetProductByID(ID);

            return View(product);
        }
        public IActionResult CompleteOrder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertConfirmedOrder(DateTime BorrowDate, string Product, string UserID)
        {
            int i = 1;
            return RedirectToAction("CompleteOrder", "Order");
        }
    }
}
