using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class AddTourTest
    {

        [Test]
        public void Test1()
        {
            tblChuyen tour = new tblChuyen()
            {
                MaChuyen = "100",
                MaLoaiChuyen = "TOUR01",
                ThoiGianKhoiHanh = new DateTime(2021, 11, 15, 13, 30, 0),
                PhuongTien = "Passenger Car",
                GiaVe = 10000000
            };
            Assert.AreEqual(true, TestFunction.AddTourFunction(tour));
        }

        [Test]
        public void Test6()
        {
            tblChuyen tour = new tblChuyen()
            {
                MaChuyen = "101",
                MaLoaiChuyen = "TOUR02",
                ThoiGianKhoiHanh = new DateTime(2021, 11, 15, 13, 30, 0),
                PhuongTien = "Passenger Car",
                GiaVe = 10000000
            };
            Assert.AreEqual(true, TestFunction.AddTourFunction(tour));
        }


        [Test]
        public void Test2()
        {
            tblChuyen tour = new tblChuyen()
            {
                MaLoaiChuyen = "TOUR02"
            };
            Assert.AreEqual(false, TestFunction.AddTourFunction(tour));
        }

        [Test]
        public void Test3()
        {
            tblChuyen tour = new tblChuyen()
            {
                MaLoaiChuyen = "TOUR02",
                PhuongTien = "Passenger Car"
            };
            Assert.AreEqual(false, TestFunction.AddTourFunction(tour));
        }

        [Test]
        public void Test4()
        {
            tblChuyen tour = new tblChuyen()
            {
                MaLoaiChuyen = "TOUR01",
                GiaVe = 10000000
            };
            Assert.AreEqual(false, TestFunction.AddTourFunction(tour));
        }

        [Test]
        public void Test5()
        {
            tblChuyen tour = new tblChuyen()
            {
                MaChuyen = "101",
                MaLoaiChuyen = "TOUR02",
                ThoiGianKhoiHanh = new DateTime(2021, 11, 15, 13, 30, 0),
                GiaVe = 10000000
            };
            Assert.AreEqual(false, TestFunction.AddTourFunction(tour));
        }


    }
}
