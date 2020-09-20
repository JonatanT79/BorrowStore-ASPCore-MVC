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
        void InsertOrder(string Product, string UserID);
    }
}
