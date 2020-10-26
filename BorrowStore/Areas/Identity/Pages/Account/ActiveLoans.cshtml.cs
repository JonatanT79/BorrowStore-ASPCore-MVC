using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BorrowStore.Models;
using BorrowStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BorrowStore.Areas.Identity.Pages.Account.Loans
{
    public class ActiveLoansModel : PageModel
    {
        OrderService _orderService = new OrderService();
        public List<Order> activeUserOrderList = new List<Order>();

        public async Task OnGet()
        {
            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            activeUserOrderList = await _orderService.GetAllActiveUserOrders(userID, true);
        }
    }
}
