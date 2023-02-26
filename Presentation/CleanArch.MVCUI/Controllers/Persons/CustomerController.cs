using CleanArch.Core.Contracts.IServices.Persons;
using CleanArch.Core.Domain.Models.Persons;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.MVCUI.Controllers.Persons
{
    public class CustomerController : Controller
    {
        string ViewsPath = "Views/Persons/";
        ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public IActionResult Index()
        {
            List<Customer> lstCustomers = customerService.GetAll().ToList();
            return View(ViewsPath + "Index.cshtml", lstCustomers);
        }

        public IActionResult Create()
        {
            return View(ViewsPath + "Create.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (true)//ModelState.IsValid)
            {
                customerService.AddCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("LastName", "Please enter ");
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(string Id)
        {
            Customer customer = customerService.GetById(Id);
            return View(ViewsPath + "Edit.cshtml", customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            return View();
        }

        public IActionResult Delete(string Id)
        {
            Customer? customer = customerService.GetById(Id);
            customerService.Delete(customer);
            return RedirectToAction(nameof(Index));
        }

    }
}
