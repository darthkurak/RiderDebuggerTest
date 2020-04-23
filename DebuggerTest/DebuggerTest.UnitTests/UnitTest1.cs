using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace DebuggerTest.UnitTests
{
    public class PeselHelperTests
    {
        [Fact]
        public async Task TestAsync()
        {
            var c = await Helper.MethodAsync();
        }
        
        [Fact]
        public void Test()
        {
            var c = Helper.MethodAsync().Result;
        }
    }
}