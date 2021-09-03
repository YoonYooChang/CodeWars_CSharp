using CodeWars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest17
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                "Strings didn't match.");
        }
    }
}
