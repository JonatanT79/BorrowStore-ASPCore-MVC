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
        Task<List<Order>> GetAllUserOrders(string userId);
        Task<List<Order>> GetAllActiveUserOrders(string userId, bool active);
        Task HandInLoan(Order order);
        Task InsertOrder(Order order);
    }
}
