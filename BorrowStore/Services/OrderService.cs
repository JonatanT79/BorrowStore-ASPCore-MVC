using BorrowStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BorrowStore.Services
{
    public class OrderService : IOrderService
    {
        HttpClient client = new HttpClient();
        Uri BaseAddress = new Uri("http://localhost:30000");
        public Order GetAllUserOrders() 
        {
            //var response = client.GetStringAsync(BaseAddress);

            Order order = new Order();
            return order;
        }
        public async Task InsertOrder(string ProductName, string UserID)
        {
           //await client.PostAsync(BaseAddress + "Insert", ProductName);
        }
    }
}
