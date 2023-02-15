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

        public void AddCustomerService(Customer customer)
        {
            _customerRepository.Add(customer);
        }
    }
}
