using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ConsoleApp26
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {      
        static void Main(string[] args)
        {
            string PATH = @"C:\Users\User\Source\Repos\p413-csharp\catalog.json";

            List<Product> products = new List<Product>()
            {
                new Electronics(1, "Phone", 599, 20, "Samsung", 6),
                new Clothing(2, "T-Shirt", 299, 50, "M", "Хлопок")
            };

            using (StreamWriter writer = new StreamWriter(PATH))
            {
                writer.WriteLine(JsonSerializer.Serialize(products));
            }
        }
    }
}
