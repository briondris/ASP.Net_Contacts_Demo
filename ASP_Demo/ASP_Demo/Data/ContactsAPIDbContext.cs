using ASP_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Demo.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        //constructor
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        //properites that will act as tables for entity frame work core
        public DbSet<Contact> Contacts { get; set; }
    }
}

