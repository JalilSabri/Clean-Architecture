using CleanArch.Core.Contracts.IServices.Persons;
using CleanArch.Core.Domain.Models.Persons;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controller
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CustomerController : ControllerBase
    {
        ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        //public IActionResult Get()
        //{
        //    return Ok(customerService.GetAll());
        //}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(customerService.GetAll());
        }

        [HttpGet("GetById")]
        public JsonResult GetById(string Id)
        {
            return new JsonResult(customerService.GetById(Id));
        }

        [HttpGet("{GetByIdFromRoute,Id}")]
        public JsonResult GetByIdFromRoute([FromRoute] string Id)
        {
            //string Id = "c61ca16c-01e9-4fbc-918c-172d418e49f9";
            return new JsonResult(customerService.GetById(Id));
        }

        public IActionResult Post(Customer customer)
        {
            var custv = customer;
            //Customer customer = new Customer
            //{
            //    Email = "LoLo@KhorKhoreh.com",
            //    Phone = "335522",
            //    ModifiedDate = System.DateTime.Now
            //};
            //customer.person = new Person
            //{
            //    FirstName = "Arvin",
            //    LastName = "Sabri",
            //    ModifiedDate = System.DateTime.Now
            //};
            //customerService.AddCustomer(cust);
            return Ok();
        }
    }

    public class Cust
    {
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? ModifiedDate { get; set; }
    }
}
