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
    public partial class VatLieu : Form
    {
        XuLyDuLieu xldl = new XuLyDuLieu();
        DataTable dtVatLieu, dtLoaiVatLieu, dtDonVi;
        DataColumn[] keykhach_hang = new DataColumn[1];
        bool addNew = false;
        public VatLieu()
        {
            InitializeComponent();
        }

        private void VatLieu_Load(object sender, EventArgs e)
        {
            loadCombobox();
            dtVatLieu = xldl.DocDuLieu("select * from HANGHOA");
            keykhach_hang[0] = dtVatLieu.Columns[0];
            dtVatLieu.PrimaryKey = keykhach_hang;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtVatLieu;
            dataGridView1.Columns[0].DataPropertyName = "MAHH";
            dataGridView1.Columns[1].DataPropertyName = "TENHH";
            DataGridViewComboBoxColumn comboxcolumn1 = (DataGridViewComboBoxColumn)dataGridView1.Columns[2];
            comboxcolumn1.DataSource = dtLoaiVatLieu;
            comboxcolumn1.DisplayMember = "TENLOAI";
            comboxcolumn1.ValueMember = "MALOAI";
            comboxcolumn1.DataPropertyName = "MALOAI";         
            DataGridViewComboBoxColumn comboxcolumn2 = (DataGridViewComboBoxColumn)dataGridView1.Columns[3];
            comboxcolumn2.DataSource = dtDonVi;
            comboxcolumn2.DisplayMember = "DVTINH";
            comboxcolumn2.ValueMember = "MADV";
            comboxcolumn2.DataPropertyName = "MADV";
            dataGridView1.Columns[4].DataPropertyName = "XUATXU";

            LopBindingData();
        }
        public void loadCombobox()
        {
            dtLoaiVatLieu = xldl.DocDuLieu("select * from LOAIHANG");
            cboLoaiVatLieu.DataSource = dtLoaiVatLieu;
            cboLoaiVatLieu.DisplayMember = "TENLOAI";
            cboLoaiVatLieu.ValueMember = "MALOAI";
            dtDonVi = xldl.DocDuLieu("select * from DONVITINH");
            cboDonVi.DataSource = dtDonVi;
            cboDonVi.DisplayMember = "DVTINH";
            cboDonVi.ValueMember = "MADV";
        }
        public void LopBindingData()
        {
            txtMaVL.DataBindings.Add("Text", dtVatLieu, "MAHH");           
            cboLoaiVatLieu.DataBindings.Add("selectedValue", dtVatLieu, "MALOAI");
            txtTenVL.DataBindings.Add("Text", dtVatLieu, "TENHH");
            cboDonVi.DataBindings.Add("selectedValue", dtVatLieu, "MADV");
            txtXuatXu.DataBindings.Add("Text", dtVatLieu, "XUATXU");
            
        }

        public void setEditTableForm(bool isEdit)
        {
            if (isEdit)//duoc thay doi
            {
                txtMaVL.Enabled = txtTenVL.Enabled = txtXuatXu.Enabled = btnSave.Enabled = cboLoaiVatLieu.Enabled = cboDonVi.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;

                //tat databinding khi them moi
                if (addNew)
                {
                    txtMaVL.Clear();
                    txtTenVL.Clear();                   
                    txtXuatXu.Clear();
                    cboLoaiVatLieu.Text = "";
                    cboDonVi.Text = "";
                    txtTenVL.DataBindings.Clear();
                    txtMaVL.DataBindings.Clear();                   
                    txtXuatXu.DataBindings.Clear();
                    cboDonVi.DataBindings.Clear();
                    cboLoaiVatLieu.DataBindings.Clear();
                }
            }
            else
            {
                txtMaVL.Enabled = txtTenVL.Enabled = txtXuatXu.Enabled = btnSave.Enabled = cboLoaiVatLieu.Enabled = cboDonVi.Enabled = false;
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
            if (txtMaVL.Text == "" || txtTenVL.Text == "" || txtXuatXu.Text == "" || cboDonVi.Text=="" || cboLoaiVatLieu.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin khách hàng");
            }
            else
            {
                if (addNew)//la them moi
                {
                    DataRow row = dtVatLieu.NewRow();
                    row[0] = txtMaVL.Text;
                    row[2] = txtTenVL.Text;
                    row[1] = cboLoaiVatLieu.SelectedValue.ToString();
                    row[3] = cboDonVi.SelectedValue.ToString();
                    row[4] = txtXuatXu.Text;
                    dtVatLieu.Rows.Add(row);
                    btnThem.Enabled = true;
                    btnSave.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    LopBindingData();
                }
                else//la sua
                {
                    DataRow r = dtVatLieu.Rows.Find(txtMaVL.Text);
                    if (r != null)
                    {
                        r[2] = txtTenVL.Text;
                        r[1] = cboLoaiVatLieu.SelectedValue.ToString();
                        r[3] = cboDonVi.SelectedValue.ToString();
                        r[4] = txtXuatXu.Text;
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
            txtMaVL.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow r = dtVatLieu.Rows.Find(txtMaVL.Text);
                if (r != null)
                    r.Delete();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("select * from HANGHOA", dtVatLieu);
                MessageBox.Show("Success !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private DataTable PopulateDataGridView()
        {
            string query = "SELECT MAHH, MALOAI,TENHH,MADV, XUATXU  FROM HANGHOA";
            query += " WHERE TENHH LIKE '%' + @TENHH + '%'";
            query += " OR @TENHH = ''";
            string constr = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=QL_CHVLXD;User ID=sa;Password=123";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TENHH", textBox1.Text.Trim());
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
