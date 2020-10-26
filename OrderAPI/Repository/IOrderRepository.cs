using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Repository
{
    interface IOrderRepository
    {
        List<Order> GetAllOrders();
        List<Order> GetAllUserOrders(string userId);
        List<Order> GetAllActiveUserOrders(string userId, bool active);
        void InsertOrder(Order order);
    }
}
