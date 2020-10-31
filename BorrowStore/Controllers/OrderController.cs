using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BorrowStore.Models;
using BorrowStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace BorrowStore.Controllers
{
    public class OrderController : Controller
    {
        ProductService _productservice = new ProductService();
        OrderService _orderService = new OrderService();

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
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            List<Order> OrderList = await _orderService.GetAllOrders();
            return View(OrderList);
        }
        [HttpPost]
        public async Task<IActionResult> InsertConfirmedOrder(string ProductName)
        {
            string UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Order order = new Order { BorrowDate = DateTime.Now, Product = ProductName, IsActive = true, UserID = UserID };
            await _orderService.InsertOrder(order);
            return RedirectToAction("CompleteOrder", "Order");
        }
    }
}
