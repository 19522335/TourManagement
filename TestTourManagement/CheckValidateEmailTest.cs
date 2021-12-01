using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class CheckValidateEmailTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(false, TestFunction.CheckEmailFunction("19522074@"), "Email Wrong Format!");
        }
    }
}
