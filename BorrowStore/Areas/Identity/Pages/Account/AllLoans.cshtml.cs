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
    public class AllLoansModel : PageModel
    {
        OrderService orderService = new OrderService();
        public List<Order> userOrderList = new List<Order>();

        public async Task OnGet()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            userOrderList = await orderService.GetAllUserOrders(userId);
        }
    }
}
