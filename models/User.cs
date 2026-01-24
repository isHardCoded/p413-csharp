using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.models
{
    internal class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string BirthDate { get; set; } = string.Empty;
        public Login Login { get; set; } = new Login();
        public Address Address { get; set; } = new Address();
        public string Phone { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public Company Company { get; set; } = new Company();
    }
}
