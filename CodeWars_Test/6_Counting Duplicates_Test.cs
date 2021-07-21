using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Unit2.DuplicateCount(""));
            Assert.AreEqual(0, Unit2.DuplicateCount("abcde"));
            Assert.AreEqual(2, Unit2.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, Unit2.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, Unit2.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, Unit2.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}
