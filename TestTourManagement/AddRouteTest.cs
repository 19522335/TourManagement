using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class AddRouteTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            tblTuyen route = new tblTuyen()
            {
                MaTuyen = "100",
                XuatPhat = "TPHCM",
                DiaDiem = "Ba Ria",
                TenTuyen = "TPHCM - Ba Ria",
                MaLoaiTuyen = "ROUTE01",
                ThoiGianToChuc = "1 Day 1 Night"
            };
            Assert.AreEqual(true, TestFunction.AddRouteFunction(route), "Add Route Failed");
        }

        [Test]
        public void Test4()
        {
            tblTuyen route = new tblTuyen()
            {
                MaTuyen = "101",
                XuatPhat = "TPHCM",
                DiaDiem = "Ba Ria",
                TenTuyen = "TPHCM - Ba Ria",
                MaLoaiTuyen = "ROUTE02",
                ThoiGianToChuc = "1 Day 1 Night"
            };
            Assert.AreEqual(true, TestFunction.AddRouteFunction(route), "Add Route Failed");
        }

        [Test]
        public void Test2()
        {
            tblTuyen route = new tblTuyen()
            {
                XuatPhat = "TPHCM",
                TenTuyen = "TPHCM - Ba Ria",
                MaLoaiTuyen = "ROUTE02"
            };
            Assert.AreEqual(false, TestFunction.AddRouteFunction(route), "Add Route Sucessfull");
        }

        [Test]
        public void Test3()
        {
            tblTuyen route = new tblTuyen()
            {
                MaTuyen = "101",
                DiaDiem = "Ba Ria",
                MaLoaiTuyen = "ROUTE02"
            };
            Assert.AreEqual(false, TestFunction.AddRouteFunction(route), "Add Route Sucessfull");
        }



        [Test]
        public void Test5()
        {
            tblTuyen route = new tblTuyen()
            {
                MaLoaiTuyen = "ROUTE02"
            };
            Assert.AreEqual(false, TestFunction.AddRouteFunction(route), "Add Route Sucessfull");
        }


        [Test]
        public void Test6()
        {
            tblTuyen route = new tblTuyen()
            {
                XuatPhat = "TPHCM",
                MaLoaiTuyen = "ROUTE01",
                ThoiGianToChuc = "1 Day 1 Night"
            };
            Assert.AreEqual(false, TestFunction.AddRouteFunction(route), "Add Route Sucessfull");
        }

        [Test]
        public void Test7()
        {
            tblTuyen route = new tblTuyen()
            {
                MaTuyen = "101",
                XuatPhat = "TPHCM",
                DiaDiem = "Ba Ria",
                TenTuyen = "TPHCM - Ba Ria",
                MaLoaiTuyen = "ROUTE01"
            };
            Assert.AreEqual(false, TestFunction.AddRouteFunction(route), "Add Route Sucessfull");
        }

        [Test]
        public void Test8()
        {
            tblTuyen route = new tblTuyen()
            {
                TenTuyen = "TPHCM - Ba Ria",
                MaLoaiTuyen = "ROUTE01",
                ThoiGianToChuc = "1 Day 1 Night"
            };
            Assert.AreEqual(false, TestFunction.AddRouteFunction(route), "Add Route Sucessfull");
        }

        [Test]
        public void Test9()
        {
            tblTuyen route = new tblTuyen()
            {
                MaTuyen = "4",
                MaLoaiTuyen = "ROUTE02"
            };
            Assert.AreEqual(false, TestFunction.AddRouteFunction(route), "Add Route Failed");
        }
    }
}
