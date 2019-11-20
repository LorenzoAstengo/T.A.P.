using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSequenceIsNullThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => TestProject.MacroExpansion(null, 3, new List<int>(5)));
        }

        [TestMethod]
        public void TestnewValuesIsNullThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => TestProject.MacroExpansion(new List<int>(5), 3, null));
        }

        [TestMethod]
        public void TestSequenceWithNoElementToExchange()
        {
            List<int> seqList = new List<int> { 1, 2, 3 };
            List<int> newList = new List<int> {5, 6, 7};

            Assert.IsTrue(Enumerable.SequenceEqual(seqList, TestProject.MacroExpansion(seqList, 4, newList)));
        }

        [TestMethod]
        public void TestSequenceWithOneElementToExchangeOnHead()
        {
            List<int> seqList = new List<int> { 1, 2, 3 };
            List<int> newList = new List<int> { 5, 6, 7 };
            List<int> expectedList = new List<int> { 5, 6, 7, 2, 3 };

            Assert.IsTrue(Enumerable.SequenceEqual(expectedList, TestProject.MacroExpansion(seqList, 1, newList)));
        }

        [TestMethod]
        public void TestSequenceWithOneElementToExchangeOnMiddle()
        {
            List<int> seqList = new List<int> { 1, 2, 3 };
            List<int> newList = new List<int> { 5, 6, 7 };
            List<int> expectedList = new List<int> { 1, 5, 6, 7, 3 };

            Assert.IsTrue(Enumerable.SequenceEqual(expectedList, TestProject.MacroExpansion(seqList, 2, newList)));
        }

        [TestMethod]
        public void TestSequenceWithOneElementToExchangeOnEnd()
        {
            List<int> seqList = new List<int> { 1, 2, 3 };
            List<int> newList = new List<int> { 5, 6, 7 };
            List<int> expectedList = new List<int> { 1, 2, 5, 6, 7 };

            Assert.IsTrue(Enumerable.SequenceEqual(expectedList, TestProject.MacroExpansion(seqList, 3, newList)));
        }

        [TestMethod]
        public void TestSequenceWithMultipleElementsToExchange()
        {
            List<int> seqList = new List<int> { 1, 2, 1 };
            List<int> newList = new List<int> { 5, 6, 7 };
            List<int> expectedList = new List<int> { 5, 6, 7, 2, 5, 6, 7 };

            Assert.IsTrue(Enumerable.SequenceEqual(expectedList, TestProject.MacroExpansion(seqList, 1, newList)));
        }

        [TestMethod]
        public void TestStringSequenceWithOneElementToExchange()
        {
            List<String> seqList = new List<String> { "ciao", "come", "va?" };
            List<String> newList = new List<String> { "Buongiorno", "/", "Buonasera" };
            List<String> expectedList = new List<String> { "Buongiorno", "/", "Buonasera", "come", "va?" };

            Assert.IsTrue(Enumerable.SequenceEqual(expectedList, TestProject.MacroExpansion(seqList, "ciao", newList)));
        }

        [TestMethod]
        public void TestStringSequenceWithNewValueContainingOneElement()
        {
            List<String> seqList = new List<String> { "ciao", "come", "va?" };
            List<String> newList = new List<String> { "Buongiorno" };
            List<String> expectedList = new List<String> { "Buongiorno", "come", "va?" };

            Assert.IsTrue(Enumerable.SequenceEqual(expectedList, TestProject.MacroExpansion(seqList, "ciao", newList)));
        }

        [TestMethod]
        public void TestStringSequenceWithEmptyNewValue()
        {
            List<String> seqList = new List<String> { "ciao", "come", "va?" };
            List<String> newList = new List<String> {};
            List<String> expectedList = new List<String> { "come", "va?" };

            Assert.IsTrue(Enumerable.SequenceEqual(expectedList, TestProject.MacroExpansion(seqList, "ciao", newList)));
        }
    }
}

