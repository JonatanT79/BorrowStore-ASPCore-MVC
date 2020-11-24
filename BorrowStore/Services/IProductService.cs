using BorrowStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowStore.Services
{
    interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetAllSearchedProducts(string searchString);
        Task<Product> GetProductByID(int ID); 
    }
}
