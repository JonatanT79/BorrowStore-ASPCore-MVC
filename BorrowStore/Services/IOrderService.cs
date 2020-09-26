using BorrowStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowStore.Services
{
    interface IOrderService
    {
        Order GetAllUserOrders();
        Task InsertOrder(Order order);
    }
}
