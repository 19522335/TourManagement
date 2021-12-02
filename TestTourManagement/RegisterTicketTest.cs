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
            Customer customer = new Customer()
            {
                HoTen = "Nguyen An",
                DiaChi = "Ba Ria",
                SDT = "79324432",
                CMND_Passport = "100000000"

            };
            Assert.AreEqual(true, TestFunction.RegisterTicketFucntion(foreign, customer));
        }

        [Test]
        public void Test2()
        {
            bool foreign = false;
            Customer customer = new Customer();
            Assert.AreEqual(false, TestFunction.RegisterTicketFucntion(foreign, customer));
        }

        [Test]
        public void Test3()
        {
            bool foreign = false;
            Customer customer = new Customer()
            {
                SDT = "79324432",
            };
            Assert.AreEqual(false, TestFunction.RegisterTicketFucntion(foreign, customer));
        }

        [Test]
        public void Test4()
        {
            bool foreign = false;
            Customer customer = new Customer()
            {
                HoTen = "Nguyen An",
                DiaChi = "Ba Ria"

            };
            Assert.AreEqual(false, TestFunction.RegisterTicketFucntion(foreign, customer));
        }

        [Test]
        public void Test5()
        {
            bool foreign = false;
            Customer customer = new Customer()
            {
                HoTen = "Nguyen An",
                CMND_Passport = "100000000"

            };
            Assert.AreEqual(false, TestFunction.RegisterTicketFucntion(foreign, customer));
        }

        [Test]
        public void Test6()
        {
            bool foreign = true;
            Customer customer = new Customer()
            {
                HoTen = "Nguyen An",
                DiaChi = "Ba Ria",
                SDT = "79324432",
                CMND_Passport = "100000000",
                HanVisa = new DateTime(2021, 12, 28),
                HanPassport = new DateTime(2021, 12, 28)

            };
            Assert.AreEqual(true, TestFunction.RegisterTicketFucntion(foreign, customer));
        }

        [Test]
        public void Test7()
        {
            bool foreign = true;
            Customer customer = new Customer()
            {
                HanVisa = new DateTime(2021, 10, 28),
                HanPassport = new DateTime(2021, 12, 28)

            };
            Assert.AreEqual(false, TestFunction.RegisterTicketFucntion(foreign, customer));
        }

        [Test]
        public void Test8()
        {
            bool foreign = true;
            Customer customer = new Customer()
            {
                SDT = "79324432",
                HanVisa = new DateTime(2021, 12, 28),
                HanPassport = new DateTime(2021, 10, 28)

            };
            Assert.AreEqual(false, TestFunction.RegisterTicketFucntion(foreign, customer));
        }

        [Test]
        public void Test9()
        {
            bool foreign = true;
            Customer customer = new Customer()
            {
                HoTen = "Nguyen An",
                DiaChi = "Ba Ria",
                HanVisa = new DateTime(2021, 10, 28),
                HanPassport = new DateTime(2021, 10, 28)

            };
            Assert.AreEqual(false, TestFunction.RegisterTicketFucntion(foreign, customer));
        }

        [Test]
        public void Test10()
        {
            bool foreign = true;
            Customer customer = new Customer()
            {
                HoTen = "Nguyen An",
                CMND_Passport = "100000000",
                HanVisa = new DateTime(2021, 12, 28),
                HanPassport = new DateTime(2021, 12, 28)

            };
            Assert.AreEqual(false, TestFunction.RegisterTicketFucntion(foreign, customer));
        }
    }
}
