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
    public partial class frmQuanLyHoaDon : Form
    {
        
        DataClasses1DataContext db = new DataClasses1DataContext();
        String _maKH;
        bool open = false;
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            loadcbb();
        }
        public frmQuanLyHoaDon(String maKH)
        {
            InitializeComponent();
            loadcbb();
        }

        private void loadcbb()
        {
            var khachhangs = from kh in db.KHACHHANGs select kh;
            cboKH.ValueMember = "MAKH";
            cboKH.DataSource = khachhangs.ToList();
            cboKH.DisplayMember = "TENKH";
            var nhanviens = from nv in db.NHANVIENs select nv;
            cboNV.ValueMember = "MANV";
            cboNV.DataSource = nhanviens.ToList();
            cboNV.DisplayMember = "TENNV";
            var tours = from t in db.TOURs select t;
            cboTour.ValueMember = "MATOUR";
            cboTour.DataSource = tours.ToList();
            cboTour.DisplayMember = "MATOUR";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void doDuLieuDataGrirdView_HoaDon()
        {
            dtgv_hoadon.DataSource = null;
            var hoa_don = from t in db.HOADONs
                          select new
                          {
                              Mã_Hóa_Đơn = t.MAHD,
                              Tên_Khách_Hàng = t.KHACHHANG.TENKH,
                              Tên_Nhân_Viên=t.NHANVIEN.TENNV,
                              Ngày_Lặp_HD =t.NGAYLAP,
                              Tổng_Tiền = t.TONGTIEN,
                          };
            dtgv_hoadon.DataSource = hoa_don;

        }


        public void dataBingDing_hoadon(int index)
        {
            try
            {
                txtMaHD.Text = String.Empty;
                cboKH.Text = String.Empty;
                cboNV.Text = String.Empty;
                dtpNgayLap.Text = String.Empty;

                txtMaHD.Text = dtgv_hoadon.Rows[index].Cells[0].Value.ToString().Trim();
                cboKH.Text = dtgv_hoadon.Rows[index].Cells[1].Value.ToString().Trim();
                cboNV.Text = dtgv_hoadon.Rows[index].Cells[2].Value.ToString().Trim();
                //dtpNgayLap.Text = dtgv_hoadon.Rows[index].Cells[3].Value.ToString().Trim();
                dtpNgayLap.Text = dtgv_hoadon.Rows[index].Cells[3].Value.ToString();
                txtTongTien.Text = dtgv_hoadon.Rows[index].Cells[4].Value.ToString();
                CTHD ct = db.CTHDs.Where(t => t.MAHD == int.Parse(txtMaHD.Text)).FirstOrDefault();
                if (ct != null)
                {
                    txtSLN.Text = ct.SLNGUOI.ToString();
                    cboTour.Text = ct.MATOUR;
                    txtTenTour.Text = ct.TOUR.TENTOUR;
                }
            }
            catch (Exception ex) { }
        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            doDuLieuDataGrirdView_HoaDon();
            doDuLieuDataGridView_Ghe();
            LoadComboBox();
        }

        private void doDuLieuDataGridView_Ghe()
        {
            var ghes = from g in db.GHEs select new { g.MAGHE, g.TINHTRANG, g.BIENSOXE};
            var filter = ghes.Where(t => t.TINHTRANG == 0);
            dataGridView2.DataSource = filter;
        }

        private void dtgv_hoadon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dtgv_hoadon.CurrentCell.RowIndex;
                dataBingDing_hoadon(index);
            }
            catch (Exception ex)
            {
            }
        }
        public void LoadComboBox()
        {

            if (_maKH != null)
            {
                var kh = from t in db.KHACHHANGs where t.MAKH == int.Parse(_maKH.ToString()) select t.MAKH;
                cboKH.DataSource = kh;
            }
        }

        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain(true);
            main.Show();
            this.Visible = false;
        }

        private void lblCTHoadon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (open)
            {
                panel2.Visible = false;
                open = false;
            }
            else
            {
                panel2.Visible = true;
                open = true;
            }
            
        }

        private void lblCTTour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCTTour frm = new frmCTTour(cboTour.Text);
            frm.Show();
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            cboKH.Text = "";
            cboNV.Text = "";
            dtpNgayLap.Value = DateTime.Now;
            txtSLN.Text = "";
            cboTour.Text = "";
            txtTenTour.Text = "";
            txtTongTien.Text = "";
            if (btnOk.Visible)
            {
                btnOk.Visible = false;
            }
            else
            {
                btnOk.Visible = true;
            }
            
        }

        private void cboTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            TOUR tour = db.TOURs.Where(t => t.MATOUR == cboTour.SelectedValue.ToString()).FirstOrDefault();
            if (tour != null)
            {
                txtTenTour.Text = tour.TENTOUR;
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtTimKiem.Text;
                var hoadons = from hd in db.HOADONs select new { hd.MAHD, hd.KHACHHANG.TENKH, hd.NHANVIEN.TENNV, hd.NGAYLAP, hd.TONGTIEN};
                var filter = hoadons.Where(t => t.MAHD == int.Parse(mahd));
                dtgv_hoadon.DataSource = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh()
        {
            var hoa_don = from t in db.HOADONs
                          select new
                          {
                              Mã_Hóa_Đơn = t.MAHD,
                              Tên_Khách_Hàng = t.KHACHHANG.TENKH,
                              Tên_Nhân_Viên = t.NHANVIEN.TENNV,
                              Ngày_Lặp_HD = t.NGAYLAP,
                              Tổng_Tiền = t.TONGTIEN,
                          };
            dtgv_hoadon.DataSource = hoa_don;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn xóa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    HOADON hd = db.HOADONs.Where(t => t.MAHD == int.Parse(txtMaHD.Text)).FirstOrDefault();
                    var ct = db.CTHDs.Where(n => n.MAHD == int.Parse(txtMaHD.Text));

                    if (ct != null)
                    {
                        foreach(CTHD chitiet in ct)
                        {
                            db.CTHDs.DeleteOnSubmit(chitiet);
                        }                       
                        db.SubmitChanges();
                    }

                    db.HOADONs.DeleteOnSubmit(hd);
                    db.SubmitChanges();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (checkSoNguoiVaSoGhe())
            {
                try
                {
                    HOADON hd = new HOADON();
                    hd.MAKH = int.Parse(cboKH.SelectedValue.ToString());
                    hd.MANV = int.Parse(cboNV.SelectedValue.ToString());
                    hd.NGAYLAP = dtpNgayLap.Value;
                    db.HOADONs.InsertOnSubmit(hd);
                    db.SubmitChanges();
                    refresh();

                    int lastrow = dtgv_hoadon.Rows.Count - 1;
                    for (int i = 0; i < int.Parse(txtSLN.Text); i++)
                    {
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                CTHD ct = new CTHD();
                                ct.MAHD = int.Parse(dtgv_hoadon.Rows[lastrow].Cells[0].Value.ToString());
                                ct.MATOUR = cboTour.SelectedValue.ToString();
                                ct.MAGHE = row.Cells[1].Value.ToString();
                                ct.SLNGUOI = 1;
                                db.CTHDs.InsertOnSubmit(ct);
                                db.SubmitChanges();

                                GHE ghe = db.GHEs.Where(t => t.MAGHE == row.Cells[1].Value.ToString()).FirstOrDefault();
                                if (ghe != null)
                                {
                                    ghe.TINHTRANG = 1;
                                    db.SubmitChanges();
                                }
                            }
                        }
                    }
                    MessageBox.Show("Thêm hóa đơn thành công");
                    btnOk.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Số người và số ghế chọn không giống nhau");
            }
            
        }

        private bool checkSoNguoiVaSoGhe()
        {
            if (txtSLN.Text == "")
                return false;
            int songuoi = int.Parse(txtSLN.Text);
            int soghe = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    soghe++;

                }
            }
            if (songuoi != soghe)
                return false;
            else
                return true;
        }

        private void txtSLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            try
            {
                HOADON hd = db.HOADONs.Where(t => t.MAHD == int.Parse(txtMaHD.Text)).FirstOrDefault();
                if (hd != null)
                {
                    hd.MAKH = int.Parse(cboKH.SelectedValue.ToString());
                    hd.MANV = int.Parse(cboNV.SelectedValue.ToString());
                    hd.NGAYLAP = dtpNgayLap.Value;
                    db.SubmitChanges();
                }
                MessageBox.Show("Sửa thông tin hóa đơn thành công");
                refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            frmCTHoaDon frm = new frmCTHoaDon(int.Parse(txtMaHD.Text));
            frm.Show();
        }
    }
}
