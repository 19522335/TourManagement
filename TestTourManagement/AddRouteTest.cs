using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class AddRouteTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            tblTuyen route = new tblTuyen();
            Assert.AreEqual(false, TestFunction.AddRouteFunction(route), "Email Wrong Format!");
        }
    }
}
