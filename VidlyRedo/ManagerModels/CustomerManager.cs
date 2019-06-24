using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyRedo.Models;

namespace VidlyRedo.Managers
{
    public class CustomerManager
    {
        private List<Customer> Customer;

        public CustomerManager()
        {
            this.Customer = new List<Customer>();
        }

        public List<Customer> GetCustomers()
        {
            return this.Customer;
        }

        public Customer AddCustomer(int id, string name)
        {
            if (id < 0 || String.IsNullOrWhiteSpace(name)) return null;

            Customer cust = new Customer();

            this.Customer.Add(cust);

            return cust;

        }

        public Customer GetCustomerId(int id)
        {
            if (id <= 0) return null;
            foreach(var cust in Customer)
                if (cust.id == id) return cust;
            return null;
        }
    }
}