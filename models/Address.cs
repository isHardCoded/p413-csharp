using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.models
{
    internal class Address
    {
        public string Street { get; set; } = string.Empty;
        public string Suite { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        public Geo Geo { get; set; } = new Geo();
    }
}
