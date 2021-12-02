using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class ResetPasswordTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, TestFunction.ResestPasswordFunction("123456", "123456"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, TestFunction.ResestPasswordFunction("123456", "12345"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, TestFunction.ResestPasswordFunction("", ""));
        }
    }
}
