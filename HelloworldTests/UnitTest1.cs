using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helloworld;

namespace HelloworldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Helloworld", Program.CreateMessage());
        }
    }
}
