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
        HttpClient _client = new HttpClient();
        Uri BaseAdress = new Uri("http://localhost:30000");
        public async Task<List<Product>> GetAllProducts()
        {
            var Response = await _client.GetAsync(BaseAdress + "product");
            string ResponseString = await Response.Content.ReadAsStringAsync();
            List<Product> ProductList = JsonConvert.DeserializeObject<List<Product>>(ResponseString);

            return ProductList;
        }
        public async Task<Product> GetProductByID(int ID)
        {
            var Response = await _client.GetAsync(BaseAdress + "product/" + ID);
            string ResponseString = await Response.Content.ReadAsStringAsync();
            Product product = JsonConvert.DeserializeObject<Product>(ResponseString);

            return product;
        }
    }
}
