using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest13
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Unit13.IsPangram("The quick brown fox jumps over the lazy dog."));
        }
    }
}
