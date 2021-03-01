using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Domain.Models
{
    /**
     * This is the model class for an Order
     * An order can have an Id, Title, and Description
     * I am assuming there is only one customer per order
     * @author Emileo Xiao
     */
    public class Order
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
