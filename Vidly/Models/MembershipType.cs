using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public string Name { get; set; }
        [Required]
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte Discountrate { get; set; }
        public byte ID { get; set; }
 
    }
}