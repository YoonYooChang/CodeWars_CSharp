using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2110, Unit1.DescendingOrder(1012));
            Assert.AreEqual(54421, Unit1.DescendingOrder(42145));
            Assert.AreEqual(654321, Unit1.DescendingOrder(145263));
            Assert.AreEqual(987654321, Unit1.DescendingOrder(123456789));
        }
    }
}
