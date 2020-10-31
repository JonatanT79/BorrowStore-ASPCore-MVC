using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Transactions;
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

        [HttpGet("User/{userId}")]
        public IActionResult GetAllUserOrders(string userId)
        {
            List<Order> UserOrderList = _OrderRepository.GetAllUserOrders(userId);
            return Ok(UserOrderList);
        }

        [HttpGet("{userId}/{active}")]
        public IActionResult GetAllActiveUserOrders(string userId, bool active)
        {
            List<Order> activeUserOrders = _OrderRepository.GetAllActiveUserOrders(userId, active);
            return Ok(activeUserOrders);
        }

        [HttpPut("Update")]
        public IActionResult HandInLoan([FromBody] Order order)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                _OrderRepository.HandInLoan(order);
                scope.Complete();
                return Ok();
            }
        }

        [HttpPost("Insert")]
        public IActionResult InsertOrder([FromBody] Order order)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                _OrderRepository.InsertOrder(order);
                scope.Complete();
                return CreatedAtAction(nameof(InsertOrder), new { OrderID = order.OrderID }, order);
            }
        }
    }
}
