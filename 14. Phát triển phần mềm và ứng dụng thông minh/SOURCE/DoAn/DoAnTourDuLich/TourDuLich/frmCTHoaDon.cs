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
    public partial class frmCTHoaDon : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public int _mahd;
        public frmCTHoaDon()
        {
            InitializeComponent();
            loadcbb();
        }

        public frmCTHoaDon(int mahd)
        {
            InitializeComponent();
            _mahd = mahd;
            loadcbb();
        }

        private void loadcbb()
        {
            var tours = from t in data.TOURs select t;
            cboMaTour.ValueMember = "MATOUR";
            cboMaTour.DataSource = tours.ToList();
            cboMaTour.DisplayMember = "MATOUR";
            var ghes = from g in data.GHEs select g;
            var filter = ghes.Where(t => t.TINHTRANG == 0);
            cboMaGhe.ValueMember = "MAGHE";
            cboMaGhe.DataSource = filter.ToList();
            cboMaGhe.DisplayMember = "MAGHE";
        }

        private void frmCTHoaDon_Load(object sender, EventArgs e)
        {
            var cthoadons = from ct in data.CTHDs select new { ct.HOADON.MAHD, ct.MATOUR, ct.TOUR.TENTOUR, ct.MAGHE, ct.SLNGUOI};
            var filter = cthoadons.Where(t => t.MAHD == _mahd);
            dataGridView2.DataSource = filter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView2.CurrentCell.RowIndex;
                txtMaHD.Text = dataGridView2.Rows[rowindex].Cells[0].Value.ToString();
                cboMaTour.Text = dataGridView2.Rows[rowindex].Cells[1].Value.ToString();
                txtTenTour.Text = dataGridView2.Rows[rowindex].Cells[2].Value.ToString();
                cboMaGhe.Text = dataGridView2.Rows[rowindex].Cells[3].Value.ToString();
                txtSLN.Text = dataGridView2.Rows[rowindex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn xóa chi tiết hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    CTHD ct = data.CTHDs.Where(t => t.MAHD == int.Parse(txtMaHD.Text)).FirstOrDefault();
                    data.CTHDs.DeleteOnSubmit(ct);
                    data.SubmitChanges();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void refresh()
        {
            var cthoadons = from ct in data.CTHDs select new { ct.HOADON.MAHD, ct.MATOUR, ct.TOUR.TENTOUR, ct.MAGHE, ct.SLNGUOI };
            var filter = cthoadons.Where(t => t.MAHD == _mahd);
            dataGridView2.DataSource = filter;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboMaTour.Text = "";
            cboMaGhe.Text = "";
            txtTenTour.Text = "";
            txtSLN.Text = "";
            if (btnOk.Visible)
            {
                btnOk.Visible = false;
            }
            else
            {
                btnOk.Visible = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                CTHD ct = new CTHD();
                ct.MAHD = _mahd;
                ct.MATOUR = cboMaTour.SelectedValue.ToString();
                ct.MAGHE = cboMaGhe.SelectedValue.ToString();
                ct.SLNGUOI = int.Parse(txtSLN.Text);
                data.CTHDs.InsertOnSubmit(ct);
                data.SubmitChanges();
                refresh();
                MessageBox.Show("Thêm chi tiết hóa đơn thành công");
                btnOk.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void cboMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            TOUR tour = data.TOURs.Where(t => t.MATOUR == cboMaTour.SelectedValue.ToString()).FirstOrDefault();
            if (tour != null)
            {
                txtTenTour.Text = tour.TENTOUR;
            }
        }

        private void txtSLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
            txtTimkiem.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var cthoadons = from ct in data.CTHDs select new { ct.HOADON.MAHD, ct.MATOUR, ct.TOUR.TENTOUR, ct.MAGHE, ct.SLNGUOI };
            var filter = cthoadons.Where(t => t.MAHD == _mahd && t.TENTOUR.Contains(txtTimkiem.Text));
            dataGridView2.DataSource = filter;
        }
    }
}
