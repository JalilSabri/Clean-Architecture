using CleanArch.Core.Contracts.IRepositories.Orders;
using CleanArch.Core.Contracts.IServices.Orders;
using CleanArch.Core.Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Application.Services.Orders
{
    public class OrderService : IOrdersService
    {
        IOrderRepository _ordersRepository;
        public OrderService(IOrderRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public void AddOrder(Order order)
        {
            _ordersRepository.Add(order);
        }

        public void DeleteOrder(Order order)
        {
            _ordersRepository.Delete(order);
        }

        public void DeleteOrderById(string id)
        {
            _ordersRepository.DeleteById(id);
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrderList(Expression<Func<Order, bool>> where = null)
        {
            throw new NotImplementedException();
        }

        public Order GetOrdersById(string id)
        {
            return _ordersRepository.GetById(id);
        }

        public Task<Order> GetOrdersByIdAsync(string id)
        {
            return _ordersRepository.GetByIdAsync(id);
        }

        public IEnumerable<Order> GetOrderWithDetails()
        {
           return _ordersRepository.GetListComplete();
        }

        public void UpdateOrder(Order orders)
        {
            throw new NotImplementedException();
        }
    }
}
