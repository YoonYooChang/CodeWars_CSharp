using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest9
    {
        [TestMethod, Description("test")]
        public void testTest()
        {
            Assert.AreEqual("grfg", Unit9.Rot13("test"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Unit9.Rot13("test")));
        }

        [TestMethod, Description("Test")]
        public void TestTest()
        {
            Assert.AreEqual("Grfg", Unit9.Rot13("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Unit9.Rot13("Test")));
        }
    }
}
