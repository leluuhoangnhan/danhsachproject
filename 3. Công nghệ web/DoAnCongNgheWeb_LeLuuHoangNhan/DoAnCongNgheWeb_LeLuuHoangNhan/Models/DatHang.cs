using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnCongNgheWeb_LeLuuHoangNhan.Models
{
    public class SanPham
    {
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string moTa { get; set; }
        public float gia { get; set; }
        public int soLuong { get; set; }
        public string maLoai { get; set; }
        public string maNSX { get; set; }
        public string img_sp { get; set; }
        public string ds_hinh { get; set; }
        DB_QLSHOPMYPHAMDataContext dt = new DB_QLSHOPMYPHAMDataContext();

        public double tinhThanhTien()
        {
            return soLuong * gia;
        }

        public SanPham(string ma)
        {
            SANPHAM sp = dt.SANPHAMs.FirstOrDefault(t => t.MASP == ma);

            if (sp != null)
            {
                maSP = sp.MASP;
                tenSP = sp.TENSP;
                moTa = sp.MOTA;
                gia = float.Parse(sp.GIA.ToString());
                soLuong = 1;
                maLoai = sp.MALOAI;
                maNSX = sp.MANSX;
                img_sp = sp.IMG_SP;
                ds_hinh = sp.DS_HINH;
            }
        }
    }

    public class GioHang
    {
        public List<SanPham> lsp;
        public GioHang()
        {
            lsp = new List<SanPham>();
        }
        public GioHang(List<SanPham> lspNew)
        {
            lsp = lspNew;
        }

        public int demSoMatHang()
        {
            return lsp.Count();
        }

        public int tinhTongSoLuongMatHangCanMua()
        {
            return lsp.Sum(t => t.soLuong);
        }

        public double tinhTongTien()
        {
            return lsp.Sum(t => t.tinhThanhTien());
        }

        public int themSPVaoGio(string maSP)
        {
            SanPham sp = lsp.Find(t => t.maSP == maSP);
            if (sp == null)
            {
                SanPham sanPham = new SanPham(maSP);
                if (sanPham == null)
                    return -1;
                lsp.Add(sanPham);
            }
            else
                sp.soLuong++;

            return 1;
        }

        public int giamSoLuongSPTrongGio(string maSP)
        {
            SanPham sp = lsp.Find(t => t.maSP == maSP);
            if (sp == null)
            {
                return -1;
            }
            else if(sp.soLuong > 1)
            {
                sp.soLuong--;
            }
            else
            {
                xoaSPRaGio(maSP);
            }
            return 1;
        }

        public int xoaSPRaGio(string maSP)
        {
            SanPham sp = lsp.Find(t => t.maSP == maSP);
            if (sp == null)
            {
                return -1;
            }
            else
            {
                lsp.Remove(sp);
            }
            return 1;
        }
    }
}