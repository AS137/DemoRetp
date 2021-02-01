using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhoneBookDiary_MVC.Models
{
    public class Email
    {
        [Key]
        public int EmailID { get; set; }
        public string ElectonicMail { get; set; }
        public bool isActive { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
