using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp26.models;

namespace ConsoleApp26.services
{
    internal class UserService
    {
        private readonly HttpClient _httpClient;
        private const string BASE_URL = "https://jsonplaceholder.typicode.com/users";

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>(BASE_URL);
        }

        public async Task<User> GetUserAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{BASE_URL}/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<User>();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(BASE_URL, user);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<User>();
        }

        public async Task<User> DeleteUserAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"{BASE_URL}/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<User>();
        }
    }
}
