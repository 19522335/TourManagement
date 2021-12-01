using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class CheckRouteDataTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string id = "";
            string name = "";
            string departure = "";
            string destination = "";
            string day = "";
            string night = "";
            string message = "";
            Assert.AreEqual(true, TestFunction.CheckRouteDataFunction(id, name, departure, destination, day, night, out message));
        }
    }
}
