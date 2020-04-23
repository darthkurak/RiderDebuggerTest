using System;
using System.Threading.Tasks;

namespace DebuggerTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var c = await Helper.MethodAsync();
        }
        //
        // static void Main(string[] args)
        // {
        //     var c = Helper.MethodAsync().Result;
        // }
    }
}