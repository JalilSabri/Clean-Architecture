using CleanArch.Core.Domain.Models.Persons;
using System.Linq.Expressions;

namespace CleanArch.Core.Contracts.IRepositories.Persons
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAll();
        public Customer? GetById(string id);
        public Task<Customer> GetByIdAsync(string id);
        public IEnumerable<Customer> GetList(Expression<Func<Customer, bool>> where = null);
        public void Add(Customer customer);
        public void Update(Customer customer);
        public void Delete(Customer customer);
        public void DeleteById(string id);
    }
}