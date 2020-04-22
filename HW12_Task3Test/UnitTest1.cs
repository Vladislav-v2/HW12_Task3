using NUnit.Framework;
using System;
using HW12_Task3;

namespace HW12_Task3Test
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("3+4*2/(1-5)^2", 3.5)]
        [TestCase("5+8*3/(19-6)^0", 29)]
        [TestCase("3+5*2/(3-4)^2", 13)]
        [TestCase("2+34*7/(7-12)^2", 11.52)]
        public void TestResultMethod(string str, double expRes)
        {
            double actRes = Program.Result(str);
            Assert.AreEqual(expRes, actRes);
        }
    }
}
