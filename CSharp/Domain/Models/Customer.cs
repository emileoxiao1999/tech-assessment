using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Domain.Models
{
    /**
     * This is the model class for customer
     * A customer has an id, first name, last name, and phone number
     * I am assuming that a customer can have multiple orders
     * @author Emileo Xiao
     */
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //address, will add if I have time

        public string phoneNumber { get; set; }

        public IList<Order> Orders { get; set; } = new List<Order>();
    }
}
