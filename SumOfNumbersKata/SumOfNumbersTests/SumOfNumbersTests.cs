using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfNumbersKata;

namespace SumOfNumbersTests
{
    [TestClass]
    public class SumOfNumbersTests
    {
        [TestMethod]
        public void AddOneAndZero()
        {
            Assert.AreEqual(1, SumTwoNumbers.SumTwoThroughNumbers(1, 0), "Add 1 and 0");
        }

        [TestMethod]
        public void AddTwoAndThree()
        {
            Assert.AreEqual(5, SumTwoNumbers.SumTwoThroughNumbers(2, 3), "Add 2 and 3");
        }

        [TestMethod]
        public void AddNegative1And3()
        {
            Assert.AreEqual(5, SumTwoNumbers.SumTwoThroughNumbers(-1, 3), "Add -1 and 3");
        }
    }
}
