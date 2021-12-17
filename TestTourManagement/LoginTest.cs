using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class LoginTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, TestFunction.LoginFunction("19522335@gm.uit.edu.vn", "1234"), "Login Failed");
        }

        [Test]
        public void Test2()
        {

            Assert.AreEqual(false, TestFunction.LoginFunction("19522074@gm.uit.edu.vn", ""), "Login Success");
        }

        [Test]
        public void Test3()
        {

            Assert.AreEqual(false, TestFunction.LoginFunction("19522074", "12345"), "Login Success");
        }

        [Test]
        public void Test4()
        {

            Assert.AreEqual(false, TestFunction.LoginFunction("19522074", ""), "Login Success");
        }

        [Test]
        public void Test5()
        {

            Assert.AreEqual(false, TestFunction.LoginFunction("", "12345"), "Login Success");
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(false, TestFunction.LoginFunction("", ""), "Login Success");
        }
    }
}
