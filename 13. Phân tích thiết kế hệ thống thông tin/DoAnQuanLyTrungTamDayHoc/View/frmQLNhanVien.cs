using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyTrungTamDayHoc.Model;

namespace DoAnQuanLyTrungTamDayHoc
{
    public partial class frmQLNhanVien : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public static int msnv = 1;
        public frmQLNhanVien()
        {
            InitializeComponent();
            dataGridView_LopHoc.Visible = false;
            loaData();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmMain t = new frmMain();
            this.Visible = false;
            t.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Thoát khỏi frm Quản lý nhân viên", "Thông báo", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
                this.Close();
        }

        public void loaData()
        {
            dataGridViewNhanVien.DataSource = null;
            var nhanvien = from nv in data.NHANVIENs
                           from cv in data.CHUCVUs
                           where nv.CHUCVU == cv.MACV
                           select new { nv.MSNV, nv.TENNV, nv.NGAYSINH, cv.TENCV, nv.TRINHDO, nv.KINHNGHIEM, nv.HSL, nv.LUONGCUNG, nv.TENTK };
            dataGridViewNhanVien.DataSource = nhanvien;
            dataGridViewNhanVien.Columns[0].Width = 50;
            dataGridViewNhanVien.Columns[1].Width = 200;
            dataGridViewNhanVien.Columns[4].Width = 60;
            dataGridViewNhanVien.Columns[5].Width = 50;
            dataGridViewNhanVien.Columns[6].Width = 50;
            dataGridViewNhanVien.Columns[7].Width = 150;
            dataGridViewNhanVien.Columns[8].Width = 120;
            dataGridViewNhanVien.Columns[0].HeaderText = "STT";
            dataGridViewNhanVien.Columns[1].HeaderText = "Họ và tên";
            dataGridViewNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dataGridViewNhanVien.Columns[3].HeaderText = "Chức vụ";
            dataGridViewNhanVien.Columns[4].HeaderText = "Trình độ";
            dataGridViewNhanVien.Columns[5].HeaderText = "Kinh nghiệm";
            dataGridViewNhanVien.Columns[6].HeaderText = "HSL";
            dataGridViewNhanVien.Columns[7].HeaderText = "Lương";
            dataGridViewNhanVien.Columns[8].HeaderText = "Tài khoản";
            dataGridViewNhanVien.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void loadDSLop(int manv)
        {
            var lop = from l in data.LOPHOCs
                      from ctnv in data.CTNHANVIENs
                      from loailop in data.CTLOPHOCs
                      where ctnv.MALOP == l.MALOP
                      where loailop.MALOP == l.MALOP
                      where manv == ctnv.MSNV
                      select new { l.MALOP, l.THU, l.BUOI, l.TIET, loailop.MAPHONG };
            dataGridView_LopHoc.DataSource = lop;
        }

        public void bindingData()
        {
            msnv = int.Parse(dataGridViewNhanVien.CurrentRow.Cells[0].Value.ToString());
            txtHoTen.Text = dataGridViewNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Value = Convert.ToDateTime(dataGridViewNhanVien.CurrentRow.Cells[2].Value.ToString());
            txtChucVu.Text = dataGridViewNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtTrinhDo.Text = dataGridViewNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtKinhNghiem.Text = dataGridViewNhanVien.CurrentRow.Cells[5].Value.ToString();

            if (dataGridViewNhanVien.CurrentRow.Cells[6].Value != null)
            {
                txtHeSo.Text = dataGridViewNhanVien.CurrentRow.Cells[6].Value.ToString();
            }

            if (dataGridViewNhanVien.CurrentRow.Cells[7].Value != null)
            {
                txtLuongCB.Text = dataGridViewNhanVien.CurrentRow.Cells[7].Value.ToString();
            }
            
        
            var nv = (from nv1 in data.NHANVIENs where nv1.MSNV == msnv select nv1).First();
            txtQueQuan.Text = nv.TINH_THANHPHO.ToString();
            if (int.Parse(nv.CHUCVU.ToString()) == 1)
            {
                dataGridView_LopHoc.Visible = true;
                loadDSLop(msnv);
            }
            else
                dataGridView_LopHoc.Visible = false;
            if (nv.HINHANH != null)
                pic_Avatar.Image = Image.FromFile(Application.StartupPath + "\\img\\" + nv.HINHANH);
            else
                pic_Avatar.Image = Image.FromFile(Application.StartupPath + "\\img\\" + "icon_nguoi.png");
        }

        private void lbChiTietNhanVien_Click(object sender, EventArgs e)
        {
            frmCTNhanVien ctnv = new frmCTNhanVien();
            ctnv.Show();
        }

        private void dataGridViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            bindingData();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Thoát khỏi from hiện tại?!", "Thông báo", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            msnv = 0;
            DialogResult r = MessageBox.Show("Tạo tài khoản trước khi thêm nhân viên mới", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                frmTaoTaiKhoan tk = new frmTaoTaiKhoan();
                tk.Show();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(dataGridViewNhanVien.CurrentRow.Cells[0].Value.ToString());
            var dsLop = from ds in data.CTNHANVIENs where ds.MSNV == ma select ds;
            foreach (var item in dsLop)
            {
                CTNHANVIEN ctnv = (data.CTNHANVIENs.Where(t => t.MSNV == ma && t.MALOP == item.MALOP)).FirstOrDefault();
                data.CTNHANVIENs.DeleteOnSubmit(ctnv);
            }
            NHANVIEN nv = (data.NHANVIENs.Where(t => t.MSNV == ma)).FirstOrDefault();
            data.NHANVIENs.DeleteOnSubmit(nv);
            loaData();
        }

        private void pic_Avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp;*.png;)| *.jpg; *.jpeg; *.bmp; *.png;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
            //urlHinhAnh.Text = System.IO.Path.Combine(folder, fname).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaData();
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == null)
                MessageBox.Show("Nhap ten san pham truoc khi tim kiem", "Thong bao");
            var sanpham = from s in data.NHANVIENs
                          where s.TENNV.Contains(txtTimKiem.Text)
                          select s;
            dataGridViewNhanVien.DataSource = sanpham;
        }
    }
}
