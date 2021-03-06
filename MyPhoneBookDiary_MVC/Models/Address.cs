﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhoneBookDiary_MVC.Models
{
    public class Address
    {
        // creating key
        [Key]
        public int AddrId { get; set; }
        public string HouseNO { get; set; } // prop house no
        public string Street { get; set; } // prop address
        public string State { get; set; } // prop state
        public int PostalCode { get; set; } // prop postal code
        public string Country { get; set; } // prop country

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
