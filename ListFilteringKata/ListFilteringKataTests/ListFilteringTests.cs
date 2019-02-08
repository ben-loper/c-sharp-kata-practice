using ListFilteringKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ListFilteringKataTests
{
    [TestClass]
    public class ListFilteringTests
    {
        [TestMethod]
        public void ListOf1IntegerAnd1String()
        {
            var input = new List<object>() { 1, "a" };

            var actual = ListFiltering.GetIntegersFromList(input);

            List<int> expected = new List<int>() { 1 };

            CollectionAssert.AreEqual(expected, (List<int>)actual, "Input: {1 , \"a\"}");

        }


        [TestMethod]
        public void ListOfMultipleStrings()
        {
            var input = new List<object>() { "b", "a" };

            var actual = ListFiltering.GetIntegersFromList(input);

            List<int> expected = new List<int>();

            CollectionAssert.AreEqual(expected, (List<int>)actual, "Input: {\"b\" , \"a\"}");

        }

        [TestMethod]
        public void ListOfMultipleIntegers()
        {
            var input = new List<object>() { 1, 2, 3, 5 };

            var actual = ListFiltering.GetIntegersFromList(input);

            List<int> expected = new List<int>() { 1, 2, 3, 5 };

            CollectionAssert.AreEqual(expected, (List<int>)actual, "Input: { 1, 2, 3, 5 }");

        }

        [TestMethod]
        public void StringsAndIntegersAndObject()
        {
            var input = new List<object>() { 1, "2", 3, 5, 12134, "Hi", new List<string>() };

            var actual = ListFiltering.GetIntegersFromList(input);

            List<int> expected = new List<int>() { 1, 3, 5, 12134 };

            CollectionAssert.AreEqual(expected, (List<int>)actual, "Input: { 1, \"2\", 3, 5, 12134, \"Hi\", new List<string>() }");

        }
    }
}
