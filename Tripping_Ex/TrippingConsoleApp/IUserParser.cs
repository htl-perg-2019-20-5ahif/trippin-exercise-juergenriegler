using System;
using System.Collections.Generic;
using System.Text;
using TrippinLogic;

namespace TrippinConsoleApp
{
    public interface IUserParser
    {
        User[] ParseUserString(string userString);
    }
}
