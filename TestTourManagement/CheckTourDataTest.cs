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
            string id = "";
            string idtrip = "";
            string hour = "";
            string minute = "";
            bool regular = false;
            bool promotional = false;
            string price = "";
            string transport = "";
            string message = "";
            Assert.AreEqual(true, TestFunction.CheckTourDataFunction(id, idtrip, hour, minute, regular, promotional, price, transport, out message));
        }
    }
}
