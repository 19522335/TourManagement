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
            string id = "1";
            string name = "Ba Ria - TPHCM";
            string departure = "Ba Ria";
            string destination = "TPHCM";
            string day = "1";
            string night = "1";
            string message = "";
            Assert.AreEqual(true, TestFunction.CheckRouteDataFunction(id, name, departure, destination, day, night, out message));
        }


        [Test]
        public void Test2()
        {
            string id = "";
            string name = "Ba Ria - TPHCM";
            string departure = "Ba Ria";
            string destination = "TPHCM";
            string day = "1";
            string night = "1";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckRouteDataFunction(id, name, departure, destination, day, night, out message));
        }

        [Test]
        public void Test3()
        {
            string id = "1";
            string name = "";
            string departure = "Ba Ria";
            string destination = "TPHCM";
            string day = "1";
            string night = "1";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckRouteDataFunction(id, name, departure, destination, day, night, out message));
        }        

        [Test]
        public void Test4()
        {
            string id = "1";
            string name = "Ba Ria - TPHCM";
            string departure = "";
            string destination = "TPHCM";
            string day = "1";
            string night = "1";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckRouteDataFunction(id, name, departure, destination, day, night, out message));
        }

        [Test]
        public void Test5()
        {
            string id = "1";
            string name = "Ba Ria - TPHCM";
            string departure = "Ba Ria";
            string destination = "";
            string day = "1";
            string night = "1";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckRouteDataFunction(id, name, departure, destination, day, night, out message));
        }

        [Test]
        public void Test6()
        {
            string id = "1";
            string name = "Ba Ria - TPHCM";
            string departure = "Ba Ria";
            string destination = "TPHCM";
            string day = "";
            string night = "1";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckRouteDataFunction(id, name, departure, destination, day, night, out message));
        }

        [Test]
        public void Test7()
        {
            string id = "1";
            string name = "Ba Ria - TPHCM";
            string departure = "Ba Ria";
            string destination = "TPHCM";
            string day = "1";
            string night = "";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckRouteDataFunction(id, name, departure, destination, day, night, out message));
        }
    }
}
