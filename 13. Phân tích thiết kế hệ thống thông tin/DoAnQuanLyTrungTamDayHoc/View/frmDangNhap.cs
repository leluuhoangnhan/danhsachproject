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
    public partial class frmDangNhap : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public static TAIKHOAN taiKhoan;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            xuLyDangNhap();
        }

        public void xuLyDangNhap()
        {
            if(txtTenTK.Text.Length > 0 && txtMatKhau.Text.Length > 0)
            {
                TAIKHOAN tk = db.TAIKHOANs.Where(p => p.TENTK == txtTenTK.Text && p.MATKHAU == txtMatKhau.Text).FirstOrDefault();
                if(tk != null)
                {
                    taiKhoan = tk;

                    frmMain t = new frmMain();
                    this.Visible = false;
                    t.Show();
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại tên đăng nhập và mật khẩu!");
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập hoặc mật khẩu!");
            }
        }
    }
}
