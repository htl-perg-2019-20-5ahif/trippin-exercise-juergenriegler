using System;
using TrippinLogic;
using System.Net.Http;

namespace TrippinConsoleApp
{
    class Program
    {
        static readonly string filename = "users.json";
        static HttpClient client = new HttpClient() { 
            BaseAddress = new Uri("https://services.odata.org/TripPinRESTierService/(S(dn0wirlpkxu35x2tya0nmqwo))/") 
        };
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            IUserReader reader = new UserFileReader();
            var text = await reader.ReadUser(filename);

            IUserParser parser = new UserJsonParser();
            var users = parser.ParseUserString(text);

        }
    }
}
