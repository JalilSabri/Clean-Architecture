using CleanArch.Core.Domain.Models.Orders;
using CleanArch.Core.Domain.Models.Persons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Data.Context
{
    public class CleanArchDbContext : DbContext
    {
        public CleanArchDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> persons { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<SalesPerson> salesPerson { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItems> orderItems { get; set; }
        public DbSet<OrderStatus> orderStatuses { get; set; }
    }
}
