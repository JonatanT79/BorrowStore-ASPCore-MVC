using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BorrowStore.Models;
using BorrowStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace BorrowStore.Controllers
{
    public class LoanController : Controller
    {
        OrderService orderService = new OrderService();
        public async Task<IActionResult> HandInLoan(int orderId, DateTime borrowDate, DateTime dateToHandIn, string product)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Order order = new Order
            {
                OrderID = orderId,
                BorrowDate = borrowDate,
                Product = product,
                IsActive = false,
                HandedIn = DateTime.Now,
                UserID = userId,
            };

            if (order.HandedIn > dateToHandIn)
            {
                order.Late = true;
                order.DaysLate = (order.HandedIn.Value - dateToHandIn).Days;
            }

            await orderService.HandInLoan(order);
            return RedirectToPage("/Account/ActiveLoans", new { area = "Identity" });
        }
    }
}
