using BorrowStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowStore.Services
{
    interface IOrderService
    {
        Task<List<Order>> GetAllOrders();
        Task InsertOrder(Order order);
    }
}
