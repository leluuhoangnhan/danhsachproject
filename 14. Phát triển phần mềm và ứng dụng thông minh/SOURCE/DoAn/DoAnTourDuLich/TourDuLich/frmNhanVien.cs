using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace TourDuLich
{
    public partial class frmNhanVien : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        bool open = false;

        public frmNhanVien()
        {
            InitializeComponent();
            cboGioiTinh.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (open)
            {
                panel1.Visible = false;
                open = false;
            }
            else
            {
                panel1.Visible = true;
                open = true;
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            var nv = from nv2 in data.NHANVIENs select new { nv2.MANV, nv2.TENNV, nv2.LUONGCB, nv2.HINHANH };
            dataGridView1.DataSource = nv;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                txtMaNV.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                txtTenNV.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                txtLuongCB.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                if (dataGridView1.Rows[rowindex].Cells[3].Value != null)
                {
                    string tenhinh = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\img\\" + tenhinh);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {


        }

        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain(true);
            main.Show();
            this.Visible = false;
        }

        private void lbl_chonAnh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                nhapHinhAnh();
                luuHinhAnh(lblUrl.Text.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void nhapHinhAnh()
        {
            //BMP, GIF, JPEG, EXIF, PNG và TIFF, ICO...
            openFileDialog1.Filter = "All Image (*.jpg)|*.jpg|All Image (*.png)|*.png|All Image (*.gif)|*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName.ToString());

                string[] name = openFileDialog1.FileName.Split('\\');
                string tenFile = name[name.Length - 1].ToString().Trim();

                lblUrl.Text = tenFile;
            }
        }

        public void luuHinhAnh(string tenFile)
        {
            bool kt = File.Exists(Application.StartupPath + "\\img\\" + tenFile);
            if (kt == false)
                pictureBox1.Image.Save(Application.StartupPath + "\\img\\" + tenFile, ImageFormat.Png);
        }

        private void refreshForm()
        {
            var nv = from nv2 in data.NHANVIENs select new { nv2.MANV, nv2.TENNV, nv2.LUONGCB, nv2.HINHANH };
            dataGridView1.DataSource = nv;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtTenNV.Text = "";
            txtLuongCB.Text = "";
            pictureBox1.Image = null;
            dtp_ngaysinh.Value = DateTime.Now;
            txtSDT.Text = "";
            txtCMND.Text = "";
            btnOk.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (checkKhoaNgoai(txtSDT.Text))
            {
                try
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.TENNV = txtTenNV.Text;
                    nv.LUONGCB = int.Parse(txtLuongCB.Text);
                    if (lblUrl.Text != "Text Url Image")
                    {
                        nv.HINHANH = lblUrl.Text;
                    }

                    data.NHANVIENs.InsertOnSubmit(nv);
                    data.SubmitChanges();
                    refreshForm();

                    TAIKHOAN tk = new TAIKHOAN();
                    tk.TENDN = txtSDT.Text;
                    tk.MATKHAU = "1234";
                    tk.NHOM = "Nhân viên";
                    data.TAIKHOANs.InsertOnSubmit(tk);
                    data.SubmitChanges();

                    int lastrow = dataGridView1.Rows.Count - 1;
                    CHITIETNV ct = new CHITIETNV();
                    ct.MANV = int.Parse(dataGridView1.Rows[lastrow].Cells[0].Value.ToString());
                    ct.GIOITINH = cboGioiTinh.Text;
                    ct.NGAYSINH = dtp_ngaysinh.Value;
                    ct.SDT = txtSDT.Text;
                    ct.CMND = txtCMND.Text;
                    data.CHITIETNVs.InsertOnSubmit(ct);
                    data.SubmitChanges();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                    btnOk.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại đã dùng làm tên đăng nhập, hãy chọn một số khác!", "Thông báo");
            }            
        }

        private bool checkKhoaNgoai(string text)
        {
            var taikhoan = from tk in data.TAIKHOANs select tk;
            TAIKHOAN tk1 = taikhoan.Where(t => t.TENDN == text).FirstOrDefault();
            if (tk1 != null)
                return false;
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int manv = int.Parse(txtMaNV.Text);
                NHANVIEN nv = data.NHANVIENs.Where(t => t.MANV == manv).FirstOrDefault();
                CHITIETNV ct = data.CHITIETNVs.Where(n => n.MANV == manv).FirstOrDefault();
                TAIKHOAN tk = data.TAIKHOANs.Where(n => n.TENDN == txtSDT.Text).FirstOrDefault();

                nv.TENNV = txtTenNV.Text;
                nv.LUONGCB = int.Parse(txtLuongCB.Text);
                nv.HINHANH = lblUrl.Text;


                if (ct != null)
                {
                    data.CHITIETNVs.DeleteOnSubmit(ct);
                    data.SubmitChanges();
                }

                if (tk != null)
                {
                    data.TAIKHOANs.DeleteOnSubmit(tk);
                    data.SubmitChanges();
                }

                TAIKHOAN tk2 = new TAIKHOAN();
                tk2.TENDN = txtSDT.Text;
                tk2.MATKHAU = "1234";
                tk2.NHOM = "Nhân viên";
                data.TAIKHOANs.InsertOnSubmit(tk2);
                data.SubmitChanges();

                int lastrow = dataGridView1.Rows.Count - 1;
                CHITIETNV ct2 = new CHITIETNV();
                ct2.MANV = int.Parse(dataGridView1.Rows[lastrow].Cells[0].Value.ToString());
                ct2.GIOITINH = cboGioiTinh.Text;
                ct2.NGAYSINH = dtp_ngaysinh.Value;
                ct2.SDT = txtSDT.Text;
                ct2.CMND = txtCMND.Text;
                data.CHITIETNVs.InsertOnSubmit(ct2);
                data.SubmitChanges();

                refreshForm();
                MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    int manv = int.Parse(txtMaNV.Text);
                    NHANVIEN nv = data.NHANVIENs.Where(n => n.MANV == manv).FirstOrDefault();
                    CHITIETNV ct = data.CHITIETNVs.Where(n => n.MANV == manv).FirstOrDefault();
                    TAIKHOAN tk = data.TAIKHOANs.Where(n => n.TENDN == txtSDT.Text).FirstOrDefault();

                    if (ct != null)
                    {
                        data.CHITIETNVs.DeleteOnSubmit(ct);
                        data.SubmitChanges();
                    }

                    if (tk != null)
                    {
                        data.TAIKHOANs.DeleteOnSubmit(tk);
                        data.SubmitChanges();
                    }

                    data.NHANVIENs.DeleteOnSubmit(nv);
                    data.SubmitChanges();

                    refreshForm();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int manv = int.Parse(txtMaNV.Text);
                var ctnv = from ct in data.CHITIETNVs select ct;
                CHITIETNV chitietnv = ctnv.Where(n => n.MANV == manv).FirstOrDefault();
                cboGioiTinh.Text = chitietnv.GIOITINH;
                dtp_ngaysinh.Value = chitietnv.NGAYSINH.Value;
                txtSDT.Text = chitietnv.SDT;
                txtCMND.Text = chitietnv.CMND;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string tennv = txtTimKiem.Text;
                var nv = from nv2 in data.NHANVIENs select new { nv2.MANV, nv2.TENNV, nv2.LUONGCB, nv2.HINHANH };
                var filter = nv.Where(n => n.TENNV.Contains(tennv));
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

        private void txtLuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
