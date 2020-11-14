using BorrowStore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BorrowStore.Services
{
    public class OrderService : IOrderService
    {
        HttpClient client = new HttpClient();
        Uri baseAddress = new Uri("http://localhost:30000");
        public async Task<List<Order>> GetAllOrders()
        {
            var response = await client.GetStringAsync(baseAddress + "Order");
            var orderList = JsonConvert.DeserializeObject<List<Order>>(response);
            return orderList;
        }
        public async Task<List<Order>> GetAllUserOrders(string userId)
        {
            var response = await client.GetStringAsync(baseAddress + "Order/User/" + userId);
            var userOrderList = JsonConvert.DeserializeObject<List<Order>>(response);
            return userOrderList;
        }
        public async Task<List<Order>> GetAllActiveUserOrders(string userId, bool active)
        {
            var response = await client.GetStringAsync(baseAddress + "Order/" + userId + "/" + active);
            var activeUserOrders = JsonConvert.DeserializeObject<List<Order>>(response);
            return activeUserOrders;
        }
        public async Task HandInLoan(Order order)
        {
            string json = JsonConvert.SerializeObject(order);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            await client.PutAsync(baseAddress + "Order/Update", content);
        }
        public async Task InsertOrder(Order order)
        {
            string json = JsonConvert.SerializeObject(order);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            await client.PostAsync(baseAddress + "Order/Insert", content);
        }
    }
}
