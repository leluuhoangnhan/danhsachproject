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
    public partial class frmThoiKhoaBieu : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        int _maHV;

        public frmThoiKhoaBieu()
        {
            InitializeComponent();
        }

        public frmThoiKhoaBieu(int maHV)
        {
            InitializeComponent();

            _maHV = maHV;
            docData();
        }


        private void frmThoiKhoaBieu_Load(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmQLHocVien t = new frmQLHocVien();
            this.Visible = false;
            t.Show();
        }

        public void docData()
        {
            var duLieu = from t in db.CTHOCVIENs
                         from u in db.LOPHOCs
                         from k in db.LOAILOPs
                         from z in db.CTLOPHOCs
                         where t.MAHV == _maHV && t.MALOP == u.MALOP && u.MALOAILOP == k.MALOAILOP && u.MALOP == z.MALOP
                         orderby u.THU, u.BUOI, u.TIET ascending
                         select new
                         {
                             Thứ = u.THU,
                             Buổi = u.BUOI,
                             Tiết = u.TIET,
                             Tên_Lớp = k.TENLOP,
                             Mã_phòng = z.MAPHONG
                         };
            dtgv_TKB.DataSource = duLieu;

            dtgv_TKB.Columns[0].Width = 150;
            dtgv_TKB.Columns[1].Width = 150;
            dtgv_TKB.Columns[2].Width = 150;
            dtgv_TKB.Columns[3].Width = 150;
            dtgv_TKB.Columns[4].Width = 150;
        }
    }
}
