using CleanArch.Core.Domain.Models.Persons;

namespace CleanArch.Core.Contracts.IServices.Persons
{
    public interface ICustomerService
    {
        public void AddCustomer(Customer customer);
        public IList<Customer> GetAll();
        public Customer? GetById(string id);
        public void DeleteById(string id);
        public void Delete(Customer customer);
    }
}