using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Failed");
            Assert.Fail();
        }
        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Passed");
        }
    }
}
