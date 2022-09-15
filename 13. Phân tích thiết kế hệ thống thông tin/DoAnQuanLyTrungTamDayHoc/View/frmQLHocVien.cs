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
using DoAnQuanLyTrungTamDayHoc.Model;


namespace DoAnQuanLyTrungTamDayHoc
{
    public partial class frmQLHocVien : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public frmQLHocVien()
        {
            InitializeComponent();

            docDSHocVien();
            loadDiaChiLenCombobox();
        }

        private void frmQLHocVien_Load(object sender, EventArgs e)
        {
            txt_urlImage.Text = String.Empty;

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmMain t = new frmMain();
            this.Visible = false;
            t.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void dtgv_HV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dtgv_HV.CurrentCell.RowIndex;
                dataBingDing_HocVien(index);
            }
            catch (Exception ex) { }
        }

        private void cbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbQuan.DataSource = from t in db.DIACHIs where t.TINH_THANHPHO == cbTinh.Text group t by t.QUAN_HUYEN into k select k.Key;
            cbPhuong.DataSource = from t in db.DIACHIs where t.TINH_THANHPHO == cbTinh.Text group t by t.PHUONG_XA into k select k.Key;
            cbDuong.DataSource = from t in db.DIACHIs where t.TINH_THANHPHO == cbTinh.Text group t by t.DUONG into k select k.Key;
        }

        private void cbQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPhuong.DataSource = from t in db.DIACHIs where t.QUAN_HUYEN == cbQuan.Text group t by t.PHUONG_XA into k select k.Key;
            cbDuong.DataSource = from t in db.DIACHIs where t.QUAN_HUYEN == cbQuan.Text group t by t.DUONG into k select k.Key;
        }

        private void cbPhuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDuong.DataSource = from t in db.DIACHIs where t.PHUONG_XA == cbPhuong.Text group t by t.DUONG into k select k.Key;
        }

        private void cbDuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbTinh.DataSource = from t in db.DIACHIs where t.DUONG == cbDuong.Text group t by t.TINH_THANHPHO into k select k.Key;
            //cbQuan.DataSource = from t in db.DIACHIs where t.DUONG == cbDuong.Text group t by t.QUAN_HUYEN into k select k.Key;
            //cbPhuong.DataSource = from t in db.DIACHIs where t.DUONG == cbDuong.Text group t by t.PHUONG_XA into k select k.Key;
        }

        private void lblChonAnh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nhapHinhAnh();
            luuHinhAnh(txt_urlImage.Text.ToString());
        }

        private void btnSearchHV_Click(object sender, EventArgs e)
        {
            xuLySearch_HV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHV.Text = txtTenHV.Text = txtSDT.Text = txtEmail.Text = dtp_ngaySinh.Text = cbTinh.Text = cbQuan.Text = cbPhuong.Text = cbDuong.Text = txt_urlImage.Text = String.Empty;

            btnXoa.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = btnThem.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(btnThem.Enabled == true) //TH: Thêm
            {
                xuLyThem();
            }
            else if (btnXoa.Enabled == true) //TH: Xóa
            {
                xuLyXoa();
            }
            else //TH: Sửa
            {
                xuLySua();
            }

            btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }

        private void lblXemCongNo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtMaHV.Text.Length > 0)
            {
                frmCongNo t = new frmCongNo(Int16.Parse(txtMaHV.Text.ToString()));
                this.Visible = false;
                t.Show();
            }
            else
            {
                MessageBox.Show("Chưa chọn học viên!");
            }
        }

        private void lblXemTKB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtMaHV.Text.Length > 0)
            {
                frmThoiKhoaBieu t = new frmThoiKhoaBieu(Int16.Parse(txtMaHV.Text.ToString()));
                this.Visible = false;
                t.Show();
            }
            else
            {
                MessageBox.Show("Chưa chọn học viên!");
            }
        }

        private void lblXemKQHT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtMaHV.Text.Length > 0)
            {
                frmXemKetQuaHocTap t = new frmXemKetQuaHocTap(Int16.Parse(txtMaHV.Text.ToString()));
                this.Visible = false;
                t.Show();
            }
            else
            {
                MessageBox.Show("Chưa chọn học viên!");
            }
        }




        public void resetForm()
        {
            frmQLHocVien t = new frmQLHocVien();
            this.Visible = false;
            t.Show();
        }

        public void loadDiaChiLenCombobox()
        {
            cbTinh.DataSource = from t in db.DIACHIs group t by t.TINH_THANHPHO into k select k.Key;
            cbQuan.DataSource = from t in db.DIACHIs group t by t.QUAN_HUYEN into k select k.Key;
            cbPhuong.DataSource = from t in db.DIACHIs group t by t.PHUONG_XA into k select k.Key;
            cbDuong.DataSource = from t in db.DIACHIs group t by t.DUONG into k select k.Key;
        }

        public void docDSHocVien()
        {
            dtgv_HV.DataSource = null;
            var lsHV = from t in db.HOCVIENs
                       select new
                       {
                           Mã_Học_Viên = t.MAHV,
                           Họ_Tên = t.TENHV,
                           SĐT = t.SDT,
                           Email = t.EMAIL,
                           Ngày_Sinh = t.NGAYSINH,
                           Tỉnh_ThànhPhố = t.TINH_THANHPHO,
                           Quận_Huyện = t.QUAN_HUYEN,
                           Phường_Xã = t.PHUONG_XA,
                           Đường = t.DUONG,
                           Hình_Ảnh = t.HINHANH
                       };
            dtgv_HV.DataSource = lsHV;

            dtgv_HV.Columns[5].Width = 150;
        }

        public void dataBingDing_HocVien(int index)
        {
            try
            {
                txtMaHV.Text = dtgv_HV.Rows[index].Cells[0].Value.ToString().Trim();
                txtTenHV.Text = dtgv_HV.Rows[index].Cells[1].Value.ToString().Trim();
                txtSDT.Text = dtgv_HV.Rows[index].Cells[2].Value.ToString().Trim();
                txtEmail.Text = dtgv_HV.Rows[index].Cells[3].Value.ToString().Trim();
                dtp_ngaySinh.Text = dtgv_HV.Rows[index].Cells[4].Value.ToString().Trim();
                cbTinh.Text = dtgv_HV.Rows[index].Cells[5].Value.ToString().Trim();
                cbQuan.Text = dtgv_HV.Rows[index].Cells[6].Value.ToString().Trim();
                cbPhuong.Text = dtgv_HV.Rows[index].Cells[7].Value.ToString().Trim();
                cbDuong.Text = dtgv_HV.Rows[index].Cells[8].Value.ToString().Trim();

                if (dtgv_HV.Rows[index].Cells[9].Value != null)
                {
                    String hinhAnh = dtgv_HV.Rows[index].Cells[9].Value.ToString().Trim();
                    ptb_logo.Image = Image.FromFile(Application.StartupPath + "\\img\\" + hinhAnh);
                    txt_urlImage.Text = hinhAnh;
                }
                else
                {
                    ptb_logo.Image = Image.FromFile(Application.StartupPath + "\\img\\" + "icon_nguoi.png");
                    txt_urlImage.Text = String.Empty;
                }
            }
            catch (Exception ex) { }
        }

        public void nhapHinhAnh()
        {
            //BMP, GIF, JPEG, EXIF, PNG và TIFF, ICO...
            openFileDialog1.Filter = "All Image (*.jpg)|*.jpg|All Image (*.png)|*.png|All Image (*.gif)|*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptb_logo.Image = Image.FromFile(openFileDialog1.FileName.ToString());

                string[] name = openFileDialog1.FileName.Split('\\');
                string tenFile = name[name.Length - 1].ToString().Trim();

                txt_urlImage.Text = tenFile;
            }
        }

        public void luuHinhAnh(string tenFile)
        {
            bool kt = File.Exists(Application.StartupPath + "\\img\\" + tenFile);
            try
            {
                if (kt == false)
                    ptb_logo.Image.Save(Application.StartupPath + "\\img\\" + tenFile, ImageFormat.Png);
            }
            catch (Exception ex) { }
            
        }

        public void xuLySearch_HV()
        {
            if (txtMSHV.Text.Length > 0)
            {
                dtgv_HV.DataSource = null;
                var hv = from t in db.HOCVIENs
                         where t.MAHV == Int16.Parse(txtMSHV.Text.ToString())
                         select new
                         {
                             Mã_Học_Viên = t.MAHV,
                             Họ_Tên = t.TENHV,
                             SĐT = t.SDT,
                             Email = t.EMAIL,
                             Ngày_Sinh = t.NGAYSINH,
                             Tỉnh_ThànhPhố = t.TINH_THANHPHO,
                             Quận_Huyện = t.QUAN_HUYEN,
                             Phường_Xã = t.PHUONG_XA,
                             Đường = t.DUONG,
                             Hình_Ảnh = t.HINHANH
                         };
                dtgv_HV.DataSource = hv;
            }
            else
            {
                MessageBox.Show("Không được bỏ trống MSHV!");
            }
        }

        //Kiem tra hoc vien co phai khoa ngoai cua table khac khong
        public int ktHocVienKhoaNgoai(int maHV)
        {
            List<HOADON> lsHD = (from t in db.HOADONs where t.MAHV == maHV select t).ToList();
            List<CTHOCVIEN> lsCTHV = (from t in db.CTHOCVIENs where t.MAHV == maHV select t).ToList();
            List<DIEM> lsDiem = (from t in db.DIEMs where t.MAHV == maHV select t).ToList();

            if (lsHD.Count > 0 || lsCTHV.Count > 0 || lsDiem.Count > 0)
                return 1;
            return 0;
        }

        //Xu ly them
        public void xuLyThem()
        {
            if (txtTenHV.Text == String.Empty || txtSDT.Text == String.Empty || txtEmail.Text == String.Empty || cbTinh.Text == String.Empty || cbQuan.Text == String.Empty || cbPhuong.Text == String.Empty || cbDuong.Text == String.Empty)
            {
                MessageBox.Show("Không được bỏ trống các mục trên");
            }
            else
            {
                HOCVIEN hv = new HOCVIEN();
                hv.MAHV = 1;
                hv.TENHV = txtTenHV.Text;
                hv.SDT = txtSDT.Text;
                hv.EMAIL = txtEmail.Text;
                hv.NGAYSINH = dtp_ngaySinh.Value;
                hv.TINH_THANHPHO = cbTinh.Text;
                hv.QUAN_HUYEN = cbQuan.Text;
                hv.PHUONG_XA = cbPhuong.Text;
                hv.DUONG = cbDuong.Text;
                if(txt_urlImage.Text.Length > 0)
                {
                    hv.HINHANH = txt_urlImage.Text;
                }
                else
                {
                    hv.HINHANH = null;
                }

                try
                {
                    db.HOCVIENs.InsertOnSubmit(hv);
                    db.SubmitChanges();
                    DialogResult rs = MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        docDSHocVien();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Thêm học viên thất bại!"); }
            }
        }

        //Xu ly xoa
        public void xuLyXoa()
        {
            if(txtMaHV.Text.Length > 0)
            {
                int maHV = Int16.Parse(txtMaHV.Text.ToString());
                HOCVIEN hv = (from t in db.HOCVIENs where t.MAHV == maHV select t).FirstOrDefault();
                if(hv != null)
                {
                    DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (rs == DialogResult.Yes)
                    {
                        int ktKhoaNgoai = ktHocVienKhoaNgoai(maHV);
                        if(ktKhoaNgoai != 0)
                        {
                            MessageBox.Show("Học viên này đang có khóa ngoại đến các bảng khác, không thể xóa!");
                        }
                        else
                        {
                            try
                            {
                                db.HOCVIENs.DeleteOnSubmit(hv);
                                db.SubmitChanges();

                                DialogResult rs1 = MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (rs1 == DialogResult.OK)
                                {
                                    docDSHocVien();
                                }
                            }
                            catch (Exception ex) { MessageBox.Show("Xóa học viên thất bại, lỗi ngoại lệ!"); }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Không tìm thấy học viên cần xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học viên cần xóa!");
            }
        }

        //Xu ly sua
        public void xuLySua()
        {
            if (txtTenHV.Text == String.Empty || txtSDT.Text == String.Empty || txtEmail.Text == String.Empty || cbTinh.Text == String.Empty || cbQuan.Text == String.Empty || cbPhuong.Text == String.Empty || cbDuong.Text == String.Empty)
            {
                MessageBox.Show("Không được bỏ trống các mục trên");
            }
            else
            {
                HOCVIEN hv = (from t in db.HOCVIENs where t.MAHV == Int16.Parse(txtMaHV.Text.ToString()) select t).FirstOrDefault();
                hv.TENHV = txtTenHV.Text;
                hv.SDT = txtSDT.Text;
                hv.EMAIL = txtEmail.Text;
                hv.NGAYSINH = dtp_ngaySinh.Value;
                hv.TINH_THANHPHO = cbTinh.Text;
                hv.QUAN_HUYEN = cbQuan.Text;
                hv.PHUONG_XA = cbPhuong.Text;
                hv.DUONG = cbDuong.Text;
                if (txt_urlImage.Text.Length > 0)
                {
                    hv.HINHANH = txt_urlImage.Text;
                }
                else
                {
                    hv.HINHANH = null;
                }

                try
                {
                    db.SubmitChanges();
                    DialogResult rs = MessageBox.Show("Sửa thông tin học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        docDSHocVien();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Sửa thông tin học viên thất bại!"); }
            }
        }


        



    }
}
