using CSharp.Domain.Models;
using CSharp.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Controllers
{
    [Route("/api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrderService orderService;

        public OrdersController(IOrderService oService)
        {
            orderService = oService;
        }

        [Route("customerid/{id}")]
        [HttpGet]
        public async Task<IEnumerable<Order>> GetAllOrdersByCustomerIdAsync(int id)
        {
            var orders = await orderService.GetAllOrdersByCustomerId(id);
            return orders;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] SaveOrderResource resource)
        {

        }
    }
}
