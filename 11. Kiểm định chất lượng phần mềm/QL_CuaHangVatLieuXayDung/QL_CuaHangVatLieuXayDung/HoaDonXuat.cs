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
    public partial class HoaDonXuat : Form
    {
        XuLyDuLieu xldl = new XuLyDuLieu();
        DataTable dtHoaDonXuat, dtKhachHang, dtHangHoa, dtNhanVien, dtHD_XUAT, dtCTHD_XUAT;
        DataColumn[] keyhoa_don_xuat = new DataColumn[2];
        DataColumn[] keyhd_xuat = new DataColumn[1];
        DataColumn[] keycthd_xuat = new DataColumn[2];
        bool addNew = false;
        public HoaDonXuat()
        {
            InitializeComponent();
        }

        private void HoaDonXuat_Load(object sender, EventArgs e)
        {
            lblThongBao.Text = String.Empty;

            loadCombobox();
            dtHD_XUAT = xldl.DocDuLieu("select * from HD_XUAT");
            dtCTHD_XUAT = xldl.DocDuLieu("select * from CHITIET_HD_XUAT");
            dtHoaDonXuat = xldl.DocDuLieu("select * from HOADON_XUAT");
            keyhoa_don_xuat[0] = dtHoaDonXuat.Columns[0];
            keyhoa_don_xuat[1] = dtHoaDonXuat.Columns[4];
            keyhd_xuat[0] = dtHD_XUAT.Columns[0];
            keycthd_xuat[0] = dtCTHD_XUAT.Columns[0];
            keycthd_xuat[1] = dtCTHD_XUAT.Columns[1];
            dtHoaDonXuat.PrimaryKey = keyhoa_don_xuat;
            dtHD_XUAT.PrimaryKey = keyhd_xuat;
            dtCTHD_XUAT.PrimaryKey = keycthd_xuat;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtHoaDonXuat;
            dataGridView1.Columns[0].DataPropertyName = "MA_HD_XUAT";
            DataGridViewComboBoxColumn comboxcolumnKH = (DataGridViewComboBoxColumn)dataGridView1.Columns[1];
            comboxcolumnKH.DataSource = dtKhachHang;
            comboxcolumnKH.DisplayMember = "TEN";
            comboxcolumnKH.ValueMember = "MAKH";
            comboxcolumnKH.DataPropertyName = "MAKH";
            DataGridViewComboBoxColumn comboxcolumnNV = (DataGridViewComboBoxColumn)dataGridView1.Columns[2];
            comboxcolumnNV.DataSource = dtNhanVien;
            comboxcolumnNV.DisplayMember = "TENNV";
            comboxcolumnNV.ValueMember = "MANV";
            comboxcolumnNV.DataPropertyName = "MANV";
            dataGridView1.Columns[3].DataPropertyName = "NGAYLAP_XUAT";
            DataGridViewComboBoxColumn comboxcolumnHH = (DataGridViewComboBoxColumn)dataGridView1.Columns[4];
            comboxcolumnHH.DataSource = dtHangHoa;
            comboxcolumnHH.DisplayMember = "TENHH";
            comboxcolumnHH.ValueMember = "MAHH";
            comboxcolumnHH.DataPropertyName = "MAHH";
            dataGridView1.Columns[5].DataPropertyName = "SOLUONG_XUAT";
            dataGridView1.Columns[6].DataPropertyName = "DONGIA_XUAT";
            dataGridView1.Columns[7].DataPropertyName = "DVTINH";
            dataGridView1.Columns[8].DataPropertyName = "THANHTIEN";

            LopBindingData();
        }

        public void loadCombobox()
        {
            dtKhachHang = xldl.DocDuLieu("select * from KHACHHANG");
            cboKhachHang.DataSource = dtKhachHang;
            cboKhachHang.DisplayMember = "TEN";
            cboKhachHang.ValueMember = "MAKH";

            dtHangHoa = xldl.DocDuLieu("select * from HANGHOA");
            cboTenSanPham.DataSource = dtHangHoa;
            cboTenSanPham.DisplayMember = "TENHH";
            cboTenSanPham.ValueMember = "MAHH";

            dtNhanVien = xldl.DocDuLieu("select * from NHANVIEN");
            cboTenNV.DataSource = dtNhanVien;
            cboTenNV.DisplayMember = "TENNV";
            cboTenNV.ValueMember = "MANV";

            cboDVT.Items.Add("Viên");
            cboDVT.Items.Add("Khối");
            cboDVT.Items.Add("M3");
            cboDVT.Items.Add("M2");
            cboDVT.Items.Add("Bao");
            cboDVT.Items.Add("Kg");
        }

        public void LopBindingData()
        {
            txtMaHD.DataBindings.Add("Text", dtHoaDonXuat, "MA_HD_XUAT");
            cboKhachHang.DataBindings.Add("selectedValue", dtHoaDonXuat, "MAKH");
            cboTenNV.DataBindings.Add("selectedValue", dtHoaDonXuat, "MANV");
            cboTenSanPham.DataBindings.Add("selectedValue", dtHoaDonXuat, "MAHH");
            txtSoLuong.DataBindings.Add("Text", dtHoaDonXuat, "SOLUONG_XUAT");
            txtDonGia.DataBindings.Add("Text", dtHoaDonXuat, "DONGIA_XUAT");
            cboDVT.DataBindings.Add("Text", dtHoaDonXuat, "DVTINH");
            txtThanhTien.DataBindings.Add("Text", dtHoaDonXuat, "THANHTIEN");
        }

        public void setEditTableForm(bool isEdit)
        {
            if (isEdit)//duoc thay doi
            {
                txtMaHD.Enabled = cboKhachHang.Enabled = cboTenNV.Enabled = dtpNgayLap.Enabled = cboTenSanPham.Enabled = txtSoLuong.Enabled = txtDonGia.Enabled = cboDVT.Enabled = txtThanhTien.Enabled = btnSave.Enabled = btnTinh.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;

                //tat databinding khi them moi
                if (addNew)
                {
                    txtMaHD.Clear();
                    cboKhachHang.Text = "";
                    cboTenNV.Text = "";
                    cboTenSanPham.Text = "";
                    txtSoLuong.Clear();
                    txtDonGia.Clear();
                    cboDVT.Text = "";
                    txtThanhTien.Clear();
                    txtMaHD.DataBindings.Clear();
                    cboKhachHang.DataBindings.Clear();
                    cboTenNV.DataBindings.Clear();
                    cboTenSanPham.DataBindings.Clear();
                    txtSoLuong.DataBindings.Clear();
                    txtDonGia.DataBindings.Clear();
                    cboDVT.DataBindings.Clear();
                    txtThanhTien.DataBindings.Clear();
                }
            }
            else
            {
                txtMaHD.Enabled = cboKhachHang.Enabled = cboTenNV.Enabled = dtpNgayLap.Enabled = cboTenSanPham.Enabled = txtSoLuong.Enabled = txtDonGia.Enabled = cboDVT.Enabled = txtThanhTien.Enabled = btnSave.Enabled = btnTinh.Enabled = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            addNew = true;
            setEditTableForm(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || cboKhachHang.Text == "" || cboTenNV.Text == "" || cboTenSanPham.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "" || cboDVT.Text == "" || txtThanhTien.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin khách hàng");
            }
            else
            {
                bool kq;
                if (addNew)//la them moi
                {
                    try
                    {
                        DataRow row = dtHoaDonXuat.NewRow();
                        row[0] = txtMaHD.Text;
                        row[1] = cboKhachHang.SelectedValue.ToString();
                        row[2] = cboTenNV.SelectedValue.ToString();
                        row[3] = dtpNgayLap.Text;
                        row[4] = cboTenSanPham.SelectedValue.ToString();
                        row[5] = txtSoLuong.Text;
                        row[6] = txtDonGia.Text;
                        row[7] = cboDVT.Text;
                        row[8] = txtThanhTien.Text;
                        dtHoaDonXuat.Rows.Add(row);

                        DataRow row1 = dtHD_XUAT.NewRow();
                        row1[0] = txtMaHD.Text;
                        row1[1] = cboKhachHang.SelectedValue.ToString();
                        row1[2] = cboTenNV.SelectedValue.ToString();
                        row1[3] = dtpNgayLap.Text;
                        row1[4] = txtThanhTien.Text;
                        dtHD_XUAT.Rows.Add(row1);

                        DataRow row2 = dtCTHD_XUAT.NewRow();
                        row2[0] = txtMaHD.Text;
                        row2[1] = cboTenSanPham.SelectedValue.ToString();
                        row2[2] = txtSoLuong.Text;
                        row2[3] = cboDVT.Text;
                        row2[4] = txtDonGia.Text;
                        row2[5] = txtThanhTien.Text;
                        dtCTHD_XUAT.Rows.Add(row2);

                        LopBindingData();

                        kq = true;
                    }
                    catch(Exception ex)
                    {
                        kq = false;
                        dtHoaDonXuat.Rows.RemoveAt(dtHoaDonXuat.Rows.Count-1);
                    }
                }
                else//la sua
                {
                    try
                    {
                        string[] key = new string[2];
                        key[0] = txtMaHD.Text;
                        key[1] = cboTenSanPham.SelectedValue.ToString();
                        DataRow r = dtHoaDonXuat.Rows.Find(key);
                        if (r != null)
                        {
                            DataRow row = dtHoaDonXuat.NewRow();
                            row[0] = txtMaHD.Text;
                            row[1] = cboKhachHang.SelectedValue.ToString();
                            row[2] = cboTenNV.SelectedValue.ToString();
                            row[3] = dtpNgayLap.Text;
                            row[4] = cboTenSanPham.SelectedValue.ToString();
                            row[5] = txtSoLuong.Text;
                            row[6] = txtDonGia.Text;
                            row[7] = cboDVT.Text;
                            row[8] = txtThanhTien.Text;

                            DataRow row1 = dtHD_XUAT.NewRow();
                            row1[0] = txtMaHD.Text;
                            row1[1] = cboKhachHang.SelectedValue.ToString();
                            row1[2] = cboTenNV.SelectedValue.ToString();
                            row1[3] = dtpNgayLap.Text;
                            row1[4] = txtThanhTien.Text;

                            DataRow row2 = dtCTHD_XUAT.NewRow();
                            row2[0] = txtMaHD.Text;
                            row2[1] = cboTenSanPham.SelectedValue.ToString();
                            row2[2] = txtSoLuong.Text;
                            row2[3] = cboDVT.Text;
                            row2[4] = txtDonGia.Text;
                            row2[5] = txtThanhTien.Text;

                        }

                        kq = true;
                    }
                    catch(Exception ex)
                    {
                        kq = false;
                    }
                   
                }

                setEditTableForm(false);
                if(kq == true)
                {
                    lblThongBao.Text = "Thanh cong";
                }
                else
                {
                    lblThongBao.Text = "That bai";
                }

                btnThem.Enabled = true;
                btnSave.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            addNew = false;
            btnSave.Enabled = true;
            setEditTableForm(true);
            dataGridView1.Columns[0].ReadOnly = true;//Khong cho sua khoa
            dataGridView1.Columns[4].ReadOnly = true;
            txtMaHD.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string[] key = new string[2];
                key[0] = txtMaHD.Text;
                key[1] = cboTenSanPham.SelectedValue.ToString();
                DataRow r = dtHoaDonXuat.Rows.Find(key);
                DataRow r2 = dtCTHD_XUAT.Rows.Find(key);
                if (r != null)
                {
                    r.Delete();
                    r2.Delete();
                }
                DataTable dtHD = xldl.DocDuLieu("select COUNT(MA_HD_XUAT) from CHITIET_HD_XUAT where MA_HD_XUAT = '" + txtMaHD + "'");
                if (dtHD.Columns[0].ToString().Equals("1"))
                {
                    DataRow r1 = dtHD_XUAT.Rows.Find(txtMaHD.Text);
                    if (r1 != null)
                        r1.Delete();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("select * from HD_XUAT", dtHD_XUAT);
                xldl.CapNhat("select * from CHITIET_HD_XUAT", dtCTHD_XUAT);
                MessageBox.Show("Success !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Chưa có số lượng hoặc đơn giá");
            }
            else
            {
                double a, b;
                a = Convert.ToDouble(txtDonGia.Text);
                b = Convert.ToDouble(txtSoLuong.Text);
                txtThanhTien.Text = (a * b).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            From_chuaBaocao bc = new From_chuaBaocao();
            bc.Show();
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            nhapThanhTien();   
        }

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            nhapThanhTien();
        }

        public float tinhThanhTien(int soLuong, float donGia)
        {
            return soLuong * donGia;
        }

        public void nhapThanhTien()
        {
            if(txtDonGia.Text.Length > 0 && txtSoLuong.Text.Length > 0)
            {
                txtThanhTien.Text = tinhThanhTien(Int16.Parse(txtSoLuong.Text.ToString()), float.Parse(txtDonGia.Text.ToString())).ToString();
            }
        }

     

    }
}
