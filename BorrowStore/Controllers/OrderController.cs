using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BorrowStore.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult ConfirmOrder(int ID)
        {
            var product = (from e in TestData.ProductList()
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
