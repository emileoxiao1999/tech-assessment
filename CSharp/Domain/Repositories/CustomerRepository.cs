using CSharp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSharp.Domain.Models;
using CSharp.Domain.Repositories;

namespace CSharp.Domain.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(CSharpDbContext context) : base(context) { }


        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await context.Customers.ToListAsync();
        }
    }
}
