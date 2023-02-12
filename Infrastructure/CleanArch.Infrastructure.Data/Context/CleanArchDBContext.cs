using CleanArch.Core.Domain.Models.Order;
using CleanArch.Core.Domain.Models.Persons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Data.Context
{
    public class CleanArchDBContext : DbContext
    {
        public CleanArchDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> persons { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<SalesPerson> salesPerson { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<OrderItems> orderItems { get; set; }
        public DbSet<OrderStatus> orderStatuses { get; set; }
    }
}
