using CSharp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Controllers;

namespace CSharp.Domain.Repositories
{
    public class OrderRepository : BaseRepository , IOrderRepository
    {
        public OrderRepository(CSharpDbContext context) : base(context) { }


        public async Task<IEnumerable<Order>> GetAllOrdersByCustomerId(int id)
        {
                return  context.Orders.Where(o => o.CustomerId == id);
        }

        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            await context.Orders.AddAsync(order);
            await context.SaveChangesAsync();
            //return new CreatedAtActionResult(nameof(GetOrderById), nameof(OrdersController), new { id = order.Id }, order);
            return order;
        }

        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            var order = await context.Orders.FindAsync(id);
            if (order == null)
                return new NotFoundObjectResult(id);
            return order;
        }
    }
}
