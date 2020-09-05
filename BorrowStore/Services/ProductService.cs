﻿using BorrowStore.Models;
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
        public Uri BaseAdress { get; set; } = new Uri("http://localhost:30000");
        public async Task<List<Product>> GetAllProducts()
        {
            var Response = await _client.GetAsync(BaseAdress + "product");
            string ResponseString = await Response.Content.ReadAsStringAsync();
            List<Product> ProductList = JsonConvert.DeserializeObject<List<Product>>(ResponseString);

            return ProductList;
        }
    }
}