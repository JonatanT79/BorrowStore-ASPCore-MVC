using BorrowStore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BorrowStore.Services
{
    public class ProductService : IProductService
    {
        HttpClient client = new HttpClient();
        Uri baseAdress = new Uri("http://localhost:30000");
        public async Task<List<Product>> GetAllProducts()
        {
            var response = await client.GetAsync(baseAdress + "product");
            string responseString = await response.Content.ReadAsStringAsync();
            List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(responseString);

            return productList;
        }
        public async Task<Product> GetProductByID(int ID)
        {
            var response = await client.GetAsync(baseAdress + "product/" + ID);
            string responseString = await response.Content.ReadAsStringAsync();
            Product product = JsonConvert.DeserializeObject<Product>(responseString);

            return product;
        }
    }
}
