using CleanArch.Core.Contracts.IRepositories.Orders;
using CleanArch.Core.Domain.Models.Orders;
using CleanArch.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Data.Repositories.Orders
{
    public class OrderRepository : IOrderRepository
    {
        CleanArchDbContext dbContext;

        public OrderRepository(CleanArchDbContext cleanArchDbContext)
        {
            dbContext = cleanArchDbContext;
        }

        public void Add(Order order)
        {
            dbContext.Add(order);
            dbContext.SaveChanges();
        }

        public void Delete(Order order)
        {
            DbSet<Order> dbSet = dbContext.Set<Order>();
            if (dbContext.Entry<Order>(order).State == EntityState.Detached)
                dbSet.Attach(order);
            dbSet.Remove(order);
            dbContext.SaveChanges();
        }

        public void DeleteById(string id)
        {
            var order = dbContext.orders.Include(o => o.orderItems).Where(o => o.Id == id).First();
            dbContext.Remove(order);
            dbContext.SaveChanges();

            //Orders order = GetById(id);
            //Delete(GetById(id));
        }

        public IEnumerable<Order> GetAll()
        {
            return dbContext.orders.ToList();
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await Task.Run(() =>
             {
                 return dbContext.orders.ToList();
             });
            //Task<int> task = new Task<int>(GetCharacterCount);
            //task.Start();
            //return await task;
            //return Task.Run(dbContext.orders.ToList());
        }

        public Order GetById(string id)
        {
            return dbContext.orders.FirstOrDefault(o => o.Id == id.ToString()) ?? new Order();
        }

        public async Task<Order> GetByIdAsync(string id)
        {
            Task<Order> result = new Task<Order>(() => { return dbContext.orders.FirstOrDefault(o => o.Id == id.ToString()); });
            result.Start();
            return await result;
        }

        public IEnumerable<Order> GetList(Expression<Func<Order, bool>> where = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetListComplete()
        {
            return dbContext.orders.Include(o => o.orderItems).Include(c => c.customer).ToList();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
