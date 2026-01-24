using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using ConsoleApp26.services;
using ConsoleApp26.models;

namespace ConsoleApp26
{
    internal class Program
    {      
        static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient()) 
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 YaBrowser/25.12.0.0 Safari/537.36");

                UserService service = new UserService(client);

                List<User> users = await service.GetAllUsersAsync();

                foreach (User user in users)
                {
                    Console.WriteLine(user.Firstname);
                }

                User newUser = new User()
                {
                    Firstname = "John",
                    Lastname = "Doe",
                    Email = "johndev@mail.ru",
                    BirthDate = "1973-01-22",  
                    Phone = "(555) 555-1234",  
                    Website = "www.johndoe.com", 
                    Login = new Login()
                    {
                        Uuid = "1a0eed01-9430-4d68-901f-c0d4c1c3bf22",
                        Username = "johndoe",
                        Password = "jsonplaceholder.org",
                        Md5 = "c1328472c5794a25723600f71c1b4586",
                        Sha1 = "35544a31cc19bd6520af116554873167117f4d94",
                        Registered = "2023-01-10T10:03:20.022Z"
                    },
                    Address = new Address()
                    {
                        Street = "Fabrichnaya",
                        Suite = "9",
                        City = "Tyumen",
                        Zipcode = "798623",
                        Geo = new Geo()
                        {
                            Lat = "39.821739",
                            Lng = "87.129782"
                        }
                    },
                    Company = new Company()
                    {
                        Name = "ABC Company",
                        CatchPhrase = "Innovative solutions for all your needs",
                        Bs = "Marketing"
                    }
                };

                try
                {
                    User createdUser = await service.CreateUserAsync(newUser);
                    Console.WriteLine($"Created: {createdUser.Firstname} {createdUser.Email}");
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }

                User currentUser = await service.GetUserAsync(2);
                Console.WriteLine($"{currentUser.Firstname}");

                await service.DeleteUserAsync(2);
                Console.WriteLine($"User deleted");
            }
            ;   
        }
    }
}
