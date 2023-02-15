using CleanArch.Core.Contracts.IRepositories.Persons;
using CleanArch.Core.Domain.Models.Persons;
using CleanArch.Infrastructure.Data.Context;
using System.Linq.Expressions;

namespace CleanArch.Infrastructure.Data.Repositories.Persons
{
    public class CustomerRepository : ICustomerRepository
    {
        CleanArchDbContext dbContext;

        public CustomerRepository(CleanArchDbContext cleanArchDbContext)
        {
            dbContext = cleanArchDbContext;
        }

        public void Add(Customer customer)
        {
            dbContext.Add(customer);
            dbContext.SaveChanges();
        }

        //Utilities / Shared / Common , ... for Logging, Custom Exception Class, Method Chainig and Extension Method
        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetList(Expression<Func<Customer, bool>> where = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
