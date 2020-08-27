using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetProducts()
        {
            string[] arr = new string[] { "1", "2", "3" };
            return Ok(arr);
        }
    }
}