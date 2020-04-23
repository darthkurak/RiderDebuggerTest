using System;
using System.Threading.Tasks;

namespace DebuggerTest
{
    public static class Helper
    {
        public static Task<char> MethodAsync()
        {
            var str = "SomeString";
            var c = str[34];
            return Task.FromResult(c);
        }
    }
}