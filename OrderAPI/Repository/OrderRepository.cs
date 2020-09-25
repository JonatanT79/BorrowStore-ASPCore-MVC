using OrderAPI.Data;
using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Repository
{
    public class OrderRepository : IOrderRepository
    {
        OrderContext _orderContext = new OrderContext();

        public List<Order> GetAllOrders()
        {
            List<Order> OrderList = _orderContext.Order.ToList();
            return OrderList;
        }

        public void InsertOrder(string ProductName, string UserID)
        {
            Order _order = new Order()
            {
                BorrowDate = DateTime.Now,
                Product = ProductName,
                UserID = UserID
            };
            _orderContext.Order.Add(_order);
            _orderContext.SaveChanges();
        }
    }
}
