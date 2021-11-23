using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace Class1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HelloWorld_return()
        {
            string str = "Hello Wold";
            Class1 class1 = new Class1();
            string result = class1.Lyana();
            Assert.AreEqual(str, result);
        }
    }
}
