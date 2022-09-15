using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangVatLieuXayDung
{
    public partial class DangNhap : Form
    {
        XuLyDuLieu xldl = new XuLyDuLieu();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {           
            string tk = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;
            try
            {
                xldl.DangNhap("Select * from NHANVIEN where TAIKHOAN='" + tk + "' and MATKHAU='" + mk + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }      
        }

    }
}
