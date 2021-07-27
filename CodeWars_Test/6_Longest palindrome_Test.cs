using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest14
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Unit14.GetLongestPalindrome("   "));
            Assert.AreEqual(5, Unit14.GetLongestPalindrome("12 21glg"));
            Assert.AreEqual(7, Unit14.GetLongestPalindrome("abc0cba1"));
            Assert.AreEqual(2, Unit14.GetLongestPalindrome("baa"));
            Assert.AreEqual(2, Unit14.GetLongestPalindrome("aa"));
            Assert.AreEqual(1, Unit14.GetLongestPalindrome("a"));
            Assert.AreEqual(0, Unit14.GetLongestPalindrome(null));
            Assert.AreEqual(0, Unit14.GetLongestPalindrome(""));
        }
    }
}
