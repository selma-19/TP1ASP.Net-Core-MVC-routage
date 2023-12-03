using Microsoft.AspNetCore.Mvc;
using tp1.Models;

namespace tp1.Controllers
{
    public class CustomerController : Controller
    {
        [Route("/customers")]

        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer{Id=1,Name="Test customer"},
                new Customer{Id=1,Name="Test customer"},
                new Customer{Id=2,Name="Test customer"}
            };
            return View(customers);
            
        }


        [Route("customer/{id}")]

        public IActionResult Details(int? id)
        {
            if (id == null)
                return Content("id not found");
            var testDetails = getAllCustomers().
                FirstOrDefault(x => x.Id == id);
            return View(testDetails);
        }

        private IEnumerable<Customer> getAllCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "TEST" },
                 new Customer { Id = 2, Name = "TEST2" },
                 new  Customer{ Id = 3, Name = "TEST3" }
            };
            return customers;
        }
    }
}
