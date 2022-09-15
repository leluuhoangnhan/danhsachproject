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
    public partial class NhaCungCap : Form
    {
        XuLyDuLieu xldl = new XuLyDuLieu();
        DataTable dtNhaCungCap;
        DataColumn[] keynha_cung_cap = new DataColumn[1];
        bool addNew = false;
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dtNhaCungCap = xldl.DocDuLieu("select * from NHACUNGCAP");
            keynha_cung_cap[0] = dtNhaCungCap.Columns[0];
            dtNhaCungCap.PrimaryKey = keynha_cung_cap;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtNhaCungCap;
            dataGridView1.Columns[0].DataPropertyName = "MANCC";
            dataGridView1.Columns[1].DataPropertyName = "TENNCC";
            dataGridView1.Columns[2].DataPropertyName = "DCHI";
            dataGridView1.Columns[3].DataPropertyName = "DTHOAI";
           
            LopBindingData();
        
        }             
        public void LopBindingData()
        {
            txtMaNCC.DataBindings.Add("Text", dtNhaCungCap, "MANCC");
            txtTenNCC.DataBindings.Add("Text", dtNhaCungCap, "TENNCC");
            txtDienThoai.DataBindings.Add("Text", dtNhaCungCap, "DTHOAI");
            txtDiaChi.DataBindings.Add("Text", dtNhaCungCap, "DCHI");            
        }

        public void setEditTableForm(bool isEdit)
        {
            if (isEdit)//duoc thay doi
            {
                txtMaNCC.Enabled = txtTenNCC.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = btnSave.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;

                //tat databinding khi them moi
                if (addNew)
                {
                    txtMaNCC.Clear();
                    txtTenNCC.Clear();
                    txtDiaChi.Clear();
                    txtDienThoai.Clear();                    
                    txtTenNCC.DataBindings.Clear();
                    txtMaNCC.DataBindings.Clear();
                    txtDiaChi.DataBindings.Clear();
                    txtDienThoai.DataBindings.Clear();
                }
            }
            else
            {
                txtMaNCC.Enabled = txtTenNCC.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = btnSave.Enabled = false;
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
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin khách hàng");
            }
            else
            {
                if (addNew)//la them moi
                {
                    DataRow row = dtNhaCungCap.NewRow();
                    row[0] = txtMaNCC.Text;
                    row[1] = txtTenNCC.Text;
                    row[2] = txtDiaChi.Text;
                    row[3] = txtDienThoai.Text;                    
                    dtNhaCungCap.Rows.Add(row);
                    btnThem.Enabled = true;
                    btnSave.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    LopBindingData();
                }
                else//la sua
                {
                    DataRow r = dtNhaCungCap.Rows.Find(txtMaNCC.Text);
                    if (r != null)
                    {
                        r[1] = txtTenNCC.Text;
                        r[2] = txtDiaChi.Text;
                        r[3] = txtDienThoai.Text;                      
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
                DataRow r = dtNhaCungCap.Rows.Find(txtMaNCC.Text);
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
            txtMaNCC.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                xldl.CapNhat("select * from NHACUNGCAP", dtNhaCungCap);
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
    }
}
