using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class ChekcRegisterTest
    {
        [Test]
        public void Test1()
        {
            string firstname = "Nguyen";
            string surname = "An";
            string address = "Ba Ria";
            string telephone = "790399221";
            string email = "19522074@gm.uit.edu.vn";
            string idcard = "100000000";
            Assert.AreEqual(true, TestFunction.CheckRegisterTicketFunction(firstname, surname, address, telephone, email, idcard));
        }

        [Test]
        public void Test2()
        {
            string firstname = "Nguyen";
            string surname = "";
            string address = "";
            string telephone = "1";
            string email = "";
            string idcard = "";
            Assert.AreEqual(false, TestFunction.CheckRegisterTicketFunction(firstname, surname, address, telephone, email, idcard));
        }

        [Test]
        public void Test3()
        {
            string firstname = "";
            string surname = "";
            string address = "";
            string telephone = "";
            string email = "1";
            string idcard = "1";
            Assert.AreEqual(false, TestFunction.CheckRegisterTicketFunction(firstname, surname, address, telephone, email, idcard));
        }

        [Test]
        public void Test4()
        {
            string firstname = "";
            string surname = "An";
            string address = "Ba Ria";
            string telephone = "1";
            string email = "19522074@gm.uit.edu.vn";
            string idcard = "1";
            Assert.AreEqual(false, TestFunction.CheckRegisterTicketFunction(firstname, surname, address, telephone, email, idcard));
        }

        [Test]
        public void Test5()
        {
            string firstname = "Nguyen";
            string surname = "An";
            string address = "";
            string telephone = "1";
            string email = "";
            string idcard = "1";
            Assert.AreEqual(false, TestFunction.CheckRegisterTicketFunction(firstname, surname, address, telephone, email, idcard));
        }

        [Test]
        public void Test6()
        {
            string firstname = "";
            string surname = "";
            string address = "Ba Ria";
            string telephone = "";
            string email = "19522074@gm.uit.edu.vn";
            string idcard = "100000000";
            Assert.AreEqual(false, TestFunction.CheckRegisterTicketFunction(firstname, surname, address, telephone, email, idcard));
        }

        [Test]
        public void Test7()
        {
            string firstname = "";
            string surname = "An";
            string address = "";
            string telephone = "";
            string email = "19522074@gm.uit.edu.vn";
            string idcard = "";
            Assert.AreEqual(false, TestFunction.CheckRegisterTicketFunction(firstname, surname, address, telephone, email, idcard));
        }

        [Test]
        public void Test8()
        {
            string firstname = "Nguyen";
            string surname = "An";
            string address = "Ba Ria";
            string telephone = "790399221";
            string email = "19522074@gm.uit.edu.vn";
            string idcard = "";
            Assert.AreEqual(false, TestFunction.CheckRegisterTicketFunction(firstname, surname, address, telephone, email, idcard));
        }

        [Test]
        public void Test9()
        {
            string firstname = "Nguyen";
            string surname = "";
            string address = "";
            string telephone = "";
            string email = "";
            string idcard = "1";
            Assert.AreEqual(false, TestFunction.CheckRegisterTicketFunction(firstname, surname, address, telephone, email, idcard));
        }

        [Test]
        public void Test10()
        {
            string firstname = "Nguyen";
            string surname = "An";
            string address = "";
            string telephone = "790399221";
            string email = "19522074@gm.uit.edu.vn";
            string idcard = "100000000";
            Assert.AreEqual(false, TestFunction.CheckRegisterTicketFunction(firstname, surname, address, telephone, email, idcard));
        }
    }
}
