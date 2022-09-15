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
    public partial class frmCongNo : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        int _maHV;

        public frmCongNo()
        {
            InitializeComponent();
        }

        public frmCongNo(int maHV)
        {
            InitializeComponent();

            _maHV = maHV;
            docDSData();
        }

        private void frmCongNo_Load(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmQLHocVien t = new frmQLHocVien();
            this.Visible = false;
            t.Show();
        }


        public void docDSData()
        {
            var duLieu = from t in db.HOCVIENs
                         from u in db.CTHOCVIENs
                         from k in db.LOPHOCs
                         from z in db.LOAILOPs
                         where t.MAHV == _maHV && t.MAHV == u.MAHV && u.MALOP == k.MALOP && k.MALOAILOP == z.MALOAILOP
                         select new
                         {
                             MSHV = t.MAHV,
                             Họ_Tên_HV = t.TENHV,
                             Mã_Lớp = k.MALOP,
                             Tên_Lớp = z.TENLOP,
                             Học_Phí = String.Format("{0:#,##0.##}", z.HOCPHI)
                         };
            dtgv_CongNo.DataSource = duLieu;

            dtgv_CongNo.Columns[0].Width = 150;
            dtgv_CongNo.Columns[1].Width = 150;
            dtgv_CongNo.Columns[2].Width = 150;
            dtgv_CongNo.Columns[3].Width = 150;
            dtgv_CongNo.Columns[4].Width = 150;
        }
    }
}
