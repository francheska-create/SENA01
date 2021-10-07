using System;
using Xunit;

namespace unitTest.FluderAssertionLabo01
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string actual = "ABCDGBHI";

            actual.Should().StharWit("AB").And.EndWith("HI").And.Contain("EF").And.Havelength(9);
        }
    }
}
