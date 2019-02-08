using Masking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaskingTests
{
    [TestClass]
    public class CreditCardMaskingTests
    {
        [TestMethod]
        public void StringOf5Characters()
        {
            string actual = CreditCardMasking.Maskify("1Test");

            Assert.AreEqual("#test", actual, "Input: \"1Test\"");
        }

        [TestMethod]
        public void StringOf11Characters()
        {
            string actual = CreditCardMasking.Maskify("Ben is Cool");

            Assert.AreEqual("#######Cool", actual, "Input: \"Ben is Cool\"");
        }
    }
}
