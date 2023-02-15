using CleanArch.Core.Domain.Models.Persons;

namespace CleanArch.Core.Contracts.IServices.Persons
{
    public interface ICustomerService
    {
        public void AddCustomerService(Customer customer);
    }
}