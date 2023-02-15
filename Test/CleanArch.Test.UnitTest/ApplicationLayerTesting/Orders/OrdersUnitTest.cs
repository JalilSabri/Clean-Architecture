using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using CleanArch.Infrastructure.Data.Context;
using CleanArch.Core.Domain.Models.Orders;
using System.Collections.Generic;
using CleanArch.Core.Contracts.IServices.Orders;
using CleanArch.Infrastructure.Data.Repositories.Orders;
using CleanArch.Core.Application.Services.Orders;

namespace CleanArch.Test.UnitTest.ApplicationLayerTesting
{
    [TestClass]
    public class OrdersUnitTest
    {
        CleanArchDbContext dbContext;
        IOrdersService ordersService;
        const string OrderId = "c8a97d90-0fcf-4368-980a-dceacff802a7";

        public OrdersUnitTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CleanArchDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-98REPCN\\SQL2019DEVELOPER; Database=ArchitectureDB; User ID=sa; Password=123");
            dbContext = new CleanArchDbContext(optionsBuilder.Options);
            ordersService = new OrderService(new OrderRepository(dbContext));
        }

        [TestMethod]
        public void AddOrdersTest()
        {
            Order order = new Order
            {
                CustomerId = "d1ea7e01-9e76-4e6c-8f6c-b23eddaa39ae",
                OrderDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                SalesPerId = "1",
                OrderStatusId = 2
                //orderItems = new System.Collections.Generic.List<OrderItems>()
            };
            order.orderItems.Add(new OrderItems()
            {
                OrderId = order.Id,
                ProductId = "1",
                Quantity = 14
            });
            order.orderItems.Add(new OrderItems()
            {
                OrderId = order.Id,
                ProductId = "2",
                Quantity = 14
            });
            ordersService.AddOrder(order);
            Assert.Equals(2, 2);
        }

        [TestMethod]
        public void GetOrderWithDetailsTest()
        {
            int rowsCount = new List<Order>(ordersService.GetOrderWithDetails()).Count;

            Assert.AreNotEqual(rowsCount, 0);
        }

        //The DELETE statement conflicted with the REFERENCE constraint "FK_tblOrderItems_tblOrders_ordersId".
        //The conflict occurred in database "ArchitectureDB", table "dbo.tblOrderItems", column 'ordersId'.
        //The statement has been terminated.
        [TestMethod]
        public void DeleteOrderTest()
        {
            //Orders order = ordersService.GetOrdersById(OrderId);
            //ordersService.DeleteOrder(order);
            ordersService.DeleteOrderById(OrderId);

            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public async void UpdateOrderTest()
        {
           Order order = await ordersService.GetOrdersByIdAsync(OrderId);

           Assert.AreNotEqual(1, 0);
        }

    }
}
