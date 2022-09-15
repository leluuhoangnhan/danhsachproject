using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnCongNgheWeb_LeLuuHoangNhan.Models;

namespace DoAnCongNgheWeb_LeLuuHoangNhan.Controllers
{
    public class AdminController : Controller
    {
        DB_QLSHOPMYPHAMDataContext dt = new DB_QLSHOPMYPHAMDataContext();

        public ActionResult Home()
        {

            return View();
        }

        public ActionResult ThemSPMoi()
        {
            if (Session["nhanVien"] == null)
            {
                return Redirect("DangNhap");
            }

            ViewBag.MALOAI = new SelectList(dt.LOAIs.ToList(), "MALOAI", "TENLOAI");
            ViewBag.MANSX = new SelectList(dt.NHASANXUATs.ToList(), "MANSX", "TENNSX");

            string t = Session["thongBaoThemSP"] as string;
            Session["thongBaoThemSP"] = t;

            return View();
        }

        public ActionResult XuLyThemSPMoi(SANPHAM sp, HttpPostedFileBase hinhAnh)
        {
            if (sp.MASP == null || sp.TENSP == null || sp.MOTA == null || sp.GIA == null || sp.SOLUONG == null) //Check bỏ trống
            {
                Session["thongBaoThemSP"] = "Không được bỏ trống các mục trên!";
                return Redirect("ThemSPMoi");
            }

            SANPHAM sanPham = dt.SANPHAMs.FirstOrDefault(t => t.MASP == sp.MASP);
            if(sanPham != null) //Kiểm tra tồn tại
            {
                Session["thongBaoThemSP"] = "Sản phẩm cần thêm đã tồn tại!";
                return Redirect("ThemSPMoi");
            }

            if(hinhAnh != null) //Kiểm tra có chọn hình không
            {
                sp.IMG_SP = hinhAnh.FileName;
                hinhAnh.SaveAs(Server.MapPath("/Content/img/" + hinhAnh.FileName));
            }

            dt.SANPHAMs.InsertOnSubmit(sp);
            dt.SubmitChanges();

            Session["thongBaoThemSP"] = "Thêm sản phẩm thành công!";
            return Redirect("ThemSPMoi");
        }

        public ActionResult HienThiThongTinDangNhap()
        {
            return PartialView();
        }

        public ActionResult DangNhap()
        {
            string t = Session["thongBaoDangNhap_Admin"] as string;
            Session["thongBaoDangNhap_Admin"] = t;

            var nv = Session["nhanVien"] as NHANVIEN;
            Session["nhanVien"] = nv;

            return View();
        }

        public ActionResult XuLyDangNhap(FormCollection col)
        {
            NHANVIEN nv = dt.NHANVIENs.FirstOrDefault(t => t.MANV == col["maNV"].ToString() && t.MATKHAU_NV == col["matKhau_NV"].ToString());
            if (nv == null)
            {
                Session["thongBaoDangNhap_Admin"] = "Tên đăng nhập hoặc mật khẩu không chính xác!";
                return Redirect("DangNhap");
            }

            Session["nhanVien"] = nv;
            return Redirect("DangNhap");
        }

        public ActionResult DangXuat()
        {
            Session["nhanVien"] = null;
            return Redirect("Home");
        }

        public ActionResult NhapHang()
        {
            if (Session["nhanVien"] == null)
            {
                return Redirect("DangNhap");
            }

            List<SANPHAM> lsp = dt.SANPHAMs.Take(20).ToList();
            ViewBag.MASP = new SelectList(dt.SANPHAMs.ToList(), "MASP", "TENSP");

            return View(lsp);
        }

        public ActionResult XuLyNhapHang(SANPHAM sp, FormCollection col)
        {
            SANPHAM sanPham = dt.SANPHAMs.FirstOrDefault(t => t.MASP == sp.MASP);
            if (col["soLuongNhap"] == "" || sanPham == null)
            {
                return Redirect("NhapHang");
            }

            int soLuongNhap = int.Parse(col["soLuongNhap"].ToString());
            if(soLuongNhap > 0)
            {
                sanPham.SOLUONG += int.Parse(col["soLuongNhap"].ToString());
                dt.SubmitChanges();
            }

            return Redirect("NhapHang");
        }

        public ActionResult DonHang()
        {
            if (Session["nhanVien"] == null)
            {
                return Redirect("DangNhap");
            }

            List<DONHANG> ldh = dt.DONHANGs.ToList();
 
            return View(ldh);
        }

        public ActionResult XuLyDonHang(FormCollection col)
        {
            if (col["cb_giaoDon"] != null)
            {
                DONHANG dh = dt.DONHANGs.FirstOrDefault(t => t.MADH == int.Parse(col["cb_giaoDon"].ToString()));
                dh.NGAYGIAOHANG = DateTime.Now.Date;

                dt.SubmitChanges();
                return Redirect("DonHang");
            }
            else if (col["cb_duyetDon"] != null)
            {
                DONHANG dh = dt.DONHANGs.FirstOrDefault(t => t.MADH == int.Parse(col["cb_duyetDon"].ToString()));
                dh.NGAYGIAOHANG = dh.NGAYDATMUA;

                dt.SubmitChanges();
            }

            return Redirect("DonHang");
        }

        public ActionResult ThongKeDoanhThu()
        {
            if (Session["nhanVien"] == null)
            {
                return Redirect("DangNhap");
            }

            List<DONHANG> ldh = dt.DONHANGs.Where(t => t.NGAYGIAOHANG != null).ToList();

            return View(ldh);
        }

        public ActionResult XuLyThongKe(DONHANG dh, FormCollection col)
        {
            List<DONHANG> ldh = dt.DONHANGs.Where(t => t.NGAYGIAOHANG != null).ToList();

            if (col["cb_nam"] != null && dh.NGAYGIAOHANG != null)
            {
                int year = dh.NGAYGIAOHANG.Value.Year;

                ldh = dt.DONHANGs.Where(t => t.NGAYGIAOHANG.Value.Date.Year == year).ToList();
            }
            else if (col["cb_thang"] != null && dh.NGAYGIAOHANG != null)
            {
                int month = dh.NGAYGIAOHANG.Value.Month;

                ldh = dt.DONHANGs.Where(t => t.NGAYGIAOHANG.Value.Date.Month == month).ToList();
            }
            else if (col["cb_ngay"] != null && dh.NGAYGIAOHANG != null)
            {
                int day = dh.NGAYGIAOHANG.Value.Day;

                ldh = dt.DONHANGs.Where(t => t.NGAYGIAOHANG.Value.Date.Day == day).ToList();
            }

            return View("ThongKeDoanhThu", ldh);
        }


    }
}
