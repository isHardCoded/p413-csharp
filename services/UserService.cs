using ConsoleApp26.models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp26.services
{
    internal class UserService
    {
        private readonly HttpClient _httpClient;
        private const string BASE_URL = "https://jsonplaceholder.org/users";

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<User>>(BASE_URL);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"GetAllUsers ошибка: {ex.Message}");
                throw;
            }
        }

        public async Task<User> GetUserAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{BASE_URL}/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<User>();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            var response = await _httpClient.PostAsJsonAsync(BASE_URL, user);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<User>();
        }

        public async Task DeleteUserAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{BASE_URL}/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
