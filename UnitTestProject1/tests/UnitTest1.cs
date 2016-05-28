using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("softpost.org", "softpost.org");
        }
    }
}
