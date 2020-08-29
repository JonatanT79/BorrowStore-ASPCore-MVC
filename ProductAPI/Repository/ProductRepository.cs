using Microsoft.AspNetCore.Mvc;
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
        ProductsContext _context = new ProductsContext();
        public List<Products> GetAllProducts()
        {
            List<Products> ProductsList = _context.Products.ToList();
            return ProductsList;
        }
        public Products GetProductByID(int ID)
        {
            Products product = _context.Products.Where(p => p.ID == ID).SingleOrDefault();
            return product;
        }
    }
}
