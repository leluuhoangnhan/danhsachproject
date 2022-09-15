using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangVatLieuXayDung
{
    public partial class NhanVien : Form
    {

        XuLyDuLieu xldl = new XuLyDuLieu();
        DataTable dtNhanVien, dtChucVu;
        DataColumn[] keynhan_vien = new DataColumn[1];
        bool addNew = false;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadCombobox();
            dtNhanVien = xldl.DocDuLieu("select * from NHANVIEN");
            keynhan_vien[0] = dtNhanVien.Columns[0];
            dtNhanVien.PrimaryKey = keynhan_vien;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtNhanVien;
            dataGridView1.Columns[0].DataPropertyName = "MANV";
            dataGridView1.Columns[1].DataPropertyName = "TENNV";           
            DataGridViewComboBoxColumn comboxcolumn = (DataGridViewComboBoxColumn)dataGridView1.Columns[2];
            comboxcolumn.DataSource = dtChucVu;
            comboxcolumn.DisplayMember = "PHANCONG";
            comboxcolumn.ValueMember = "MACV";
            comboxcolumn.DataPropertyName = "MACV";
            dataGridView1.Columns[3].DataPropertyName = "GIOITINH";
            dataGridView1.Columns[4].DataPropertyName = "NGAYSINH";
            dataGridView1.Columns[5].DataPropertyName = "DCHI";
            dataGridView1.Columns[6].DataPropertyName = "DTHOAI";
            dataGridView1.Columns[7].DataPropertyName = "TAIKHOAN";
            dataGridView1.Columns[8].DataPropertyName = "MATKHAU";

            LopBindingData();
        }
        public void loadCombobox()
        {
            dtChucVu = xldl.DocDuLieu("select * from CHUCVU");
            cboChucVu.DataSource = dtChucVu;
            cboChucVu.DisplayMember = "PHANCONG";
            cboChucVu.ValueMember = "MACV";
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.Items.Add("Khác");
        }
        public void LopBindingData()
        {
            txtMaNV.DataBindings.Add("Text", dtNhanVien, "MANV");
            txtTenNV.DataBindings.Add("Text", dtNhanVien, "TENNV");
            //dtpNgaySinh.DataBindings.Add("Text", dtNhanVien, "NGAYSINH");
            txtDiaChi.DataBindings.Add("Text", dtNhanVien, "DCHI");
            txtDienThoai.DataBindings.Add("Text", dtNhanVien, "DTHOAI");
            txtTenDN.DataBindings.Add("Text", dtNhanVien, "TAIKHOAN");
            txtMatKhau.DataBindings.Add("Text", dtNhanVien, "MATKHAU");
            cboChucVu.DataBindings.Add("selectedValue", dtNhanVien, "MACV");
            cboGioiTinh.DataBindings.Add("Text", dtNhanVien, "GIOITINH");
        }

        public void setEditTableForm(bool isEdit)
        {
            if (isEdit)//duoc thay doi
            {
                txtMaNV.Enabled = txtTenNV.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = btnSave.Enabled = cboChucVu.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = txtTenDN.Enabled = txtMatKhau.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;

                //tat databinding khi them moi
                if (addNew)
                {
                    txtMaNV.Clear();
                    txtTenNV.Clear();
                    txtDiaChi.Clear();
                    txtDienThoai.Clear();
                    txtMatKhau.Clear();
                    txtTenDN.Clear();
                    cboGioiTinh.Text = "";
                    cboChucVu.Text = "";
                    txtMaNV.DataBindings.Clear();
                    txtTenNV.DataBindings.Clear();
                    txtDiaChi.DataBindings.Clear();
                    txtDienThoai.DataBindings.Clear();
                    txtMatKhau.DataBindings.Clear();
                    txtTenDN.DataBindings.Clear();
                    cboGioiTinh.DataBindings.Clear();
                    cboChucVu.DataBindings.Clear();
                }
            }
            else
            {
                txtMaNV.Enabled = txtTenNV.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = btnSave.Enabled = cboChucVu.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = txtTenDN.Enabled = txtMatKhau.Enabled = false;
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
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "" || cboGioiTinh.Text == "" || cboChucVu.Text == "" || txtTenDN.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin khách hàng");
            }
            else
            {
                if (addNew)//la them moi
                {
                    DataRow row = dtNhanVien.NewRow();
                    row[0] = txtMaNV.Text;
                    row[1] = txtTenNV.Text;
                    row[2] = cboChucVu.SelectedValue.ToString();
                    row[3] = cboGioiTinh.Text;
                    row[4] = dtpNgaySinh.Text;
                    row[5] = txtDiaChi.Text;
                    row[6] = txtDienThoai.Text;
                    row[7] = txtTenDN.Text;
                    row[8] = txtMatKhau.Text;                    
                    dtNhanVien.Rows.Add(row);
                    btnThem.Enabled = true;
                    btnSave.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    LopBindingData();
                }
                else//la sua
                {
                    DataRow r = dtNhanVien.Rows.Find(txtMaNV.Text);
                    if (r != null)
                    {
                        DataRow row = dtNhanVien.NewRow();
                        row[0] = txtMaNV.Text;
                        row[1] = txtTenNV.Text;
                        row[2] = cboChucVu.SelectedValue.ToString();
                        //row[3] = cboGioiTinh.SelectedValue.ToString();
                        row[4] = dtpNgaySinh.Text;
                        row[5] = txtDiaChi.Text;
                        row[6] = txtDienThoai.Text;
                        row[7] = txtTenDN.Text;
                        row[8] = txtMatKhau.Text;
                        btnThem.Enabled = true;
                        btnSave.Enabled = false;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
                setEditTableForm(false);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow r = dtNhanVien.Rows.Find(txtMaNV.Text);
                if (r != null)
                    r.Delete();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            addNew = false;
            btnSave.Enabled = true;
            setEditTableForm(true);
            dataGridView1.Columns[0].ReadOnly = true;//Khong cho sua khoa
            txtMaNV.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("select * from NHANVIEN", dtNhanVien);
                MessageBox.Show("Success !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private DataTable PopulateDataGridView()
        {
            string query = "SELECT MANV, TENNV,MACV ,GIOITINH,DCHI, DTHOAI, TAIKHOAN,MATKHAU  FROM NHANVIEN";
            query += " WHERE TENNV LIKE '%' + @TENNV + '%'";
            query += " OR @TENNV = ''";
            string constr = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=QL_CHVLXD;User ID=sa;Password=123";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TENNV", textBox1.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = this.PopulateDataGridView();
        }
    }
}
