using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhoLikeItKata;

namespace WhoLikeItKataTests
{
    [TestClass]
    public class WhoLikesItTests
    {
        [TestMethod]
        public void NoLikesIt()
        {
            Assert.AreEqual("No one likes this", WhoLikesIt.Likes(new string[0]), "Input: Empty array");
        }

        [TestMethod]
        public void BillLikesThis()
        {
            Assert.AreEqual("Bill likes this", WhoLikesIt.Likes(new string[] { "Bill" }), "Input: One name in the array");
        }

        [TestMethod]
        public void TwoPeoplLikeThis()
        {
            Assert.AreEqual("Bill and Frank like this", WhoLikesIt.Likes(new string[] { "Bill", "Frank" }), "Input: Two names in the array");
        }

        [TestMethod]
        public void ThreePeoplLikeThis()
        {
            Assert.AreEqual("Bill, Frank and Marge like this", WhoLikesIt.Likes(new string[] { "Bill", "Frank", "Marge" }), "Input: Three names in the array");
        }

        [TestMethod]
        public void FourPeoplLikeThis()
        {
            Assert.AreEqual("Bill, Frank and 2 others like this", WhoLikesIt.Likes(new string[] { "Bill", "Frank", "Marge", "Phil" }), "Input: Four names in the array");
        }
    }
}
