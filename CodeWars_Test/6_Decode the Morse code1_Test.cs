using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest11
    {
        [TestMethod]
        public void TestMethod1()
        {
			try
			{
				string input = ".... . -.--   .--- ..- -.. .";
				string expected = "HEY JUDE";

				string actual = Unit11.Decode(input);

				Assert.AreEqual(expected, actual);
			}
			catch (Exception ex)
			{
				Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
			}
		}
    }
}
