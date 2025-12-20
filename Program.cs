using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Service> services = new List<Service>();
            Dictionary<string, Service> serviceDictionary = new Dictionary<string, Service>();

            WebServer web1 = new WebServer("Web1", "Online", 120, "top-academy.ru");
            Database db1 = new Database("DB1", "Offline", 250, "MySQL");

            services.Add(web1);
            services.Add(db1);

            serviceDictionary[web1.Name] = web1;
            serviceDictionary[db1.Name] = db1;

            foreach (var service in services)
            {
                service.GetStatus();
            }

            Console.WriteLine("\nВведите имя сервиса для проверки статуса: ");
            string input = Console.ReadLine();

            if (serviceDictionary.ContainsKey(input))
            {
                serviceDictionary[input].GetStatus();
            } else
            {
                Console.WriteLine("Сервис не найден");
            }
        }
    }
}
