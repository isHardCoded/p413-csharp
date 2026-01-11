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
                UserService service = new UserService(client);

                List<User> users = await service.GetAllUsersAsync();

                foreach (User user in users)
                {
                    Console.WriteLine(user.Username);
                }

                User newUser = new User()
                {
                    Name = "John",
                    Username = "johndoe",
                    Email = "johndev@mail.ru",
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
                    }
                };

                User createdUser = await service.CreateUserAsync(newUser);
                Console.WriteLine($"Created: {createdUser.Name} {createdUser.Email}");

                User currentUser = await service.GetUserAsync(2);
                Console.WriteLine($"{currentUser.Name}");

                User deletedUser = await service.DeleteUserAsync(2);
                Console.WriteLine($"User deleted");
            };   
        }
    }
}
