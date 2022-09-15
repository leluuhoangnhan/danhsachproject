using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QL_CuaHangVatLieuXayDung;

namespace TestHoaDonBanHang
{
    [TestClass]
    public class TestHoaDonBanHang
    {
        HoaDonXuat_Test _hd;

        public HoaDonXuat_Test hd
        {
            get { return _hd; }
            set { _hd = value; }
        }

        [TestInitialize]
        public void testInitialize()
        {
            _hd = new HoaDonXuat_Test();
        }


        [TestMethod]
        public void TestTinhThanhTien_Dung()
        {
            hd.SoLuong = 100;
            hd.DonGia = 5000;

            float thanhTien_ThucTe = hd.tinhThanhTien();
            float thanhTien_MongDoi = 500000;

            Assert.AreEqual(thanhTien_ThucTe, thanhTien_MongDoi, "Dung");
        }

        [TestMethod]
        public void TestTinhThanhTien_Sai()
        {
            hd.SoLuong = 100;
            hd.DonGia = 5000;

            float thanhTien_ThucTe = hd.tinhThanhTien();
            float thanhTien_MongDoi = 700000;

            Assert.AreEqual(thanhTien_ThucTe, thanhTien_MongDoi, "Sai");
        }

    }
}
