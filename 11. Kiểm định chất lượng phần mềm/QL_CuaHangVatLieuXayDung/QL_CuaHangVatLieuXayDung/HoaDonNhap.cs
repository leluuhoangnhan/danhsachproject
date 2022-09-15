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
    public partial class HoaDonNhap : Form
    {
        XuLyDuLieu xldl = new XuLyDuLieu();
        DataTable dtHoaDonNhap, dtNhaCungCap, dtHangHoa, dtNhanVien, dtHD_NHAP, dtCTHD_NHAP;
        DataColumn[] keyhoa_don_nhap = new DataColumn[2];
        DataColumn[] keyhd_nhap = new DataColumn[1];
        DataColumn[] keycthd_nhap = new DataColumn[2];
        bool addNew = false;

        public HoaDonNhap()
        {
            InitializeComponent();
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            loadCombobox();
            dtHD_NHAP = xldl.DocDuLieu("select * from HD_NHAP");
            dtCTHD_NHAP = xldl.DocDuLieu("select * from CHITIET_HD_NHAP");
            dtHoaDonNhap = xldl.DocDuLieu("select * from HOADON_NHAP");
            keyhoa_don_nhap[0] = dtHoaDonNhap.Columns[0];
            keyhoa_don_nhap[1] = dtHoaDonNhap.Columns[4];
            keyhd_nhap[0] = dtHD_NHAP.Columns[0];
            keycthd_nhap[0] = dtCTHD_NHAP.Columns[0];
            keycthd_nhap[1] = dtCTHD_NHAP.Columns[1];
            dtHoaDonNhap.PrimaryKey = keyhoa_don_nhap;
            dtHD_NHAP.PrimaryKey = keyhd_nhap;
            dtCTHD_NHAP.PrimaryKey = keycthd_nhap;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtHoaDonNhap;
            dataGridView1.Columns[0].DataPropertyName = "MA_HD_NHAP";
            DataGridViewComboBoxColumn comboxcolumnNCC = (DataGridViewComboBoxColumn)dataGridView1.Columns[1];
            comboxcolumnNCC.DataSource = dtNhaCungCap;
            comboxcolumnNCC.DisplayMember = "TENNCC";
            comboxcolumnNCC.ValueMember = "MANCC";
            comboxcolumnNCC.DataPropertyName = "MANCC";
            DataGridViewComboBoxColumn comboxcolumnNV = (DataGridViewComboBoxColumn)dataGridView1.Columns[2];
            comboxcolumnNV.DataSource = dtNhanVien;
            comboxcolumnNV.DisplayMember = "TENNV";
            comboxcolumnNV.ValueMember = "MANV";
            comboxcolumnNV.DataPropertyName = "MANV";
            dataGridView1.Columns[3].DataPropertyName = "NGAYLAP_NHAP";
            DataGridViewComboBoxColumn comboxcolumnHH = (DataGridViewComboBoxColumn)dataGridView1.Columns[4];
            comboxcolumnHH.DataSource = dtHangHoa;
            comboxcolumnHH.DisplayMember = "TENHH";
            comboxcolumnHH.ValueMember = "MAHH";
            comboxcolumnHH.DataPropertyName = "MAHH";
            dataGridView1.Columns[5].DataPropertyName = "SOLUONG_NHAP";
            dataGridView1.Columns[6].DataPropertyName = "DONGIA_NHAP";
            dataGridView1.Columns[7].DataPropertyName = "DVTINH";
            dataGridView1.Columns[8].DataPropertyName = "THANHTIEN";

            LopBindingData();
        }

        public void loadCombobox()
        {
            dtNhaCungCap = xldl.DocDuLieu("select * from NHACUNGCAP");
            cboNhaCungCap.DataSource = dtNhaCungCap;
            cboNhaCungCap.DisplayMember = "TENNCC";
            cboNhaCungCap.ValueMember = "MANCC";

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
            txtMaHD.DataBindings.Add("Text", dtHoaDonNhap, "MA_HD_NHAP");
            cboNhaCungCap.DataBindings.Add("selectedValue", dtHoaDonNhap, "MANCC");
            cboTenNV.DataBindings.Add("selectedValue", dtHoaDonNhap, "MANV");
            cboTenSanPham.DataBindings.Add("selectedValue", dtHoaDonNhap, "MAHH");
            txtSoLuong.DataBindings.Add("Text", dtHoaDonNhap, "SOLUONG_NHAP");
            txtDonGia.DataBindings.Add("Text", dtHoaDonNhap, "DONGIA_NHAP");
            cboDVT.DataBindings.Add("Text", dtHoaDonNhap, "DVTINH");
            txtThanhTien.DataBindings.Add("Text", dtHoaDonNhap, "THANHTIEN");
        }

        public void setEditTableForm(bool isEdit)
        {
            if (isEdit)//duoc thay doi
            {
                txtMaHD.Enabled = cboNhaCungCap.Enabled = cboTenNV.Enabled = dtpNgayLap.Enabled = cboTenSanPham.Enabled = txtSoLuong.Enabled = txtDonGia.Enabled = cboDVT.Enabled = txtThanhTien.Enabled = btnSave.Enabled = btnTinh.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;

                //tat databinding khi them moi
                if (addNew)
                {
                    txtMaHD.Clear();
                    cboNhaCungCap.Text = "";
                    cboTenNV.Text = "";
                    cboTenSanPham.Text = "";
                    txtSoLuong.Clear();
                    txtDonGia.Clear();
                    cboDVT.Text = "";
                    txtThanhTien.Clear();
                    txtMaHD.DataBindings.Clear();
                    cboNhaCungCap.DataBindings.Clear();
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
                txtMaHD.Enabled = cboNhaCungCap.Enabled = cboTenNV.Enabled = dtpNgayLap.Enabled = cboTenSanPham.Enabled = txtSoLuong.Enabled = txtDonGia.Enabled = cboDVT.Enabled = txtThanhTien.Enabled = btnSave.Enabled = btnTinh.Enabled = false;
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
            if (txtMaHD.Text == "" || cboNhaCungCap.Text == "" || cboTenNV.Text == "" || cboTenSanPham.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "" || cboDVT.Text == "" || txtThanhTien.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin khách hàng");
            }
            else
            {
                if (addNew)//la them moi
                {
                    DataRow row = dtHoaDonNhap.NewRow();
                    row[0] = txtMaHD.Text;
                    row[1] = cboNhaCungCap.SelectedValue.ToString();
                    row[2] = cboTenNV.SelectedValue.ToString();
                    row[3] = dtpNgayLap.Text;
                    row[4] = cboTenSanPham.SelectedValue.ToString();
                    row[5] = txtSoLuong.Text;
                    row[6] = txtDonGia.Text;
                    row[7] = cboDVT.Text;
                    row[8] = txtThanhTien.Text;
                    dtHoaDonNhap.Rows.Add(row);

                    DataRow row1 = dtHD_NHAP.NewRow();
                    row1[0] = txtMaHD.Text;
                    row1[1] = cboNhaCungCap.SelectedValue.ToString();
                    row1[2] = cboTenNV.SelectedValue.ToString();
                    row1[3] = dtpNgayLap.Text;
                    row1[4] = txtThanhTien.Text;
                    dtHD_NHAP.Rows.Add(row1);

                    DataRow row2 = dtCTHD_NHAP.NewRow();
                    row2[0] = txtMaHD.Text;
                    row2[1] = cboTenSanPham.SelectedValue.ToString();
                    row2[2] = txtSoLuong.Text;
                    row2[3] = cboDVT.Text;
                    row2[4] = txtDonGia.Text;
                    row2[5] = txtThanhTien.Text;
                    dtCTHD_NHAP.Rows.Add(row2);

                    btnThem.Enabled = true;
                    btnSave.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    LopBindingData();
                }
                else//la sua
                {
                    string[] key = new string[2];
                    key[0] = txtMaHD.Text;
                    key[1] = cboTenSanPham.SelectedValue.ToString();
                    DataRow r = dtHoaDonNhap.Rows.Find(key);
                    if (r != null)
                    {
                        DataRow row = dtHoaDonNhap.NewRow();
                        row[0] = txtMaHD.Text;
                        row[1] = cboNhaCungCap.SelectedValue.ToString();
                        row[2] = cboTenNV.SelectedValue.ToString();
                        row[3] = dtpNgayLap.Text;
                        row[4] = cboTenSanPham.SelectedValue.ToString();
                        row[5] = txtSoLuong.Text;
                        row[6] = txtDonGia.Text;
                        row[7] = cboDVT.Text;
                        row[8] = txtThanhTien.Text;

                        DataRow row1 = dtHD_NHAP.NewRow();
                        row1[0] = txtMaHD.Text;
                        row1[1] = cboNhaCungCap.SelectedValue.ToString();
                        row1[2] = cboTenNV.SelectedValue.ToString();
                        row1[3] = dtpNgayLap.Text;
                        row1[4] = txtThanhTien.Text;

                        DataRow row2 = dtCTHD_NHAP.NewRow();
                        row2[0] = txtMaHD.Text;
                        row2[1] = cboTenSanPham.SelectedValue.ToString();
                        row2[2] = txtSoLuong.Text;
                        row2[3] = cboDVT.Text;
                        row2[4] = txtDonGia.Text;
                        row2[5] = txtThanhTien.Text;

                        btnThem.Enabled = true;
                        btnSave.Enabled = false;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
                setEditTableForm(false);
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
                DataRow r = dtHoaDonNhap.Rows.Find(key);
                DataRow r2 = dtCTHD_NHAP.Rows.Find(key);
                if (r != null)
                {
                    r.Delete();
                    r2.Delete();
                }
                DataTable dtHD = xldl.DocDuLieu("select COUNT(MA_HD_NHAP) from CHITIET_HD_NHAP where MA_HD_NHAP = '"+ txtMaHD + "'");
                if (dtHD.Columns[0].ToString().Equals("1"))
                {
                    DataRow r1 = dtHD_NHAP.Rows.Find(txtMaHD.Text);
                    if (r1 != null)
                        r1.Delete();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("select * from HD_NHAP", dtHD_NHAP);
                xldl.CapNhat("select * from CHITIET_HD_NHAP", dtCTHD_NHAP);
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
            from_chubaocao2 bc = new from_chubaocao2();
            bc.Show();
        }
    }
}
