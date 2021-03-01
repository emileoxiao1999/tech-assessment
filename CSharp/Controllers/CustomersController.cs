using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Domain.Models;
using CSharp.Domain.Services;

namespace CSharp.Controllers
{
    [Route("/api/[controller]")]
    public class CustomersController : Controller
    {

        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService cService)
        {
            customerService = cService;
        }

        [HttpGet]
        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            var customers = await customerService.GetCustomers();
            return customers;
        }
    }
}
