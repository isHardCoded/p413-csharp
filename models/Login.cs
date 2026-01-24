using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.models
{
    internal class Login
    {
        public string Uuid { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Md5 { get; set; } = string.Empty;
        public string Sha1 { get; set; } = string.Empty;
        public string Registered { get; set; } = string.Empty;
    }
}
