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
    public partial class frmQLLopHoc : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public frmQLLopHoc()
        {
            InitializeComponent();
            loaData();
        }
        public void loaData()
        {
            dataGridViewLopHoc.DataSource = null;
            var dsLop = from lop in data.LOPHOCs
                        from loaiLop in data.LOAILOPs
                        from ctlop in data.CTLOPHOCs
                        where lop.MALOAILOP == loaiLop.MALOAILOP
                        where ctlop.MALOP == lop.MALOP
                        select new { lop.MALOP, loaiLop.TENLOP, lop.THU, lop.BUOI, lop.TIET, lop.SOLUONGDADANGKY, lop.SOLUONGDANGKY_TOIDA, ctlop.MAPHONG, loaiLop.LOTRINH, loaiLop.HOCPHI};
            dataGridViewLopHoc.DataSource = dsLop;
            dataGridViewLopHoc.Columns[0].Width = 50;
            dataGridViewLopHoc.Columns[1].Width = 100;
            dataGridViewLopHoc.Columns[2].Width = 50;
            dataGridViewLopHoc.Columns[3].Width = 50;
            dataGridViewLopHoc.Columns[7].Width = 70;
            dataGridViewLopHoc.Columns[4].Width = 70;
            dataGridViewLopHoc.Columns[5].Width = 70;
            dataGridViewLopHoc.Columns[6].Width = 70;
            dataGridViewLopHoc.Columns[8].Width = 70;
            dataGridViewLopHoc.Columns[9].Width = 150;
            dataGridViewLopHoc.Columns[0].HeaderText = "Mã lớp";
            dataGridViewLopHoc.Columns[1].HeaderText = "Tên lớp";
            dataGridViewLopHoc.Columns[2].HeaderText = "Thứ";
            dataGridViewLopHoc.Columns[3].HeaderText = "Buổi";
            dataGridViewLopHoc.Columns[4].HeaderText = "Tiết";
            dataGridViewLopHoc.Columns[5].HeaderText = "Số lượng đăng ký";
            dataGridViewLopHoc.Columns[6].HeaderText = "SL tối đa";
            dataGridViewLopHoc.Columns[7].HeaderText = "Mã phòng";
            dataGridViewLopHoc.Columns[8].HeaderText = "Lộ trình";
            dataGridViewLopHoc.Columns[9].HeaderText = "Học phí";
            dataGridViewLopHoc.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewLopHoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmMain t = new frmMain();
            this.Visible = false;
            t.Show();
        }
    }
}
