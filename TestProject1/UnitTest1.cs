using System;
using Xunit;

using list;

namespace TestProject1
{
    public class UnitTest1
    {
        
        [Fact]
        public void AddElementTest()
        {
            var ls = new List<int>(3);
            ls.AddElementToEnd(4);
            int expected = 4;
            if (ls.GetValue().Equals(expected))
            {
                Console.WriteLine("AddElementTest: Pass");
            }
            else
            {
                Console.WriteLine("AddElementTest: Failed");
            }
        }
    }
}