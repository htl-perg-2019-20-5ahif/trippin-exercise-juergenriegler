using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using TrippinLogic;

namespace TrippinConsoleApp
{
    class UserAdder
    {
        private readonly HttpClient Client;

        public UserAdder(HttpClient client)
        {
            this.Client = client;
        }

        public async System.Threading.Tasks.Task<IEnumerable<User>> AddUsersAsync(IEnumerable<User> users)
        {
            var userChecker = new UserChecker(Client);
            var addedUsers = new List<User>();
            foreach (User u in users)
            {
                if (await userChecker.UserExistingAsync(u.UserName)) continue;
                await AddUserToDBAsync(u);
                addedUsers.Add(u);
            }
            return addedUsers;
        }

        private async System.Threading.Tasks.Task AddUserToDBAsync(User user)
        {
            var content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync("People", content);
        }
    }
}
