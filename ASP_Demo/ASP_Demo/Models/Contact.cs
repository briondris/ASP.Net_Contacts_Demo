using System;
namespace ASP_Demo.Models
{
    public class Contact
    {
        // properites
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
    }
}

