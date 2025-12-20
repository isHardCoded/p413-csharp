using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal abstract class Service
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int ResponseTime { get; set; }

        public Service(string name, string status, int responseTime)
        {
            Name = name;
            Status = status;
            ResponseTime = responseTime;
        }

        public abstract void GetStatus();
    }
}
