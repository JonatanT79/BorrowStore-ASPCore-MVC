using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Order> OrderList = new List<Order>();
        public string  StatusMessage { get; set; }

        public async Task OnGet()
        {
            OrderList = await orderService.GetAllOrders();
        }
    }
}
