﻿using System;
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
        [HttpPost]
        public async Task<IActionResult> InsertConfirmedOrder(string ProductName, string UserID)
        {
            await _orderService.InsertOrder(ProductName, UserID);
            return RedirectToAction("CompleteOrder", "Order");
        }
    }
}
