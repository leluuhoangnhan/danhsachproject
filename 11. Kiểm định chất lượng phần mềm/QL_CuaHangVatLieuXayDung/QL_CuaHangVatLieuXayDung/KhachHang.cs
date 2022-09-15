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
    public partial class KhachHang : Form
    {
        XuLyDuLieu xldl = new XuLyDuLieu();
        DataTable dtKhachHang, dtLoaiKhachHang;
        DataColumn[] keykhach_hang = new DataColumn[1];
        bool addNew = false;

        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            loadCombobox();
            dtKhachHang = xldl.DocDuLieu("select * from KHACHHANG");
            keykhach_hang[0] = dtKhachHang.Columns[0];
            dtKhachHang.PrimaryKey = keykhach_hang;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtKhachHang;
            dataGridView1.Columns[0].DataPropertyName = "MAKH";
            dataGridView1.Columns[1].DataPropertyName = "TEN";
            dataGridView1.Columns[2].DataPropertyName = "DCHI";
            dataGridView1.Columns[3].DataPropertyName = "DTHOAI";
            DataGridViewComboBoxColumn comboxcolumn = (DataGridViewComboBoxColumn)dataGridView1.Columns[4];
            comboxcolumn.DataSource = dtLoaiKhachHang;
            comboxcolumn.DisplayMember = "TENLOAI";
            comboxcolumn.ValueMember = "MALOAI";
            comboxcolumn.DataPropertyName = "MALOAI";

            LopBindingData();
        }
        public void loadCombobox()
        {
            dtLoaiKhachHang = xldl.DocDuLieu("select * from LOAIKHACH");
            cboLoaiKhachHang.DataSource = dtLoaiKhachHang;
            cboLoaiKhachHang.DisplayMember = "TENLOAI";
            cboLoaiKhachHang.ValueMember = "MALOAI";         
        }
        public void LopBindingData()
        {
            txtMaKH.DataBindings.Add("Text", dtKhachHang, "MAKH");
            txtTenKH.DataBindings.Add("Text", dtKhachHang, "TEN");
            txtDienThoai.DataBindings.Add("Text", dtKhachHang, "DTHOAI");
            txtDiaChi.DataBindings.Add("Text", dtKhachHang, "DCHI");
            cboLoaiKhachHang.DataBindings.Add("selectedValue", dtKhachHang, "MALOAI");
        }

        public void setEditTableForm(bool isEdit)
        {
            if (isEdit)//duoc thay doi
            {
                txtMaKH.Enabled = txtTenKH.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = btnSave.Enabled = cboLoaiKhachHang.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;

                //tat databinding khi them moi
                if (addNew)
                {
                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtDiaChi.Clear();
                    txtDienThoai.Clear();
                    cboLoaiKhachHang.Text = "";
                    txtTenKH.DataBindings.Clear();
                    txtMaKH.DataBindings.Clear();
                    txtDiaChi.DataBindings.Clear();
                    txtDienThoai.DataBindings.Clear();
                    cboLoaiKhachHang.DataBindings.Clear();
                }
            }
            else
            {
                txtMaKH.Enabled = txtTenKH.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = btnSave.Enabled = cboLoaiKhachHang.Enabled = false;
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
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "" || cboLoaiKhachHang.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin khách hàng");
            }
            else
            {
                if (addNew)//la them moi
                {
                    DataRow row = dtKhachHang.NewRow();
                    row[0] = txtMaKH.Text;
                    row[1] = txtTenKH.Text;
                    row[2] = txtDiaChi.Text;
                    row[3] = txtDienThoai.Text;
                    row[4] = cboLoaiKhachHang.SelectedValue.ToString();
                    dtKhachHang.Rows.Add(row);
                    btnThem.Enabled = true;
                    btnSave.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    LopBindingData();
                }
                else//la sua
                {
                    DataRow r = dtKhachHang.Rows.Find(txtMaKH.Text);
                    if (r != null)
                    {
                        r[1] = txtTenKH.Text;
                        r[2] = txtDiaChi.Text;
                        r[3] = txtDienThoai.Text;
                        r[4] = cboLoaiKhachHang.SelectedValue.ToString();
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
            txtMaKH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow r = dtKhachHang.Rows.Find(txtMaKH.Text);
                if (r != null)
                    r.Delete();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("select * from KHACHHANG", dtKhachHang);
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
            string query = "SELECT MAKH, TEN,DCHI, DTHOAI, MALOAI  FROM KHACHHANG";
            query += " WHERE TEN LIKE '%' + @TEN + '%'";
            query += " OR @TEN = ''";
            string constr = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=QL_CHVLXD;User ID=sa;Password=123";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TEN", textBox1.Text.Trim());
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
