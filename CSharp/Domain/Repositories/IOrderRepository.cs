using CSharp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllOrdersByCustomerId(int id);

        Task<ActionResult<Order>> CreateOrder(Order order);

        Task<ActionResult<Order>> GetOrderById(int id);

    }
}
