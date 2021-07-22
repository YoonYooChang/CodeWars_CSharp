using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, Unit3.sumTwoSmallestNumbers(numbers));
        }
    }
}
