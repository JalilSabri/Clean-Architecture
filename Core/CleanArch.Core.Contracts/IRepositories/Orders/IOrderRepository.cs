using CleanArch.Core.Domain.Models.Orders;
using System.Linq.Expressions;

namespace CleanArch.Core.Contracts.IRepositories.Orders
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetAll();
        public Task<IEnumerable<Order>> GetAllAsync();
        public Order GetById(string id);
        public Task<Order> GetByIdAsync(string id);
        public IEnumerable<Order> GetList(Expression<Func<Order, bool>> where = null);
        public IEnumerable<Order> GetListComplete();
        public void Add(Order order);
        public void Update(Order order);
        public void Delete(Order order);
        public void DeleteById(string id);
    }
}