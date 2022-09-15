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
    public partial class frmTaoTaiKhoan : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
            loadCboNhom();
        }

        public void loadCboNhom()
        {
            var nhom = from n in data.PHANQUYENs select n;
            foreach (var item in nhom)
                cboNhom.Items.Add(item.NHOM);
            cboNhom.SelectedIndex = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Thoát khỏi from hiện tại?!", "Thông báo", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {//btn Tiep tục
            frmQLNhanVien.msnv = 0;
            try
            {
                if (txtTenDN.Text.Length == 0)
                {
                    MessageBox.Show("Không được để trống Tên Tài Khoản", "Thông báo");
                    return;
                }
                else if (txtMatKhau.Text.Length == 0)
                {
                    MessageBox.Show("Không được để trống mật khẩu", "Thông báo");
                    return;
                }
                var ktra_tk = (from tk1 in data.TAIKHOANs where tk1.TENTK == txtTenDN.Text select tk1).FirstOrDefault();
                if (ktra_tk != null)
                {
                    MessageBox.Show("Đã tồn tại tên tài khoản này. Chọn một tên mới để tiếp tục", "Thông báo");
                    txtTenDN.Focus();
                }
                TAIKHOAN tk = new TAIKHOAN();
                tk.TENTK = txtTenDN.Text;
                tk.MATKHAU = txtMatKhau.Text;
                tk.NHOM = cboNhom.SelectedItem.ToString();
                data.TAIKHOANs.InsertOnSubmit(tk);
                data.SubmitChanges();
                MessageBox.Show("Thêm tài khoản mới thành công?!", "Thông báo");
                frmCTNhanVien themNV = new frmCTNhanVien();
                themNV.Show();
            }
            catch (Exception)
            {
                //MessageBox.Show("Đã tồn tại tên tài khoản này. Chọn một tên mới để tiếp tục", "Thông báo");
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else txtMatKhau.UseSystemPasswordChar = true;
        }
    }
}
