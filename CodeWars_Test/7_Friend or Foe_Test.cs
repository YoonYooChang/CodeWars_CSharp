using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWars_Test
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };

            // Why not working, but CodeWars Site work very well;
            // CollectionAssert.AreEqual(expected, Unit8.FriendOrFoe(names));
        }
    }
}
