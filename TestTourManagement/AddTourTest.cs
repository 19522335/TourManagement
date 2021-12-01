using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class AddTourTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            tblChuyen tour = new tblChuyen();
            Assert.AreEqual(true, TestFunction.AddTourFunction(tour));
        }
    }
}
