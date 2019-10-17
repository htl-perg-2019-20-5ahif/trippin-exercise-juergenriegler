using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrippinConsoleApp
{
    public interface IUserReader
    {
        public Task<string> ReadUser(string path);
    }
}
