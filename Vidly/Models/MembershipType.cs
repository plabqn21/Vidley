
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }

        public short DurationInMonrh { get; set; }
        public short DiscountRate { get; set; }
        public string Name { get; set; }
    }
}