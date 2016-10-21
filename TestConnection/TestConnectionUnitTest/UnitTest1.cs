using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestConnectionUnitTest
{
    [TestClass]
    public class BaseTests
    {
        [TestMethod]
        public void FailTest()
        {
            Assert.IsTrue(true, "This test does NOT pass, ever!");
        }

        [TestMethod]
        public void SuccessTest()
        {
            Assert.IsTrue(true, "This test does not FAIL, ever!");
        }
    }
}
