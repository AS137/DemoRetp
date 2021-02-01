using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPhoneBookDiary_MVC.Models;

namespace MyPhoneBookDiary_MVC.Data
{
    public class MyPhoneBookDiary_MVCContext : DbContext
    {
        public MyPhoneBookDiary_MVCContext (DbContextOptions<MyPhoneBookDiary_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<MyPhoneBookDiary_MVC.Models.Address> Address { get; set; }

        public DbSet<MyPhoneBookDiary_MVC.Models.Email> Email { get; set; }

        public DbSet<MyPhoneBookDiary_MVC.Models.Phone> Phone { get; set; }

        public DbSet<MyPhoneBookDiary_MVC.Models.User> User { get; set; }
    }
}
