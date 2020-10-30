using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BorrowStore.Controllers
{
    public class Loan : Controller
    {
        public IActionResult HandInLoan(int orderId)
        {
            //TODO: change path to activeloans
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
    }
}
