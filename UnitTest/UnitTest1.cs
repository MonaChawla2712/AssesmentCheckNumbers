using CheckNumbers;
using System;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Program.CheckNumbers(165);
        }

        [Fact]
        public void Test2()
        {
            Program.CheckNumbers(96);
        }

        [Fact]
        public void Test3()
        {
            Program.CheckNumbers(155);
        }

        [Fact]
        public void Test4()
        {
            Program.CheckNumbers(131);
        }
    }
}
