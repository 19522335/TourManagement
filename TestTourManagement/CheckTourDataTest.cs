using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class CheckTourDataTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string id = "1";
            string idtrip = "1";
            string hour = "1";
            string minute = "1";
            string price = "1000000";
            string transport = "PLane";
            string message = "";
            Assert.AreEqual(true, TestFunction.CheckTourDataFunction(id, idtrip, hour, minute, price, transport, out message));
        }

        [Test]
        public void Test2()
        {
            string id = "";
            string idtrip = "1";
            string hour = "1";
            string minute = "1";
            string price = "1000000";
            string transport = "PLane";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckTourDataFunction(id, idtrip, hour, minute, price, transport, out message));
        }

        [Test]
        public void Test3()
        {
            string id = "1";
            string idtrip = "";
            string hour = "1";
            string minute = "1";
            string price = "1000000";
            string transport = "PLane";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckTourDataFunction(id, idtrip, hour, minute, price, transport, out message));
        }

        [Test]
        public void Test4()
        {
            string id = "1";
            string idtrip = "1";
            string hour = "";
            string minute = "1";
            string price = "1000000";
            string transport = "PLane";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckTourDataFunction(id, idtrip, hour, minute, price, transport, out message));
        }

        [Test]
        public void Test5()
        {
            string id = "1";
            string idtrip = "1";
            string hour = "1";
            string minute = "";
            string price = "1000000";
            string transport = "PLane";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckTourDataFunction(id, idtrip, hour, minute, price, transport, out message));
        }

        [Test]
        public void Test6()
        {
            string id = "1";
            string idtrip = "1";
            string hour = "1";
            string minute = "1";
            string price = "";
            string transport = "PLane";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckTourDataFunction(id, idtrip, hour, minute, price, transport, out message));
        }

        [Test]
        public void Test7()
        {
            string id = "1";
            string idtrip = "1";
            string hour = "1";
            string minute = "1";
            string price = "1000000";
            string transport = "";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckTourDataFunction(id, idtrip, hour, minute, price, transport, out message));
        }
    }
}
