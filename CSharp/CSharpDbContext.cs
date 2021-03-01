using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharp
{
    public class CSharpDbContext : DbContext
    {

        DbSet<Order> Orders { get; set; }
        DbSet<Customer> Customers { get; set; }

        public CSharpDbContext(DbContextOptions<CSharpDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>().ToTable("Orders");
            builder.Entity<Order>().HasKey(p => p.Id);
            builder.Entity<Order>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Order>().Property(p => p.Title).IsRequired().HasMaxLength(35);
            builder.Entity<Order>().Property(p => p.Description).IsRequired().HasMaxLength(200);

            builder.Entity<Customer>().ToTable("Customers");
            builder.Entity<Customer>().HasKey(p => p.Id);
            builder.Entity<Customer>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Customer>().Property(p => p.FirstName).IsRequired().HasMaxLength(35);
            builder.Entity<Customer>().Property(p => p.LastName).IsRequired().HasMaxLength(35);
            builder.Entity<Customer>().Property(p => p.phoneNumber).IsRequired().HasMaxLength(10);
            builder.Entity<Customer>().HasMany(p => p.Orders).WithOne(p => p.Customer).HasForeignKey(p => p.CustomerId);

            builder.Entity<Customer>().HasData
                (
                    new Customer { Id = 101, FirstName = "Leo", LastName = "Xiao", phoneNumber = "3198997240" },
                    new Customer { Id = 102, FirstName = "Jack", LastName = "Daniel", phoneNumber = "5156728898" },
                    new Customer { Id = 103, FirstName = "Sam", LastName = "Smith", phoneNumber = "7675548328" },
                    new Customer { Id = 104, FirstName = "David", LastName = "Cao", phoneNumber = "2328786453" },
                    new Customer { Id = 105, FirstName = "Brian", LastName = "Tran", phoneNumber = "6768223450" }
                ) ;

            builder.Entity<Order>().HasData
                (
                    new Order { Id = 201, Title = "Milk Buy", Description = "buying milk for family", CustomerId = 102},
                    new Order { Id = 202, Title = "Amazon Purchase", Description = "purchased a new pillow from amazon", CustomerId = 102 },
                    new Order { Id = 203, Title = "Pizza", Description = "order pizza from Domino's", CustomerId = 102 },
                    new Order { Id = 204, Title = "Groceries", Description = "bought 2 weeks of groceries", CustomerId = 104 },
                    new Order { Id = 205, Title = "Toilet Paper", Description = "bought a big pack of toilet paper for the month", CustomerId = 103 },
                    new Order { Id = 206, Title = "Clothes", Description = "bought a new shirt and shorts for spring", CustomerId = 102 },
                    new Order { Id = 207, Title = "Candy", Description = "Reeces and Twix are the best", CustomerId = 101 }
                );


        }
    }
}
