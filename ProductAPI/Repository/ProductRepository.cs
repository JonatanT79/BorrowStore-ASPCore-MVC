﻿using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data;
using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        ProductsContext context = new ProductsContext();
        public List<Products> GetAllProducts()
        {
            List<Products> productsList = context.Products.ToList();
            return productsList;
        }
        public List<Products> GetAllSearchedProducts(string searchString)
        {
            List<Products> searchedProductsList = context.Products.Where(p => p.Name.Contains(searchString)).ToList();
            return searchedProductsList;
        }
        public Products GetProductByID(int ID)
        {
            Products product = context.Products.Where(p => p.ID == ID).SingleOrDefault();
            return product;
        }
    }
}
