using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    class LoginTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, TestFunction.LoginFunction("19522074@gm.uit.edu.vn", "12345"));
        }

        [Test]
        public void Test2()
        {

            Assert.Pass();
        }

        [Test]
        public void Test3()
        {

            Assert.Pass();
        }

        [Test]
        public void Test4()
        {

            Assert.Pass();
        }

        [Test]
        public void Test5()
        {

            Assert.Pass();
        }

        [Test]
        public void Test6()
        {

            Assert.Pass();
        }
    }
}
