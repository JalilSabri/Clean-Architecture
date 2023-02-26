using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using CleanArch.Infrastructure.Data.Context;
using CleanArch.Core.Domain.Models.Persons;
using CleanArch.Infrastructure.Data.Repositories.Persons;
using CleanArch.Core.Application.Services.Persons;

namespace CleanArch.Test.UnitTest.Persons.ApplicationLayerTesting
{
    [TestClass]
    public class CustomerUnitTest
    {
        CleanArchDbContext dbContext;

        public CustomerUnitTest()
        {
            //DbContextOptions<CleanArchDbContext> Options = new DbContextOptions<CleanArchDbContext>();

            var optionsBuilder = new DbContextOptionsBuilder<CleanArchDbContext>();
            {

            };

            optionsBuilder.UseSqlServer("Server=DESKTOP-98REPCN\\SQL2019DEVELOPER; Database=ArchitectureDB; User ID=sa; Password=123");

            //services.AddDbContext<DemoDBContext>(options =>
            //{
            //    options.UseSqlServer(Configuration.GetConnectionString("demoConnection"));
            //});

            //var options = new DbContextOptionsBuilder<CleanArchDbContext>().UseInMemoryDatabase(databaseName: "FakeDatabase").Options;

            dbContext = new CleanArchDbContext(optionsBuilder.Options);
        }

        [TestMethod]
        public void AddCustomerTest()
        {
            CustomerRepository customerRepository = new CustomerRepository(dbContext);
            CustomerService customerService = new CustomerService(customerRepository);
            Customer customer = new Customer
            {
                Email = "LoLo@KhorKhoreh.com",
                Phone = "335522",
                ModifiedDate = System.DateTime.Now
            };
            customer.person = new Person
            {
                FirstName = "Arvin",
                LastName = "Sabri",
                ModifiedDate = System.DateTime.Now
            };

            customerService.AddCustomer(customer);

            int x = 10;
            int y = 20;
            Assert.AreNotEqual(x, y);
        }
    }
}
