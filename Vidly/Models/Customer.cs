﻿
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required]
        [StringLength(244)]
        public string Name { get; set; }

        public bool IsSubscribeToNewsLetter { get; set; }


        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        [StringLength(244)]
        public string Birthday { get; set; }
    }
}