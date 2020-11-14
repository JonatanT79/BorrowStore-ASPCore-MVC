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
        OrderRepository orderRepository = new OrderRepository();

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            List<Order> orderList = orderRepository.GetAllOrders();
            return Ok(orderList);
        }

        [HttpGet("User/{userId}")]
        public IActionResult GetAllUserOrders(string userId)
        {
            List<Order> userOrderList = orderRepository.GetAllUserOrders(userId);
            return Ok(userOrderList);
        }

        [HttpGet("{userId}/{active}")]
        public IActionResult GetAllActiveUserOrders(string userId, bool active)
        {
            List<Order> activeUserOrders = orderRepository.GetAllActiveUserOrders(userId, active);
            return Ok(activeUserOrders);
        }

        [HttpPut("Update")]
        public IActionResult HandInLoan([FromBody] Order order)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                orderRepository.HandInLoan(order);
                scope.Complete();
                return Ok();
            }
        }

        [HttpPost("Insert")]
        public IActionResult InsertOrder([FromBody] Order order)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                orderRepository.InsertOrder(order);
                scope.Complete();
                return CreatedAtAction(nameof(InsertOrder), new { OrderID = order.OrderID }, order);
            }
        }
    }
}
