using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CostumerController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCostumer();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCostumer().SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
               return HttpNotFound();
                
            }
            return View(customer);
        }

        private IEnumerable<Costumer> GetCostumer()
        {
            return new List<Costumer>
            {
                new Costumer {Id = 1, Name = "John"},
                new Costumer {Id = 2, Name = "Bela"}
            };
        }
        // GET: Customer
  
    }
}