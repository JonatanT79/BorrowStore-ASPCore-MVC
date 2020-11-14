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
        ProductRepository productRepository = new ProductRepository();

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Products> productList = productRepository.GetAllProducts();
            return Ok(productList);
        }

        [HttpGet("{ID}")]
        public IActionResult GetProductByID(int ID)
        {
            Products products = productRepository.GetProductByID(ID);
            return Ok(products);
        }
    }
}