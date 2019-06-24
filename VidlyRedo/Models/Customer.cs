using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyRedo.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public DateTime? dob { get; set; }
        public bool isSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

        //public Customer(int id, string name)
        //{
        //    this.id = id;
        //    this.name = name;
        //}
    }
}