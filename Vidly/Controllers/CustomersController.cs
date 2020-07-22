using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer
                {
                Id = 1,
                Name = "John Smith"
                },
                new Customer
                {
                    Id = 2,
                    Name = "Mary Williams"
                }
        };
        
        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new CustomersViewModel
            {
                Customers = this.customers
            };
            return View(viewModel);
        }

        //customers/details/{id}
        public ActionResult Details(int id)
        {
            var currentCustomer = this.customers.FirstOrDefault(p => p.Id == id);
            if (currentCustomer != null)
                return View(currentCustomer);
            return HttpNotFound();
        }
    }
}