using System;
using System.Collections.Generic;
using System.IO;
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
            string filePath = @"C:\Users\User\Desktop\data.txt";
         
            using (StreamWriter writer = new StreamWriter(filePath, append: false, encoding: Encoding.UTF8))
            {
                writer.WriteLine("Hello");
                writer.WriteLine("Hello");
                writer.WriteLine("Hello");
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
