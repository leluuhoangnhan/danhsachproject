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
    public partial class frmQuanLyXe : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public frmQuanLyXe()
        {
            InitializeComponent();
            
        }

        private void dtgv_loaixe_SelectionChanged(object sender, EventArgs e)
        {
            try 
            {
                int index=dtgv_loaixe.CurrentCell.RowIndex;
                dataBingDing_loaiXe(index);
            }
            catch(Exception ex)
            {
            }
        }

        private void dtgv_xe_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dtgv_xe.CurrentCell.RowIndex;
                dataBingDing_Xe(index);
            }
            catch (Exception ex)
            { 
            }
        }

        private void txtChiPhi_Leave(object sender, EventArgs e)
        {
            txtChiPhi.Text = String.Format("{0:#,##0.##}", Double.Parse(txtChiPhi.Text.ToString()));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtMaLoaiXe.Text.Length > 0)
            {
                frmCTXe xe = new frmCTXe(txtBienSo.Text.ToString());
                xe.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn xe xem chi tiết!!!!");
            }
        }

        private void frmQuanLyXe_Load(object sender, EventArgs e)
        {
            txtMaLoaiXe.Focus();
            doDuLieuDataGrirdView_LoaiXe();
            doDuLieuDataGrirdView_Xe();
            loadCombobox();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frmThemSuaLoaiXe themxe = new frmThemSuaLoaiXe();
            themxe.Show();
            this.Visible = false;
        }

        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain(true);
            main.Show();
            this.Visible = false;
        }


        public void doDuLieuDataGrirdView_LoaiXe()
        {
            dtgv_loaixe.DataSource = null;
            var loai_Xe = from t in db.LOAIXEs
                            select new
                            {
                                Mã_Loại = t.MALOAIXE,
                                Tên_Loại = t.TENLOAI,
                                Số_Ghế= t.SOGHE,
                                Chi_Phí = String.Format("{0:#,##0.##}", t.CHIPHI)
                            };
            dtgv_loaixe.DataSource = loai_Xe;

        }


        public void dataBingDing_loaiXe(int index)
        {
            try
            {
                txtMaLoaiXe.Text = String.Empty;
                txtTenLoai.Text = String.Empty;
                txtSoGhe.Text = String.Empty;
                txtChiPhi.Text = String.Empty;

                txtMaLoaiXe.Text = dtgv_loaixe.Rows[index].Cells[0].Value.ToString().Trim();
                txtTenLoai.Text = dtgv_loaixe.Rows[index].Cells[1].Value.ToString().Trim();
                txtSoGhe.Text = dtgv_loaixe.Rows[index].Cells[2].Value.ToString().Trim();
                txtChiPhi.Text = dtgv_loaixe.Rows[index].Cells[3].Value.ToString().Trim();
            }
            catch (Exception ex) { }
        }



        public void doDuLieuDataGrirdView_Xe()
        {
            dtgv_xe.DataSource = null;
            var xe = from t in db.XEs
                          select new
                          {
                              Biển_Số_Xe=t.BIENSOXE,
                              Mã_NV=t.MANV,
                              Tình_Trạng=t.TINHTRANG,
                              Mã_Loại = t.MALOAIXE,              
                          };
            dtgv_xe.DataSource = xe;

        }


        public void dataBingDing_Xe(int index)
        {
            try
            {
                txtBienSo.Text = String.Empty;
                cboMaNV.Text = String.Empty;
                txtTinhTrang.Text = String.Empty;
                txtMaLoaiXe_Xe.Text = String.Empty;

                txtBienSo.Text = dtgv_xe.Rows[index].Cells[0].Value.ToString().Trim();
                cboMaNV.Text = dtgv_xe.Rows[index].Cells[1].Value.ToString().Trim();
                txtTinhTrang.Text = dtgv_xe.Rows[index].Cells[2].Value.ToString().Trim();
                txtMaLoaiXe_Xe.Text = dtgv_xe.Rows[index].Cells[3].Value.ToString().Trim();

            }
            catch (Exception ex) { }
        }




        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiXe.Text.Length > 0)
            {
                LOAIXE delete = (from t in db.LOAIXEs where t.MALOAIXE == Int16.Parse(txtMaLoaiXe.Text) select t).SingleOrDefault();
                int ktTourRong = ktLoaiTourRong(delete.MALOAIXE);
                if (ktTourRong == 0) //LoaiTour con phan tu con ben trong
                {
                    MessageBox.Show("Không thể xóa loại xe này vì loại xe này còn phần tử con bên trong!");
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        db.LOAIXEs.DeleteOnSubmit(delete);

                        db.SubmitChanges();
                        doDuLieuDataGrirdView_LoaiXe();
                        MessageBox.Show("Xóa dữ liệu thành công!");
                    }
                }
            }
        }


        public int ktLoaiTourRong(int maLoaiXe)
        {
            List<XE> ls_xe = (from t in db.XEs where t.MALOAIXE == maLoaiXe select t).ToList();
            if (ls_xe.Count > 0)
                return 0;
            else
                return 1;

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiXe.Text.Length > 0)
            {
                LOAIXE update = (from t in db.LOAIXEs where t.MALOAIXE == Int16.Parse(txtMaLoaiXe.Text) select t).SingleOrDefault();
                update.TENLOAI = txtTenLoai.Text;
                update.SOGHE = int.Parse(txtSoGhe.Text);
                update.CHIPHI = int.Parse(txtChiPhi.Text);


                db.SubmitChanges();
                doDuLieuDataGrirdView_LoaiXe();
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
                dtgv_xe.DataSource = null;
                var xe = from t in db.XEs
                           where t.BIENSOXE.Contains(txtTimKiem.Text)
                           select new
                           {
                               Biển_Số_Xe = t.BIENSOXE,
                               Mã_NV = t.MANV,
                               Tình_Trạng = t.TINHTRANG,
                               Mã_Loại = t.MALOAIXE,  

                           };
                dtgv_xe.DataSource = xe;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tour bạn cần tìm!");
            }
        }

        private void btn_resetForm_Click(object sender, EventArgs e)
        {
            frmQuanLyXe qlx = new frmQuanLyXe();
            this.Visible = false;
            qlx.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void loadCombobox()
        {
            var nhanviens = from nv in db.NHANVIENs select nv.MANV;
            cboMaNV.DataSource = nhanviens;
        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            btnXoaXe.Enabled=btnSuaXe.Enabled= false;
            btn_huy.Enabled = btnLuu.Enabled = true;
        }

        private void btnSuaXe_Click(object sender, EventArgs e)
        {
            btnXoaXe.Enabled = btnThemXe.Enabled = false;
            btn_huy.Enabled = btnLuu.Enabled = true;
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            btnSuaXe.Enabled = btnThemXe.Enabled = false;
            btn_huy.Enabled = btnLuu.Enabled = true;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            btnSuaXe.Enabled = btnThemXe.Enabled = btnXoaXe.Enabled = true;
            btn_huy.Enabled = btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(btnThemXe.Enabled==true) // trường hợp thêm 
            {
                if(txtBienSo.Text.Length>0)
                {
                    try 
                    {
                        XE xe = new XE();
                        xe.BIENSOXE = txtBienSo.Text;
                        xe.MANV = int.Parse(cboMaNV.Text.ToString());
                        xe.TINHTRANG = 0;
                        xe.MALOAIXE = int.Parse(txtMaLoaiXe_Xe.Text.ToString());
                        db.XEs.InsertOnSubmit(xe);
                        db.SubmitChanges();
                        doDuLieuDataGrirdView_Xe();
                        MessageBox.Show("Thêm thành công!!");
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại, trường hợp ngoại lệ ");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng không bỏ trống các mục trên!");
                }
            }
            else if(btnXoaXe.Enabled==true) // TH Xóa
            {
                if(txtBienSo.Text.Length>0)
                {
                    XE delete = (from t in db.XEs where t.BIENSOXE == txtBienSo.Text select t).FirstOrDefault();
                    List<GHE> delete1 = (from t in db.GHEs where t.BIENSOXE == txtBienSo.Text select t).ToList();
                    List<CTTOUR> delete2 = (from t in db.CTTOURs where t.BIENSOXE == txtBienSo.Text select t).ToList();
                    List<CTHD> delete3 =new List<CTHD>();
                    for (int i = 0; i < delete1.Count; i++)
                    {
                        CTHD cthd = (from t in db.CTHDs where t.MAGHE == delete1[i].MAGHE select t).FirstOrDefault();

                        delete3.Add(cthd);
                    }

                    if(delete1.Count > 0 || delete2.Count > 0 || delete3.Count >0)
                    {
                        MessageBox.Show("Khong the xoa xe nay, vi dang la khoa ngoai cua bang khac!");
                    }
                    else
                    {
                        db.XEs.DeleteOnSubmit(delete);
                        db.SubmitChanges();
                        doDuLieuDataGrirdView_Xe();
                        MessageBox.Show("Xóa thành cồng!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn biển số xe bạn cần xóa!");
                }
             
            }
            else // TH sửa
            {

                if (txtBienSo.Text.Length > 0)
                {
                    XE update = (from x in db.XEs where x.BIENSOXE == txtBienSo.Text select x).FirstOrDefault();
                    update.BIENSOXE = txtBienSo.Text;
                    update.MANV = int.Parse(cboMaNV.Text);
                    update.TINHTRANG = int.Parse(txtTinhTrang.Text.ToString());
                    update.MALOAIXE = int.Parse(txtMaLoaiXe_Xe.Text.ToString());


                    db.SubmitChanges();
                    doDuLieuDataGrirdView_Xe();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại tour bạn cần sửa!");
                }
            }
            btnSuaXe.Enabled = btnThemXe.Enabled =btnXoaXe.Enabled=true;
            btn_huy.Enabled = btnLuu.Enabled = false;
            
        }



        public int xoaCTHD(String maGhe)
        {
            try
            {
                CTHD cthd = (from t in db.CTHDs where t.MAGHE == maGhe select t).FirstOrDefault();

                db.CTHDs.DeleteOnSubmit(cthd);
                db.SubmitChanges();
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }

        }




    }
}
