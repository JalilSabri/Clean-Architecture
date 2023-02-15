using CleanArch.Core.Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Contracts.IServices.Orders
{
    public interface IOrdersService
    {
        public IEnumerable<Order> GetAll();
        public Task<IEnumerable<Order>> GetAllAsync();
        public Order GetOrdersById(string id);
        public Task<Order> GetOrdersByIdAsync(string id);
        public IEnumerable<Order> GetOrderList(Expression<Func<Order, bool>> where = null);
        public IEnumerable<Order> GetOrderWithDetails();
        public void AddOrder(Order orders);
        public void UpdateOrder(Order order);
        public void DeleteOrder(Order order);
        public void DeleteOrderById(string id);
    }
}
