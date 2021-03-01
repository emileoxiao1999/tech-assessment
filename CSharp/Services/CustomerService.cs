using CSharp.Domain.Models;
using CSharp.Domain.Repositories;
using CSharp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository cRepository)
        {
            customerRepository = cRepository;
        }

        public Task<IEnumerable<Order>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
