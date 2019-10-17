using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TrippinConsoleApp
{
    public class UserChecker
    {
        private readonly HttpClient client;

        public UserChecker(HttpClient client)
        {
            this.client = client;
        }

        public async System.Threading.Tasks.Task<bool> UserExistingAsync(string username)
        {
            var userResponse = await client.GetAsync("People('" + username + "')");
            if (userResponse.IsSuccessStatusCode) return true; return false;
        }
    }
}
