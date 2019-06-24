using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyRedo.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(50)]
        public String Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationMonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}