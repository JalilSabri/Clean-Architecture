using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using CleanArch.Infrastructure.Data.Context;
using CleanArch.Core.Application.Services;
using CleanArch.Infrastructure.Data.Repositories;
using CleanArch.Core.Domain.Models.Order;

namespace CleanArch.Test.UnitTest.ApplicationLayerTesting
{
    [TestClass]
    public class OrdersUnitTest
    {
        CleanArchDbContext dbContext;

        public OrdersUnitTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CleanArchDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-98REPCN\\SQL2019DEVELOPER; Database=ArchitectureDB; User ID=sa; Password=123");
            dbContext = new CleanArchDbContext(optionsBuilder.Options);
        }

        [TestMethod]
        public void AddOrdersTest()
        {
            OrdersRepository ordersRepository = new OrdersRepository(dbContext);
            OrdersService ordersService = new OrdersService(ordersRepository);

            Orders orders = new Orders
            {
                CustomerId = "d1ea7e01-9e76-4e6c-8f6c-b23eddaa39ae",
                OrderDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                SalesPerId = "1",
                OrderStatusId = 2,
                orderItems = new System.Collections.Generic.List<OrderItems>()
            };
            orders.orderItems.Add(new OrderItems()
            {
                OrderId = orders.Id,
                ProductId = "1",
                Quantity = 14
            });
            orders.orderItems.Add(new OrderItems()
            {
                OrderId = orders.Id,
                ProductId = "2",
                Quantity = 14
            });
            ordersService.AddOrders(orders);
            Assert.Equals(2, 2);
        }
    }
}
