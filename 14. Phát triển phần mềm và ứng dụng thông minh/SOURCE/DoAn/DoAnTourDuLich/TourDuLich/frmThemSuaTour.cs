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
    public partial class frmThemSuaTour : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        TOUR update;

        public void loadDuLieuTenLoaiTour()
        {
            var listLoaiTour = from t in db.LOAITOURs select t.TENLOAITOUR;
            cb_tenLoaiTour.DataSource = listLoaiTour;
        }

        public void loadDuLieuBienSoXe()
        {
            var listXe = from t in db.XEs select t.BIENSOXE;
            cb_BienSoXe.DataSource = listXe;
        }

        public frmThemSuaTour()
        {
            InitializeComponent();
            btn_them.Visible = true;
            btn_Sua.Visible = false;

            txt_urlImage.Text = String.Empty;
            loadDuLieuTenLoaiTour();
            loadDuLieuBienSoXe();
        }

        public frmThemSuaTour(TOUR t)
        {
            InitializeComponent();

            txt_urlImage.Text = String.Empty;
            txtMaTour.ReadOnly = true;
            btn_them.Visible = false;
            btn_Sua.Visible = true;

            update = t;
            loadDuLieuTourUpdate();
        }



        public void nhapHinhAnh()
        {
            //BMP, GIF, JPEG, EXIF, PNG và TIFF, ICO...
            openFileDialog1.Filter = "All Image (*.jpg)|*.jpg|All Image (*.png)|*.png|All Image (*.gif)|*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptb_image.Image = Image.FromFile(openFileDialog1.FileName.ToString());

                string[] name = openFileDialog1.FileName.Split('\\');
                string tenFile = name[name.Length - 1].ToString().Trim();

                txt_urlImage.Text = tenFile;
            }
        }

        public void luuHinhAnh(string tenFile)
        {
            bool kt = File.Exists(Application.StartupPath + "\\img\\" + tenFile);
            if (kt == false)
                ptb_image.Image.Save(Application.StartupPath + "\\img\\" + tenFile, ImageFormat.Png);
        }

        public void themVaoTableHinh(string tenFile)
        {
            HINHANH ha = db.HINHANHs.OrderByDescending(t => t.MAHINH).FirstOrDefault();
            int maHinhMoi = ha.MAHINH + 1;

            HINHANH ha1 = new HINHANH();
            ha1.MAHINH = maHinhMoi;
            ha1.TENHINH = tenFile;

            db.HINHANHs.InsertOnSubmit(ha1);
            db.SubmitChanges();
        }

        public int checkRong()
        {
            if (txtMaTour.Text.Length > 0 && txtTenTour.Text.Length > 0 && txtChiPhi.Text.Length > 0)
            {
                return 0;
            }

            return 1;
        }

        public void quayLaiFormQuanLyTour()
        {
            frmQuanLyTour tour = new frmQuanLyTour();
            this.Visible = false;
            tour.Show();
        }

        public void loadDuLieuTourUpdate()
        {
            loadDuLieuTenLoaiTour();
            loadDuLieuBienSoXe();

            txtMaTour.Text = update.MATOUR;
            cb_tenLoaiTour.Text = update.LOAITOUR.TENLOAITOUR;
            txtTenTour.Text = update.TENTOUR;
            txtChiPhi.Text = String.Format("{0:#,##0.##}", update.CHIPHI);
            if (update.MAHINH != null)
            {
                ptb_image.Image = Image.FromFile(Application.StartupPath + "\\img\\" + update.HINHANH.TENHINH);
                txt_urlImage.Text = update.HINHANH.TENHINH;
            }
            try
            {
                cb_BienSoXe.Text = update.CTTOUR.BIENSOXE;
                dtp_ngayBD.Text = update.CTTOUR.NGAYBD.Value.Date.ToString();
                dtp_ngayKT.Text = update.CTTOUR.NGAYKT.Value.Date.ToString();
            }
            catch (Exception ex) { }
        }





        private void frmThemTour_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {         
            quayLaiFormQuanLyTour();
        }

        private void lbl_chonAnh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                nhapHinhAnh();
                luuHinhAnh(txt_urlImage.Text.ToString());
                themVaoTableHinh(txt_urlImage.Text.ToString());
            }
            catch (Exception ex) { }
        }

        private void txtChiPhi_Leave(object sender, EventArgs e)
        {
            if(txtChiPhi.Text.Length > 0)
            {
                String[] value = txtChiPhi.Text.ToString().Split('.');
                String so = "";
                for (int i = 0; i < value.Length; i++)
                {
                    so += value[i];
                }

                float chiPhi = float.Parse(so);
                if (chiPhi < 0)
                {
                    txtChiPhi.Text = "0";
                }
                else
                {
                    txtChiPhi.Text = String.Format("{0:#,##0.##}", double.Parse(so.ToString()));
                }
            }
        }

        private void dtp_ngayBD_Leave(object sender, EventArgs e)
        {
            if(dtp_ngayBD.Value < dtp_ngayKT.Value)
            {
                dtp_ngayBD.Value = dtp_ngayKT.Value;
            }
        }

        private void dtp_ngayKT_Leave(object sender, EventArgs e)
        {
            if (dtp_ngayKT.Value < dtp_ngayBD.Value)
            {
                dtp_ngayKT.Value = dtp_ngayBD.Value;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(checkRong() == 0)
            {
                TOUR t = new TOUR();
                t.MATOUR = txtMaTour.Text;
                t.MALOAITOUR = (from u in db.LOAITOURs where u.TENLOAITOUR == cb_tenLoaiTour.Text select u).FirstOrDefault().MALOAITOUR;
                t.TENTOUR = txtTenTour.Text;

                String[] value = txtChiPhi.Text.ToString().Split('.');
                String so = "";
                for (int i = 0; i < value.Length; i++)
                {
                    so += value[i];
                }

                t.CHIPHI = int.Parse(so);
                if (txt_urlImage.Text.Length > 0)
                {
                    int maHinh = (from u in db.HINHANHs where u.TENHINH == txt_urlImage.Text select u).FirstOrDefault().MAHINH;
                    t.MAHINH = maHinh;
                }
                else
                {
                    t.MAHINH = null;
                }

                db.TOURs.InsertOnSubmit(t);
                db.SubmitChanges();

                CTTOUR ct = new CTTOUR();
                ct.MATOUR = txtMaTour.Text;
                ct.BIENSOXE = cb_BienSoXe.Text;
                ct.NGAYBD = dtp_ngayBD.Value;
                ct.NGAYKT = dtp_ngayKT.Value;

                db.CTTOURs.InsertOnSubmit(ct);
                db.SubmitChanges();

                DialogResult rs = MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (rs == DialogResult.OK)
                {
                    quayLaiFormQuanLyTour();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            TOUR moi = new TOUR();
            moi.MATOUR = txtMaTour.Text;
            moi.MALOAITOUR = (from u in db.LOAITOURs where u.TENLOAITOUR.Equals(cb_tenLoaiTour.Text) select u).FirstOrDefault().MALOAITOUR;
            moi.TENTOUR = txtTenTour.Text;

            String[] value = txtChiPhi.Text.ToString().Split('.');
            String so = "";
            for (int i = 0; i < value.Length; i++)
            {
                so += value[i];
            }

            moi.CHIPHI = int.Parse(so);
            if (txt_urlImage.Text.Length > 0)
            {
                int maHinh = (from u in db.HINHANHs where u.TENHINH == txt_urlImage.Text select u).FirstOrDefault().MAHINH;
                moi.MAHINH = maHinh;
            }
            else
            {
                moi.MAHINH = null;
            }

            CTHD ctHoaDon = (from t in db.CTHDs where t.MATOUR == txtMaTour.Text select t).SingleOrDefault();
            if(ctHoaDon != null)
            {
                db.CTHDs.DeleteOnSubmit(ctHoaDon);
                db.SubmitChanges();
            }

            CTTOUR ctTourCu = (from t in db.CTTOURs where t.MATOUR == txtMaTour.Text select t).SingleOrDefault();
            if (ctTourCu != null)
            {
                db.CTTOURs.DeleteOnSubmit(ctTourCu);
                db.SubmitChanges();
            }

            TOUR tourCu = (from t in db.TOURs where t.MATOUR == txtMaTour.Text select t).SingleOrDefault();
            db.TOURs.DeleteOnSubmit(tourCu);
            db.SubmitChanges();

            db.TOURs.InsertOnSubmit(moi);
            db.SubmitChanges();

            CTTOUR ctTourMoi = new CTTOUR();
            ctTourMoi.MATOUR = txtMaTour.Text;
            ctTourMoi.BIENSOXE = cb_BienSoXe.Text;
            ctTourMoi.NGAYBD = dtp_ngayBD.Value;
            ctTourMoi.NGAYKT = dtp_ngayKT.Value;

            db.CTTOURs.InsertOnSubmit(ctTourMoi);
            db.SubmitChanges();

            DialogResult rs = MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (rs == DialogResult.OK)
            {
                quayLaiFormQuanLyTour();
            }
        }
    }
}
