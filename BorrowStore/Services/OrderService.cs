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
        Uri BaseAddress = new Uri("http://localhost:30000");
        public Order GetAllUserOrders()
        {
            //var response = client.GetStringAsync(BaseAddress);

            Order order = new Order();
            return order;
        }
        public async Task InsertOrder(Order order)
        {
            string json = JsonConvert.SerializeObject(order);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            await client.PostAsync(BaseAddress + " Order/Insert", content);
        }
    }
}
