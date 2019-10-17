using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrippinConsoleApp
{
    class UserFileReader : IUserReader
    {
        public async Task<string> ReadUser(string path)
        {
            return await System.IO.File.ReadAllTextAsync(path);
        }
    }
}
