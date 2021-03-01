using CSharp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Domain.Repositories
{
    public class OrderRepository : BaseRepository , IOrderRepository
    {
        public OrderRepository(CSharpDbContext context) : base(context) { }


        public async Task<IEnumerable<Order>> GetAllOrdersByCustomerId(int id)
        {
                return  context.Orders.Where(o => o.CustomerId == id);
        }
    }
}
