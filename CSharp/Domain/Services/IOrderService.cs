using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Domain.Models;

namespace CSharp.Domain.Services
{
    interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrders();

    }
}
