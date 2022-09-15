using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangVatLieuXayDung
{
    public class HoaDonXuat_Test
    {
        String maHD;
        String tenKH;
        String tenNV;
        Date ngayLap;
        String tenSP;
        float donGia;
        String donViTinh;
        int soLuong;
        float thanhTien;

        public HoaDonXuat_Test()
        {

        }

        public HoaDonXuat_Test(String maHD, String tenKH, String tenNV, Date ngayLap, String tenSP, float donGia, String donViTinh, int soLuong)
        {
            this.maHD = maHD;
            this.tenKH = tenKH;
            this.tenNV = tenNV;
            this.ngayLap = ngayLap;
            this.tenSP = tenSP;
            this.donGia = donGia;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
        }


        public String MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public String TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public String TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public Date NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        public String TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public String DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public float tinhThanhTien()
        {
            return soLuong * donGia;
        }

    }

    public class Date
    {
        int day;
        int month;
        int year;

        public Date()
        {

        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Day
        {
          get { return day; }
          set { day = value; }
        }

        public int Month
        {
          get { return month; }
          set { month = value; }
        }

        public int Year
        {
          get { return year; }
          set { year = value; }
        }

        public String toString()
        {
            return day + "/" + month + "/" + year;
        }

    }
    
}
