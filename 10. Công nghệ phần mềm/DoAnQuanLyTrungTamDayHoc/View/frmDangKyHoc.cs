using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyTrungTamDayHoc.Model;

namespace DoAnQuanLyTrungTamDayHoc
{
    public partial class frmDangKyHoc : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public frmDangKyHoc()
        {
            InitializeComponent();

            docDSHocVien();
            docDSLopHoc();
        }

        private void frmDangKyHoc_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
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

        private void dtgv_HV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dtgv_HV.CurrentCell.RowIndex;
                dataBingDing_HocVien(index);
            }
            catch (Exception ex) { }
        }

        private void btnSearchLop_Click(object sender, EventArgs e)
        {
            xuLySearch_Lop();
        }

        private void btnSearchHV_Click(object sender, EventArgs e)
        {
            xuLySearch_HV();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmDangKyHoc t = new frmDangKyHoc();
            this.Visible = false;
            t.Show();
        }

        private void cbMSHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            HOCVIEN hv = (from t in db.HOCVIENs where t.MAHV == Int16.Parse(cbMSHV.Text.ToString()) select t).FirstOrDefault();
            txtHoTenHV.Text = hv.TENHV;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            dtgv_Lop.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(btnThem.Enabled == true) //TH: Thêm
            {
                xuLyThem();
            }
            else //TH: Xóa
            {
                xuLyXoa();
            }

            btnLuu.Enabled = btnHuy.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = true;
            dtgv_Lop.ReadOnly = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = true;
            dtgv_Lop.ReadOnly = true;
        }




        public void docDSHocVien()
        {
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
                           Đường = t.DUONG
                       };
            dtgv_HV.DataSource = lsHV;
            dtgv_HV.Columns[5].Width = 150;

            var lsHV1 = from t in db.HOCVIENs select t.MAHV;
            cbMSHV.DataSource = lsHV1;
        }

        public void docDSLopHoc()
        {
            var lsLop = from t in db.LOPHOCs select new { 
                Mã_Lớp = t.MALOP,
                Tên_Lớp = t.LOAILOP.TENLOP,
                Thứ = t.THU,
                Buổi = t.BUOI,
                Tiết = t.TIET,
                Số_Lượng_Cho_Phép_Đk = t.SOLUONGDANGKY_TOIDA,
                Số_Lượng_Đã_Đk = t.SOLUONGDADANGKY
            };

            dtgv_Lop.DataSource = lsLop;

            dtgv_Lop.Columns[6].Width = 175;
            dtgv_Lop.Columns[7].Width = 175;
        }

        public void dataBingDing_HocVien(int index)
        {
            try
            {
                cbMSHV.Text = String.Empty;
                txtHoTenHV.Text = String.Empty;

                cbMSHV.Text = dtgv_HV.Rows[index].Cells[0].Value.ToString().Trim();
                txtHoTenHV.Text = dtgv_HV.Rows[index].Cells[1].Value.ToString().Trim();
            }
            catch (Exception ex) { }
        }

        public void xuLySearch_HV()
        {
            if (txtMSHV.Text.Length > 0)
            {
                dtgv_HV.DataSource = null;
                var hv = from t in db.HOCVIENs
                         where t.MAHV  == Int16.Parse(txtMSHV.Text.ToString())
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
                             Đường = t.DUONG
                         };
                dtgv_HV.DataSource = hv;
            }
            else
            {
                MessageBox.Show("Không được bỏ trống MSHV!");
            }
        }

        public void xuLySearch_Lop()
        {
            if (txtTenLop.Text.Length > 0)
            {
                dtgv_Lop.DataSource = null;
                var lop = from t in db.LOPHOCs
                          from u in db.LOAILOPs
                          where t.MALOAILOP == u.MALOAILOP && u.TENLOP.Contains(txtTenLop.Text.ToString())
                             select new
                             {
                                 Mã_Lớp = t.MALOP,
                                 Tên_Lớp = t.LOAILOP.TENLOP,
                                 Thứ = t.THU,
                                 Buổi = t.BUOI,
                                 Tiết = t.TIET,
                                 Số_Lượng_Cho_Phép_Đk = t.SOLUONGDANGKY_TOIDA,
                                 Số_Lượng_Đã_Đk = t.SOLUONGDADANGKY
                             };
                dtgv_Lop.DataSource = lop;
            }
            else
            {
                MessageBox.Show("Không được bỏ trống tên lớp!");
            }
        }

        //Lay danh sach lop hoc hoc vien da dang ky
        public List<LOPHOC> layDSLopHocVienDaDangKy(int maHV)
        {
            var lsLopHoc = (from t in db.LOPHOCs
                            from u in db.CTHOCVIENs
                            where u.MAHV == maHV && u.MALOP == t.MALOP
                            select t).ToList();

            return lsLopHoc;
        }

        //Lay lop hoc
        public LOPHOC layLopHoc(int maLop)
        {
            LOPHOC lop = (from t in db.LOPHOCs where t.MALOP == maLop select t).FirstOrDefault();
            
            return lop;
        }

        //Lay danh sach lop hoc hoc vien muon dang ky
        public List<LOPHOC> layDSLopHocVienMuonDangKy()
        {
            List<LOPHOC> ls = new List<LOPHOC>();
            for(int i = 0; i < dtgv_Lop.Rows.Count; i++)
            {
                if (dtgv_Lop[0, i].Value != null)
                {
                    if (bool.Parse(dtgv_Lop[0, i].Value.ToString()) == true)
                    {
                        LOPHOC lh = layLopHoc(Int16.Parse(dtgv_Lop[1, i].Value.ToString()));
                        ls.Add(lh);
                    }
                }
            }

            return ls;
        }

        //Kiem tra hoc vien da dang ky lop hoc nay chua
        public int ktHocVienDaDangKyLopHoc(int maHV, int maLop)
        {
            CTHOCVIEN ct = db.CTHOCVIENs.Where(t => t.MAHV == maHV && t.MALOP == maLop).FirstOrDefault();
            if(ct != null)
            {
                return 1;
            }

            return 0;
        }

        //Kiem tra trung lich dang ky
        public int ktTrungLichDangKy(List<LOPHOC> lopHocDaDangKy, int maLopMoi)
        {
            LOPHOC lopHocMoi = (from t in db.LOPHOCs where t.MALOP == maLopMoi select t).FirstOrDefault();
            for (int i = 0; i < lopHocDaDangKy.Count; i++)
            {
                LOPHOC lop_HocDaDangKy = (from t in db.LOPHOCs where t.MALOP == lopHocDaDangKy[i].MALOP select t).FirstOrDefault();
                if (lopHocMoi.THU == lop_HocDaDangKy.THU && lopHocMoi.BUOI == lop_HocDaDangKy.BUOI && lopHocMoi.TIET == lop_HocDaDangKy.TIET)
                {
                    return 1;
                }
            }
            return 0;
        }

        //Kiem tra lop con trong cho khong
        public int ktLopTrongCho(int maLop)
        {
            LOPHOC lh = (from t in db.LOPHOCs where t.MALOP == maLop select t).FirstOrDefault();
            if (lh.SOLUONGDADANGKY < lh.SOLUONGDANGKY_TOIDA)
                return 1;
            return 0;
        }

        //Kiem tra lop hoc muon dang ky co bi trung lich voi nhau hay khong
        public int ktLopHocMuonDangKyTrungLich(List<LOPHOC> lsLopHocMuonDangKy)
        {
            int n = lsLopHocMuonDangKy.Count;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (lsLopHocMuonDangKy[i].THU == lsLopHocMuonDangKy[j].THU && lsLopHocMuonDangKy[i].BUOI == lsLopHocMuonDangKy[j].BUOI && lsLopHocMuonDangKy[i].TIET == lsLopHocMuonDangKy[j].TIET)
                        return 1;
                }
            }
            return 0;
        }


        //Xu ly dang ky hoc moi
        public void xuLyThem()
        {
            int maHV = Int16.Parse(cbMSHV.Text.ToString());

            List<LOPHOC> dsLopHVDaDangKy = layDSLopHocVienDaDangKy(maHV);
            List<LOPHOC> dsLopHVMuonDangKy = layDSLopHocVienMuonDangKy();

            int kt3 = ktLopHocMuonDangKyTrungLich(dsLopHVMuonDangKy);
            if(kt3 == 1)
            {
                MessageBox.Show("Lớp học muốn đăng ký bị trùng lịch với nhau!");
                return;
            }

            int kt = 0;
            for(int i = 0; i < dsLopHVMuonDangKy.Count; i++)
            {
                if (ktHocVienDaDangKyLopHoc(maHV, dsLopHVMuonDangKy[i].MALOP) == 1)
                    kt++;
            }

            int kt1 = 0;
            for (int i = 0; i < dsLopHVMuonDangKy.Count; i++)
            {
                if (ktTrungLichDangKy(dsLopHVDaDangKy, dsLopHVMuonDangKy[i].MALOP) == 1)
                    kt1++;
            }

            int kt2 = 0;
            for (int i = 0; i < dsLopHVMuonDangKy.Count; i++)
            {
                if (ktLopTrongCho(dsLopHVMuonDangKy[i].MALOP) == 0)
                    kt2++;
            }

            if (kt != 0 || kt1 != 0 || kt2 != 0)
            {
                MessageBox.Show("Đăng ký thất bại, lớp học đã được đăng ký hoặc lịch học bị trùng hoặc lớp học đã đủ người!");
            }
            else
            {
                try
                {
                    for (int i = 0; i < dsLopHVMuonDangKy.Count; i++)
                    {
                        CTHOCVIEN cthv = new CTHOCVIEN();
                        cthv.MAHV = maHV;
                        cthv.MALOP = dsLopHVMuonDangKy[i].MALOP;

                        db.CTHOCVIENs.InsertOnSubmit(cthv);
                        db.SubmitChanges();

                        LOPHOC lh = (from t in db.LOPHOCs where t.MALOP == dsLopHVMuonDangKy[i].MALOP select t).FirstOrDefault();
                        lh.SOLUONGDADANGKY++;
                        db.SubmitChanges();

                    }
                    MessageBox.Show("Đăng ký thành công!");
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Đăng ký thất bại, trường hợp ngoại lệ!"); 
                }  
            }


        }

        //Xu ly xoa dang ky
        public void xuLyXoa()
        {
            DialogResult rs = MessageBox.Show("Xác nhận thao tác thực thi xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                int maHV = Int16.Parse(cbMSHV.Text.ToString());

                try
                {
                    List<LOPHOC> dsLopHVDaDangKy = layDSLopHocVienDaDangKy(maHV);
                    for (int i = 0; i < dsLopHVDaDangKy.Count; i++)
                    {
                        CTHOCVIEN cthv = (from t in db.CTHOCVIENs where t.MAHV == maHV && t.MALOP == dsLopHVDaDangKy[i].MALOP select t).FirstOrDefault();

                        db.CTHOCVIENs.DeleteOnSubmit(cthv);
                        db.SubmitChanges();

                        LOPHOC lh = (from t in db.LOPHOCs where t.MALOP == dsLopHVDaDangKy[i].MALOP select t).FirstOrDefault();
                        lh.SOLUONGDADANGKY--;
                        db.SubmitChanges();
                    }
                    MessageBox.Show("Xóa đăng ký học của học viên thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xóa đăng ký học của học viên thất bại, lỗi ngoại lệ!");
                }   
            }
        }








    }
}
