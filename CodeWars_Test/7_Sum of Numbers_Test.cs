using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, Unit4.GetSum(0, 1));
            Assert.AreEqual(-1, Unit4.GetSum(0, -1));
            Assert.AreEqual(2, Unit4.GetSum(-1, 2));
            Assert.AreEqual(1, Unit4.GetSum(1, 1));
        }
    }
}
