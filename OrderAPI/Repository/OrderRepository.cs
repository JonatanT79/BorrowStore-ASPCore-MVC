﻿using OrderAPI.Data;
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
        public List<Order> GetAllUserOrders(string userId)
        {
            List<Order> userOrderList = _orderContext.Order.Where(e => e.UserID == userId).ToList();
            return userOrderList;
        }
        public List<Order> GetAllActiveUserOrders(string userId, bool active)
        {
            List<Order> activeUserOrders = _orderContext.Order.Where(e => e.UserID == userId && e.IsActive == active).ToList();
            return activeUserOrders;
        }
        public void HandInLoan(Order order)
        {
            Order orderToUpdate = _orderContext.Order.Where(o => o.OrderID == order.OrderID).SingleOrDefault();
            orderToUpdate.IsActive = order.IsActive;
            orderToUpdate.HandedIn = order.HandedIn;
            orderToUpdate.Late = order.Late;
            orderToUpdate.DaysLate = order.DaysLate;
            _orderContext.SaveChanges();
        }
        public void InsertOrder(Order order)
        {
            _orderContext.Order.Add(order);
            _orderContext.SaveChanges();
        }
    }
}
