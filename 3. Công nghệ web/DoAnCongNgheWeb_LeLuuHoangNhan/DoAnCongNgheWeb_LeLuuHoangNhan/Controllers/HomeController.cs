using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnCongNgheWeb_LeLuuHoangNhan.Models;

namespace DoAnCongNgheWeb_LeLuuHoangNhan.Controllers
{
    public class HomeController : Controller
    {
        DB_QLSHOPMYPHAMDataContext dt = new DB_QLSHOPMYPHAMDataContext();

        public ActionResult Home()
        {
            List<SANPHAM> sp = dt.SANPHAMs.Take(16).ToList();

            return View(sp);
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult HangMoiVe()
        {
            List<SANPHAM> sp = dt.SANPHAMs.OrderBy(t => t.SOLUONG).Take(16).ToList();

            return View("Home", sp);
        }

        public ActionResult TimKiem(FormCollection col)
        {
            List<SANPHAM> sp = dt.SANPHAMs.Where(t => t.TENSP.Contains(col["timKiem"])).ToList();

            return View("Home", sp);
        }

        public ActionResult HienThiChiTietSP(string masp)
        {
            SANPHAM sp = dt.SANPHAMs.FirstOrDefault(t => t.MASP == masp);

            List<SANPHAM> spCungLoai = dt.SANPHAMs.Where(t => t.MALOAI == sp.MALOAI).Take(5).ToList();
            ViewBag.spCungLoai = spCungLoai;

            List<SANPHAM> spCungNSX = dt.SANPHAMs.Where(t => t.MANSX == sp.MANSX).Take(5).ToList();
            ViewBag.spCungNSX = spCungNSX;

            return View(sp);
        }

        public ActionResult HienThiMenuLoaiSP()
        {
            List<LOAI> lsp = dt.LOAIs.ToList();

            return PartialView(lsp);
        }

        public ActionResult HienThiSPCungLoai(string maLoai)
        {
            List<SANPHAM> sp = dt.SANPHAMs.Where(t =>t.MALOAI == maLoai).ToList();

            return View("Home", sp);
        }

        public ActionResult HienThiGioHang_TaiKhoan()
        {
            return PartialView();
        }

        public ActionResult DangNhap()
        {
            string t = Session["thongBao"] as string;
            Session["thongBao"] = t;

            string t1 = Session["tenDangNhap"] as string;
            Session["tenDangNhap"] = t1;

            string t2 = Session["maKH"] as string;
            Session["maKH"] = t2;
            return View();
        }

        public ActionResult XuLyDangNhap(FormCollection col)
        {
            KHACHHANG kh = dt.KHACHHANGs.FirstOrDefault(t => t.MAKH == col["maKH"].ToString() && t.MATKHAU == col["matKhau"].ToString());
            if(kh == null)
            {
                Session["thongBao"] = "Tên đăng nhập hoặc mật khẩu không chính xác!";
                return Redirect("DangNhap");
            }

            Session["tenDangNhap"] = kh.TENKH.ToString();
            Session["maKH"] = kh.MAKH.ToString();
            return Redirect("DangNhap");
        }

        public ActionResult DangKy()
        {
            string t = Session["thongBao"] as string;
            Session["thongBao"] = t;
            return View();
        }

        public ActionResult XuLyDangKy(KHACHHANG kh, HttpPostedFileBase hinhAnh, FormCollection col)
        {
            if(kh.MAKH == null || kh.TENKH == null || kh.SDT == null || kh.EMAIL == null || kh.DIACHI == null || kh.MATKHAU == null || col["xacNhanMatKhau"] == null || kh.NGAYSINH == null) //Check bỏ trống
            {
                Session["thongBao"] = "Không được bỏ trống các mục trên!";
                return Redirect("DangKy");
            }

            KHACHHANG khach = dt.KHACHHANGs.FirstOrDefault(t => t.MAKH == kh.MAKH);
            if(khach != null) //Check tài khoản tồn tại
            {
                Session["thongBao"] = "Tài khoản đã tồn tại!";
                return Redirect("DangKy");
            }

            if (DateTime.Compare((DateTime)kh.NGAYSINH, DateTime.Now) > 0) //Check ngày sinh hợp lệ
            {
                Session["thongBao"] = "Ngày sinh phải bé hơn hoặc bằng ngày hiện tại!";
                return Redirect("DangKy");
            }

            if (!kh.MATKHAU.Equals(col["xacNhanMatKhau"].ToString())) //Check mật khẩu trùng khớp
            {
                Session["thongBao"] = "Mật khẩu không trùng khớp";
                return Redirect("DangKy");
            }

            if (col["rd_gioiTinh"].ToString() == "1")
            {
                kh.GIOITINH = "Nam";
            }
            else
            {
                kh.GIOITINH = "Nữ";
            }

            if(hinhAnh != null)
            {
                kh.IMG_KH = hinhAnh.FileName;
                hinhAnh.SaveAs(Server.MapPath("/Content/img/" + hinhAnh.FileName));
            }

            kh.LOAIKH = "Thông thường";
            kh.MATAIKHOAN_LOGIN = kh.MAKH;

            dt.KHACHHANGs.InsertOnSubmit(kh);
            dt.SubmitChanges();
            Session["thongBao"] = "Đăng ký tài khoản thành công!";

            return Redirect("DangNhap");
        }

        public ActionResult DangXuat()
        {
            Session["tenDangNhap"] = null;
            return Redirect("Home");
        }

        public ActionResult ChonMua(string maSP)
        {
            GioHang gh = Session["gio"] as GioHang;
            if (gh == null)
            {
                gh = new GioHang();
            }
            gh.themSPVaoGio(maSP);
            Session["gio"] = gh;

            return Redirect("Home");
        }

        public ActionResult HienThiGioHang()
        {
            GioHang gh = Session["gio"] as GioHang;
            if (gh == null)
            {
                return Redirect("Home");
            }

            return View(gh.lsp);
        }

        public ActionResult MuaThem(string maSP)
        {
            GioHang gh = Session["gio"] as GioHang;
            gh.themSPVaoGio(maSP);

            return Redirect("HienThiGioHang");
        }

        public ActionResult GiamBot(string maSP)
        {
            GioHang gh = Session["gio"] as GioHang;
            gh.giamSoLuongSPTrongGio(maSP);

            return Redirect("HienThiGioHang");
        }

        public ActionResult XoaSPRaGio(string maSP)
        {
            GioHang gh = Session["gio"] as GioHang;
            gh.xoaSPRaGio(maSP);

            return Redirect("HienThiGioHang");
        }

        public ActionResult DatHang()
        {
            if (Session["maKH"] == null)
            {
                return Redirect("DangNhap");
            }
            KHACHHANG kh = dt.KHACHHANGs.FirstOrDefault(t => t.MAKH.Equals(Session["maKH"].ToString()));
            if (kh == null)
            {
                return Redirect("DangNhap");
            }

            string t1 = Session["thongBaoDatHang"] as string;
            Session["thongBaoDatHang"] = t1;

            GioHang gh = Session["gio"] as GioHang;
            if (gh == null && Session["thongBaoDatHang"] == null)
            {
                return Redirect("Home");
            }
            else if(gh != null)
            {
                Session["thongBaoDatHang"] = null;
            }

            return View(kh);
        }

        public ActionResult XacNhanDatHang()
        {
            GioHang gh = Session["gio"] as GioHang;
            foreach(SanPham item in gh.lsp)
            {
                DONHANG dh = new DONHANG();
                dh.MAKH = Session["maKH"] as string;
                dh.MASP_DATMUA = item.maSP;
                dh.NGAYDATMUA = DateTime.Now.Date;
                dh.SOLUONG = item.soLuong;
                dh.GIA = item.gia * item.soLuong;

                dt.DONHANGs.InsertOnSubmit(dh);
                dt.SubmitChanges();
            }

            Session["gio"] = null;
            Session["thongBaoDatHang"] = "Đặt hàng thành công!";

            return Redirect("DatHang");
        }

        public ActionResult LichSuMuaHang(string chon, string maKH)
        {
            List<DONHANG> ldh;
            if (chon == "Chờ duyệt")
            {
                ldh = dt.DONHANGs.Where(t => t.MAKH == maKH && t.NGAYGIAOHANG == null).ToList();
            }
            else if (chon == "Chờ giao")
            {
                ldh = dt.DONHANGs.Where(t => t.MAKH == maKH && DateTime.Compare(t.NGAYGIAOHANG.Value.Date, t.NGAYDATMUA.Value.Date) == 0).ToList();
            }
            else if (chon == "Đã giao")
            {
                ldh = dt.DONHANGs.Where(t => t.MAKH == maKH && t.NGAYGIAOHANG != null && DateTime.Compare(t.NGAYGIAOHANG.Value.Date, t.NGAYDATMUA.Value.Date) > 0).ToList();
            }
            else
            {
                ldh = dt.DONHANGs.Where(t => t.MAKH == maKH).ToList();
            }

            return View(ldh);
        }

    }
}
