using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Domain.Models;

namespace CSharp.Domain.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomers();

        Task<IEnumerable<Order>> GetAllOrders();
    }
}
