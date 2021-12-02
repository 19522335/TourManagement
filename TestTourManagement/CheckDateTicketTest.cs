using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class CheckDateTicketTest
    {
        [Test]
        public void Test1()
        {
            string tour_id = "1";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckDateTourFunction(tour_id, ref message), message);
        }

        [Test]
        public void Test2()
        {
            string tour_id = "2";
            string message = "";
            Assert.AreEqual(true, TestFunction.CheckDateTourFunction(tour_id, ref message), message);
        }

        [Test]
        public void Test3()
        {
            string tour_id = "3";
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckDateTourFunction(tour_id, ref message), message);
        }

        [Test]
        public void Test4()
        {
            string tour_id = "4";
            string message = "";
            Assert.AreEqual(true, TestFunction.CheckDateTourFunction(tour_id, ref message), message);
        }
    }
}
