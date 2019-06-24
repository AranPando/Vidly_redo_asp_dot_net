using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRedo.Models;
using VidlyRedo.ViewModels;

namespace VidlyRedo.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("customers")]
        public ActionResult Index()
        {
            IndexCustomerViewModel custs = new IndexCustomerViewModel();
            custs.Customers = GlobalVariables.GetCustomers();
            return View(custs);
        }

        [Route("Customers/{id}")]
        public ActionResult ViewCustomer(int id)
        {
            Customer Cust = GlobalVariables.GetCustomerId(id);
            if (Cust == null) return HttpNotFound("Invalid customer id");
            return View(Cust);
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