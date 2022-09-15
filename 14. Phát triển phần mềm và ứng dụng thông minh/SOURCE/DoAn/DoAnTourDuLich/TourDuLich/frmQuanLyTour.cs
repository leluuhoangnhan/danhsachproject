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
    public partial class frmQuanLyTour : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public frmQuanLyTour()
        {
            InitializeComponent();
        }

        private void frmQuanLyTour_Load(object sender, EventArgs e)
        {
            txtMaLoaiTour.Focus();

            doDuLieuDataGrirdView_LoaiTour();
            doDuLieuDataGrirdView_Tour();


        }

        private void dtgv_loaiTour_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dtgv_loaiTour.CurrentCell.RowIndex;
                dataBingDing_loaiTour(index);
            }
            catch (Exception ex) { }
        }

        private void dtgv_Tour_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dtgv_Tour.CurrentCell.RowIndex;
                dataBingDing_Tour(index);
            }
            catch (Exception ex) { }
        }

        private void txtChiPhi_Leave(object sender, EventArgs e)
        {
            txtChiPhi.Text = String.Format("{0:#,##0.##}", Double.Parse(txtChiPhi.Text.ToString()));
        }

        private void lbl_xemChiTietTour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtMaTour.Text.Length > 0)
            {
                frmCTTour chiTietTour = new frmCTTour(txtMaTour.Text.ToString());
                this.Visible = false;
                chiTietTour.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Tour bạn cần xem chi tiết!");
            }
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            frmThemSuaTour them = new frmThemSuaTour();
            this.Visible = false;
            them.Show();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frmThemLoaiTour loaiTour = new frmThemLoaiTour();
            this.Visible = false;
            loaiTour.Show();
        }

        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain(true);
            this.Visible = false;
            main.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiTour.Text.Length > 0)
            {
                LOAITOUR delete = (from t in db.LOAITOURs where t.MALOAITOUR == Int16.Parse(txtMaLoaiTour.Text) select t).SingleOrDefault();
                int ktTourRong = ktLoaiTourRong(delete.MALOAITOUR);
                if(ktTourRong == 0) //LoaiTour con phan tu con ben trong
                {
                    MessageBox.Show("Không thể xóa loại tour này vì loại tour này còn phần tử con bên trong!");
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        db.LOAITOURs.DeleteOnSubmit(delete);

                        db.SubmitChanges();
                        doDuLieuDataGrirdView_LoaiTour();
                        MessageBox.Show("Xóa dữ liệu thành công!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại tour bạn cần xóa!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiTour.Text.Length > 0)
            {
                LOAITOUR update = (from t in db.LOAITOURs where t.MALOAITOUR == Int16.Parse(txtMaLoaiTour.Text) select t).SingleOrDefault();
                update.TENLOAITOUR = txtTenLoaiTour.Text;

                db.SubmitChanges();
                doDuLieuDataGrirdView_LoaiTour();
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại tour bạn cần sửa!");
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                dtgv_Tour.DataSource = null;
                var tour = from t in db.TOURs
                           where t.TENTOUR.Contains(txtTimKiem.Text)
                           select new
                           {
                               Mã_Tour = t.MATOUR,
                               Mã_Loại_Tour = t.MALOAITOUR,
                               Tên_Tour = t.TENTOUR,
                               Chi_Phí = String.Format("{0:#,##0.##}", t.CHIPHI)
                           };
                dtgv_Tour.DataSource = tour;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tour bạn cần tìm!");
            }
        }

        private void btn_resetForm_Click(object sender, EventArgs e)
        {
            frmQuanLyTour qlt = new frmQuanLyTour();
            this.Visible = false;
            qlt.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            if (txtMaTour.Text.Length > 0)
            {
                CTHD delete2 = (from t in db.CTHDs where t.MATOUR == txtMaTour.Text select t).SingleOrDefault();
                CTTOUR delete1 = (from t in db.CTTOURs where t.MATOUR == txtMaTour.Text select t).SingleOrDefault();
                TOUR delete = (from t in db.TOURs where t.MATOUR == txtMaTour.Text select t).SingleOrDefault();
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    if (delete2 != null)
                    {
                        db.CTHDs.DeleteOnSubmit(delete2);
                        db.SubmitChanges();
                    }

                    if (delete1 != null)
                    {
                        db.CTTOURs.DeleteOnSubmit(delete1);
                        db.SubmitChanges();
                    }

                    db.TOURs.DeleteOnSubmit(delete);
                    db.SubmitChanges();

                    doDuLieuDataGrirdView_Tour();
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn tour bạn cần xóa!");
            }
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            if (txtMaTour.Text.Length > 0)
            {
                TOUR update = (from t in db.TOURs where t.MATOUR == txtMaTour.Text select t).SingleOrDefault();

                frmThemSuaTour them = new frmThemSuaTour(update);
                this.Visible = false;
                them.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tour bạn cần cập nhật!");
            }
        }





        public void doDuLieuDataGrirdView_LoaiTour()
        {
            dtgv_loaiTour.DataSource = null;
            var loai_Tour = from t in db.LOAITOURs select new {
                Mã_Loại = t.MALOAITOUR,
                Tên_Loại = t.TENLOAITOUR
            };
            dtgv_loaiTour.DataSource = loai_Tour;

            dtgv_loaiTour.Columns[0].Width = 300;
            dtgv_loaiTour.Columns[1].Width = 600;
        }

        public void dataBingDing_loaiTour(int index)
        {
            try
            {
                txtMaLoaiTour.Text = String.Empty;
                txtTenLoaiTour.Text = String.Empty;

                txtMaLoaiTour.Text = dtgv_loaiTour.Rows[index].Cells[0].Value.ToString().Trim();
                txtTenLoaiTour.Text = dtgv_loaiTour.Rows[index].Cells[1].Value.ToString().Trim();
            }
            catch(Exception ex){}
        }

        public void doDuLieuDataGrirdView_Tour()
        {
            dtgv_Tour.DataSource = null;
            var tour = from t in db.TOURs select new { 
                Mã_Tour = t.MATOUR,
                Mã_Loại_Tour = t.MALOAITOUR,
                Tên_Tour = t.TENTOUR,
                Chi_Phí = String.Format("{0:#,##0.##}", t.CHIPHI)
            };
            dtgv_Tour.DataSource = tour;

            dtgv_Tour.Columns[0].Width = 150;
            dtgv_Tour.Columns[1].Width = 150;
            dtgv_Tour.Columns[2].Width = 300;
            dtgv_Tour.Columns[3].Width = 300;
        }

        public void dataBingDing_Tour(int index)
        {
            try
            {
                txtMaTour.Text = String.Empty;
                txtMaLoaiTour_Tour.Text = String.Empty;
                txtTenTour.Text = String.Empty;
                txtChiPhi.Text = String.Empty;

                txtMaTour.Text = dtgv_Tour.Rows[index].Cells[0].Value.ToString().Trim();
                txtMaLoaiTour_Tour.Text = dtgv_Tour.Rows[index].Cells[1].Value.ToString().Trim();
                txtTenTour.Text = dtgv_Tour.Rows[index].Cells[2].Value.ToString().Trim();
                txtChiPhi.Text = dtgv_Tour.Rows[index].Cells[3].Value.ToString().Trim();
            }
            catch (Exception ex) { }
        }

        public int ktLoaiTourRong(int maLoaiTour)
        {
            List<TOUR> ls_tour = (from t in db.TOURs where t.MALOAITOUR == maLoaiTour select t).ToList();
            if (ls_tour.Count > 0)
                return 0;
            else
                return 1;

        }


    }
}
