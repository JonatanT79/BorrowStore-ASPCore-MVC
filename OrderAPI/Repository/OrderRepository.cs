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
        OrderContext orderContext = new OrderContext();

        public List<Order> GetAllOrders()
        {
            List<Order> orderList = orderContext.Order.ToList();
            return orderList;
        }
        public List<Order> GetAllUserOrders(string userId)
        {
            List<Order> userOrderList = orderContext.Order.Where(e => e.UserID == userId).ToList();
            return userOrderList;
        }
        public List<Order> GetAllActiveUserOrders(string userId, bool active)
        {
            List<Order> activeUserOrders = orderContext.Order.Where(e => e.UserID == userId && e.IsActive == active).ToList();
            return activeUserOrders;
        }
        public void HandInLoan(Order order)
        {
            Order orderToUpdate = orderContext.Order.Where(o => o.OrderID == order.OrderID).SingleOrDefault();
            orderToUpdate.IsActive = order.IsActive;
            orderToUpdate.HandedIn = order.HandedIn;
            orderToUpdate.Late = order.Late;
            orderToUpdate.DaysLate = order.DaysLate;
            orderContext.SaveChanges();
        }
        public void InsertOrder(Order order)
        {
            orderContext.Order.Add(order);
            orderContext.SaveChanges();
        }
    }
}
