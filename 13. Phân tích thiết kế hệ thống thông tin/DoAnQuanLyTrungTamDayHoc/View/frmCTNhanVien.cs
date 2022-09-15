using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyTrungTamDayHoc.Model;

namespace DoAnQuanLyTrungTamDayHoc
{
    public partial class frmCTNhanVien : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        public frmCTNhanVien()
        {
            InitializeComponent();
            setting();
            if (frmQLNhanVien.msnv == 0)
            {
                            Update_Enable();
                            reset(); 
            }                       
            else loadData(frmQLNhanVien.msnv);
        }

        public void setting()
        {
            txtHoTen.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtHSL.Enabled = false;
            txtKinhNghiem.Enabled = false;
            txtLuongCB.Enabled = false;
            txtTrinhDo.Enabled = false;
            txtTP_Tinh.Enabled = false;
            txtQuanHuyen.Enabled = false;
            txtPhuongXa.Enabled = false;
            txtDuong.Enabled = false;
            txtChuCVu.Enabled = false;
            txtTenTK.Enabled = false;
            txtMatKhau.Enabled = false;
        }

        public void loadData(int manv)
        {
            var nv = (from nv1 in data.NHANVIENs
                      where nv1.MSNV == manv
                      select nv1).First();
            txtHoTen.Text = nv.TENNV.ToString();
            txtLuongCB.Text = nv.LUONGCUNG.ToString();
            txtHSL.Text = nv.HSL.ToString();
            txtKinhNghiem.Text = nv.KINHNGHIEM.ToString();
            txtTrinhDo.Text = nv.TRINHDO.ToString();
            dtNgaySinh.Value = DateTime.Parse(nv.NGAYSINH.ToString());
            var cv = (from cv1 in data.CHUCVUs where cv1.MACV == int.Parse(nv.CHUCVU.ToString()) select cv1).First();
            txtChuCVu.Text = cv.TENCV.ToString();
            txtTenTK.Text = nv.TENTK.ToString();
            txtTP_Tinh.Text = nv.TINH_THANHPHO.ToString();
            txtQuanHuyen.Text = nv.QUAN_HUYEN.ToString();
            txtPhuongXa.Text = nv.PHUONG_XA.ToString();
            txtDuong.Text = nv.DUONG.ToString();
            var tk = (from taikhoan in data.TAIKHOANs where taikhoan.TENTK == txtTenTK.Text select taikhoan).First();
            txtMatKhau.Text = tk.MATKHAU.ToString();
            if (nv.HINHANH != null)
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\img\\" + nv.HINHANH);
            else
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\img\\" + "icon_nguoi.png");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Update_Enable()
        {
            txtHoTen.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtHSL.Enabled = true;
            txtKinhNghiem.Enabled = true;
            txtLuongCB.Enabled = true;
            txtTrinhDo.Enabled = true;
            txtTP_Tinh.Enabled = true;
            txtQuanHuyen.Enabled = true;
            txtPhuongXa.Enabled = true;
            txtDuong.Enabled = true;
            txtChuCVu.Enabled = true;
        }

        public void reset()
        {
            txtHoTen.Clear();
            dtNgaySinh.Value = DateTime.Now;
            txtHSL.Clear();
            txtKinhNghiem.Clear();
            txtLuongCB.Clear();
            txtTrinhDo.Clear();
            txtTP_Tinh.Clear();
            txtQuanHuyen.Clear();
            txtPhuongXa.Clear();
            txtDuong.Clear();
            txtChuCVu.Clear();

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Update_Enable();
      
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (frmQLNhanVien.msnv == 0)
                ThemNV();
            else
                SuaNV();
           
        }

        public void SuaNV()
        {
            NHANVIEN nv = (data.NHANVIENs.Where(t => t.MSNV == frmQLNhanVien.msnv)).FirstOrDefault();
            nv.TENNV = txtHoTen.Text;
            nv.HSL = double.Parse(txtHSL.Text);
            nv.NGAYSINH = dtNgaySinh.Value;
            nv.KINHNGHIEM = int.Parse(txtKinhNghiem.Text);
            nv.LUONGCUNG = double.Parse(txtLuongCB.Text);
            nv.TRINHDO = int.Parse(txtTrinhDo.Text);
            nv.TINH_THANHPHO = txtTP_Tinh.Text;
            nv.QUAN_HUYEN = txtQuanHuyen.Text;
            nv.PHUONG_XA = txtPhuongXa.Text;
            nv.DUONG = txtDuong.Text;
            var cv = (from cv1 in data.CHUCVUs where cv1.TENCV == txtChuCVu.Text select cv1).First();
            nv.CHUCVU = int.Parse(cv.MACV.ToString());

            data.SubmitChanges();
            loadData(frmQLNhanVien.msnv);
        }

        public void ThemNV()
        {
            var tk = (from tk1 in data.TAIKHOANs select tk1).LastOrDefault();
            txtTenTK.Text = tk.TENTK.ToString();
            txtMatKhau.Text = tk.MATKHAU.ToString();


            NHANVIEN nv = new NHANVIEN();
            nv.TENNV = txtHoTen.Text;
            nv.HSL = double.Parse(txtHSL.Text);
            nv.NGAYSINH = dtNgaySinh.Value;
            nv.KINHNGHIEM = int.Parse(txtKinhNghiem.Text);
            nv.LUONGCUNG = double.Parse(txtLuongCB.Text);
            nv.TRINHDO = int.Parse(txtTrinhDo.Text);
            nv.TINH_THANHPHO = txtTP_Tinh.Text;
            nv.QUAN_HUYEN = txtQuanHuyen.Text;
            nv.PHUONG_XA = txtPhuongXa.Text;
            nv.DUONG = txtDuong.Text;
            nv.HINHANH = "icon_nguoi.png";
            data.NHANVIENs.InsertOnSubmit(nv);
            data.SubmitChanges();
            this.Close();
        }
    }
}
