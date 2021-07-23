using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, Unit7.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}
