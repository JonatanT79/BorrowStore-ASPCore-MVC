using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using ProductAPI.Repository;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductRepository _repository = new ProductRepository();
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Products> ProductList = _repository.GetAllProducts();
            return Ok(ProductList);
        }
    }
}