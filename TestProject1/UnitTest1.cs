using System;
using List;
using Xunit;
using Xunit.Abstractions;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddElementTest()
        {
            var ls = new List<int>();
            ls.Add(4);
            const int expected = 4;
            var actual = ls.GetValue(0);
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FindValueTest()
        {
            var ls = new List<int>();
            const int value = 4;
            ls.Add(value);
            
            Assert.True(ls.Find(value));
        }
    }
}