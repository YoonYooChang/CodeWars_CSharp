using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("emocleW", Unit5.SpinWords("Welcome"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Unit5.SpinWords("Hey fellow warriors"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("This is a test", Unit5.SpinWords("This is a test"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual("This is rehtona test", Unit5.SpinWords("This is another test"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Unit5.SpinWords("You are almost to the last test"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Unit5.SpinWords("Just kidding there is still one more"));
        }
    }
}
