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
    public partial class frmKhachHang : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain(true);
            main.Show();
            this.Visible = false;
        }

        private void refreshForm()
        {
            var khachhangs = from kh in data.KHACHHANGs select kh;
            dataGridView1.DataSource = khachhangs;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            var khachhangs = from kh in data.KHACHHANGs select kh;
            dataGridView1.DataSource = khachhangs;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                txtMaKH.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                txtTenKH.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                txtCMND.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnOk.Visible = true;
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                KHACHHANG kh = new KHACHHANG();
                kh.TENKH = txtTenKH.Text;
                kh.SDT = txtSDT.Text;
                kh.CMND = txtCMND.Text;
                kh.DIACHI = txtDiaChi.Text;
                data.KHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                refreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnOk.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int makh = int.Parse(txtMaKH.Text);
                KHACHHANG kh = data.KHACHHANGs.Where(n => n.MAKH == makh).FirstOrDefault();
                kh.TENKH = txtTenKH.Text;
                kh.SDT = txtSDT.Text;
                kh.CMND = txtCMND.Text;
                kh.DIACHI = txtDiaChi.Text;
                data.SubmitChanges();
                MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo");
                refreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    int makh = int.Parse(txtMaKH.Text);
                    KHACHHANG kh = data.KHACHHANGs.Where(n => n.MAKH == makh).FirstOrDefault();
                    data.KHACHHANGs.DeleteOnSubmit(kh);
                    data.SubmitChanges();
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
                    refreshForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string tenkh = txtTimKiem.Text.Trim();
                var filter = data.KHACHHANGs.Where(n => n.TENKH.Contains(tenkh));
                dataGridView1.DataSource = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
