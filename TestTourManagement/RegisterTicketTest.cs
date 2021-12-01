using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class RegisterTicketTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            bool foreign = false;
            Customer customer = new Customer();
            Assert.AreEqual(true, TestFunction.RegisterTicketFucntion(foreign, customer));
        }
    }
}
