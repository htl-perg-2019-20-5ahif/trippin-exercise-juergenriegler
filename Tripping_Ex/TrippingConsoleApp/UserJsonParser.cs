using System;
using System.Collections.Generic;
using System.Text;
using TrippinLogic;
using System.Text.Json;

namespace TrippinConsoleApp
{
    public class UserJsonParser : IUserParser
    {
        public User[] ParseUserString(string userString)
        {
            // return JsonSerializer.Deserialize<Users>(userString);
            return JsonSerializer.Deserialize<User[]>(userString);
        }
    }
}
