using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourDuLich
{
    public partial class frmTaiKhoan : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if(txtDN.Text==""||txtMatKhau.Text =="")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                return;
            }
            else
            {
                TAIKHOAN tk = (from t in data.TAIKHOANs where t.TENDN == txtDN.Text && t.MATKHAU == txtMatKhau.Text select t).SingleOrDefault();
                if(tk != null)
                {
                    bool check = true;
                    frmMain main = new frmMain(check);
                    this.Close();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain(false);
            this.Visible = false;
            main.Show();
        }
    }
}
