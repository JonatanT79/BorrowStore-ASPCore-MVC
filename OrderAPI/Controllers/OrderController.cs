using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderAPI.Models;
using OrderAPI.Repository;

namespace OrderAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        OrderRepository _OrderRepository = new OrderRepository();
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            List<Order> OrderList = _OrderRepository.GetAllOrders();
            return Ok(OrderList);
        }
        [HttpPost("Insert")]
        public IActionResult InsertOrder()
        {
            return Ok();
        }
    }
}
