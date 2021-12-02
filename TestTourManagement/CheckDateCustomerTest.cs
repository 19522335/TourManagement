using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class CheckDateCustomerTest
    {
        [Test]
        public void Test1()
        {
            string tour_id = "1";
            DateTime PassExp = new DateTime(2021, 11, 11);
            DateTime VisaExp = new DateTime(2021, 11, 12);
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckDateFunction(PassExp, VisaExp, tour_id, ref message), message);
        }

        [Test]
        public void Test2()
        {
            string tour_id = "1";
            DateTime PassExp = new DateTime(2021, 11, 11);
            DateTime VisaExp = new DateTime(2021, 11, 12);
            string message = "";
            Assert.AreEqual(false, TestFunction.CheckDateFunction(PassExp, VisaExp, tour_id, ref message), message);
        }

        [Test]
        public void Test3()
        {
            string tour_id = "1";
            DateTime PassExp = new DateTime(2021, 12, 14);
            DateTime VisaExp = new DateTime(2021, 12, 29);
            string message = "";
            Assert.AreEqual(true, TestFunction.CheckDateFunction(PassExp, VisaExp, tour_id, ref message), message);
        }
    }
}
