using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Domain.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrdersByCustomerId(int id);

        Task<ActionResult<Order>> CreateOrder(Order order);

        Task<ActionResult<Order>> GetOrderById(int id);

    }
}
