using CleanArch.Core.Contracts.IRepositories.Persons;
using CleanArch.Core.Contracts.IServices.Persons;
using CleanArch.Core.Domain.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Application.Services.Persons
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerRepository.Delete(customer);
        }

        public void DeleteById(string id)
        {
            _customerRepository.DeleteById(id);
        }

        public IList<Customer> GetAll()
        {
            return _customerRepository.GetAll().ToList();
        }

        public Customer? GetById(string id)
        {
            return _customerRepository.GetById(id);
        }
    }
}
