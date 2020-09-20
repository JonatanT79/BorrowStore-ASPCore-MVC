using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using ProductAPI.Repository;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        ProductRepository _productRepository = new ProductRepository();
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Products> ProductList = _productRepository.GetAllProducts();
            return Ok(ProductList);
        }

        [HttpGet("{ID}")]
        public IActionResult GetProductByID(int ID)
        {
            Products products = _productRepository.GetProductByID(ID);
            return Ok(products);
        }
    }
}