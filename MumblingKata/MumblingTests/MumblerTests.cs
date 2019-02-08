using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mumbling;

namespace MumblingTests
{
    [TestClass]
    public class MumblerTests
    {
        [TestMethod]
        public void SingleLetterReturnUpperCase()
        {
            Assert.AreEqual("A", Mumbler.GetMumbles("a"), "Input: a");
        }

        [TestMethod]
        public void TwoLowerCaseLetterPhrase()
        {
            Assert.AreEqual("A-Bb", Mumbler.GetMumbles("ab"), "Input: ab");
        }

        [TestMethod]
        public void ThreeLowerCaseLetterPhrase()
        {
            Assert.AreEqual("A-Bb-Ccc", Mumbler.GetMumbles("abc"), "Input: abc");
        }

        [TestMethod]
        public void ThreeLetterPhrase()
        {
            Assert.AreEqual("A-Bb-Ccc", Mumbler.GetMumbles("aBc"), "Input: aBc");
        }

        [TestMethod]
        public void ManyLetterPhrase()
        {
            Assert.AreEqual("A-Bb-Ccc-Dddd-Eeeee-Ffffff-Ggggggg-Hhhhhhhh-Iiiiiiiii", Mumbler.GetMumbles("aBcdEfghi"), "Input: aBcdEfghi");
        }
    }
}
