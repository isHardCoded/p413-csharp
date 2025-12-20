using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public abstract class Service
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

    public class WebServer : Service
    {
        public string Domain { get; set; }

        public WebServer(string name, string status, int responseTime, string domain) : base(name, status, responseTime) {
            Domain = domain;
        }

        public override void GetStatus()
        {
            Console.WriteLine($"[Веб-сервер] {Name} ({Domain}): Статус = {Status}, Время отклика = {ResponseTime} мс");
        }
    }

    public class Database : Service
    {
        public string DbType { get; set; }

        public Database(string name, string status, int responseTime, string dbType) : base(name, status, responseTime)
        {
            DbType = dbType;
        }

        public override void GetStatus()
        {
            Console.WriteLine($"[База данных] {Name} ({DbType}): Статус = {Status}, Время отклика = {ResponseTime} мс");
        }
    }
}
