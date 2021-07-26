using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void Test0()
        {
            Assert.AreEqual(0, Unit10.MaxSequence(new int[0]));
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(6, Unit10.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
    }
}
