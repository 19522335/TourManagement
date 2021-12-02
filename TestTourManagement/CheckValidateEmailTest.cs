using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class CheckValidateEmailTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, TestFunction.CheckEmailFunction("19522281@gm.uit.edu.vn"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, TestFunction.CheckEmailFunction("19522281"), "Email Wrong Format!");
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, TestFunction.CheckEmailFunction("19522281@gmail"), "Email Wrong Format!");
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, TestFunction.CheckEmailFunction("19522281@"), "Email Wrong Format!");
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(false, TestFunction.CheckEmailFunction("19522281.gmail.com"), "Email Wrong Format!");
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(false, TestFunction.CheckEmailFunction(""), "Email Wrong Format!");
        }
    }
}
