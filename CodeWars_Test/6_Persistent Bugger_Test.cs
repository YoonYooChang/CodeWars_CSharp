using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest12
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(3, Unit12.Persistence(39));
            Assert.AreEqual(0, Unit12.Persistence(4));
            Assert.AreEqual(2, Unit12.Persistence(25));
            Assert.AreEqual(4, Unit12.Persistence(999));
        }
    }
}
