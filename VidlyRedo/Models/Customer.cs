using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyRedo.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}