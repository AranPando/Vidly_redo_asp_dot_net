using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRedo.Models;
using VidlyRedo.ViewModels;

namespace VidlyRedo.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        [Route("customers")]
        public ActionResult Index()
        {
            IndexCustomerViewModel custs = new IndexCustomerViewModel();

            custs.Customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(custs);
        }

        [Route("Customers/{id}")]
        public ActionResult ViewCustomer(int id)
        {
            Customer cust = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.id == id);

            if (cust == null)
                return HttpNotFound("Invalid customer id");

            return View(cust);
        }

        [Route("Customers/add/{id}/{name}")]
        public ActionResult AddCustomer(int id, string name)
        {
            Customer Cust = GlobalVariables.AddCustomer(id, name);
            if (Cust == null) return HttpNotFound("Bad customer info");
            return RedirectToAction("Index");
        }
    }
}