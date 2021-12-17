using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tour;

namespace TestTourManagement
{
    public class UpdateTourTest
    {
        [Test]
        public void Test1()
        {
            tblChuyen tour = new tblChuyen()
            {
                MaLoaiChuyen = "TOUR01",
                ThoiGianKhoiHanh = new DateTime(2021, 11, 15, 11, 30, 0),
                PhuongTien = "Plane",
                GiaVe = 10000000
            };
            string message = "";
            Assert.AreEqual(true, TestFunction.UpdateTourFunction(tour, ref message), message);
        }

        [Test]
        public void Test2()
        {
            tblChuyen tour = new tblChuyen()
            {
                MaLoaiChuyen = "TOUR01",
                ThoiGianKhoiHanh = new DateTime(2021, 11, 15, 11, 30, 0),
                PhuongTien = "Plane"
            };
            string message = "";
            Assert.AreEqual(true, TestFunction.UpdateTourFunction(tour, ref message), message);
        }

        [Test]
        public void Test3()
        {
            tblChuyen tour = new tblChuyen()
            {
                MaLoaiChuyen = "TOUR02",
                ThoiGianKhoiHanh = new DateTime(2021, 11, 15, 11, 30, 0),
                PhuongTien = "Plane"
            };
            string message = "";
            Assert.AreEqual(true, TestFunction.UpdateTourFunction(tour, ref message), message);
        }

        [Test]
        public void Test4()
        {
            tblChuyen tour = new tblChuyen()
            {
                MaLoaiChuyen = "TOUR02",
                ThoiGianKhoiHanh = new DateTime(2021, 11, 15, 11, 30, 0),
                PhuongTien = "Plane",
                GiaVe = 10000000
            };
            string message = "";
            Assert.AreEqual(true, TestFunction.UpdateTourFunction(tour, ref message), message);
        }
    }
}
