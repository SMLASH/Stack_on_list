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
            var ls = new List<int>();
            ls.AddElement(3);
            int expected = 3;
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