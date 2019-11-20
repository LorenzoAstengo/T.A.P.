using System;
using System.Collections.Generic;
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
    }
}

