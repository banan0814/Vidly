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
        private ApplicationDbContext _context;

        public CostumerController()
        {
           _context= new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }

        public ViewResult Index()
        {
            var customers = _context.Costumers.ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Costumers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
               return HttpNotFound();
                
            }
            return View(customer);
        }
        
        // GET: Customer
  
    }
}