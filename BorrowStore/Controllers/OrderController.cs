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
        ProductService productService = new ProductService();
        OrderService orderService = new OrderService();

        [HttpGet]
        public async Task<IActionResult> ConfirmOrder(int ID)
        {
            var product = await productService.GetProductByID(ID);
            return View(product);
        }
        public IActionResult CompleteOrder()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            List<Order> orderList = await orderService.GetAllOrders();
            return View(orderList);
        }
        [HttpPost]
        public async Task<IActionResult> InsertConfirmedOrder(string ProductName, DateTime borrowDate, DateTime dateToHandIn)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Order order = new Order { BorrowDate = borrowDate, Product = ProductName, IsActive = true, UserID = userId, DateToHandIn = dateToHandIn };
            await orderService.InsertOrder(order);
            return RedirectToAction("CompleteOrder", "Order");
        }
    }
}
