using CleanArch.Core.Contracts.IRepositories.Persons;
using CleanArch.Core.Domain.Models.Persons;
using CleanArch.Infrastructure.Data.Context;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

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
            DbSet<Customer> dbSet = dbContext.Set<Customer>();
            if (dbContext.Entry<Customer>(customer).State == EntityState.Detached)
                dbSet.Attach(customer);
            dbSet.Remove(customer);
            dbContext.SaveChanges();
        }

        public void DeleteById(string id)
        {
            var customer = dbContext.customers.Include(c => c.person).Where(c => c.Id == id).First();
            dbContext.Remove(customer);
            dbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetAll()
        {
            return dbContext.customers.Include(c => c.person).ToList();
        }

        public Customer? GetById(string id)
        {
            //return dbContext.customers.Find(id);
            return dbContext.customers.Include(c => c.person).FirstOrDefault(c => c.Id == id);
        }

        //public Task<Customer> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<Customer> GetByIdAsync(string id)
        {
            Customer customer = await dbContext.customers.FindAsync(id.ToString()) ?? new Customer() { Id = "0" };
            return customer;
            //Task.Run(() =>
            //{
            //    return dbContext.customers.FindAsync(id.ToString());
            //});
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
