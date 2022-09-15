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
    public partial class frmXemKetQuaHocTap : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        int _maHV;

        public frmXemKetQuaHocTap()
        {
            InitializeComponent();
        }

        public frmXemKetQuaHocTap(int maHV)
        {
            InitializeComponent();

            _maHV = maHV;
            docData();
        }

        private void frmXemKetQuaHocTap_Load(object sender, EventArgs e)
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
            var duLieu = from t in db.HOCVIENs
                         from u in db.DIEMs
                         from k in db.LOPHOCs
                         from z in db.LOAILOPs
                         where t.MAHV == _maHV && t.MAHV == u.MAHV && u.MALOP == k.MALOP && k.MALOAILOP == z.MALOAILOP
                         select new
                         {
                             MSHV = t.MAHV,
                             Họ_Tên_HV = t.TENHV,
                             Mã_Lớp = k.MALOP,
                             Tên_Lớp = z.TENLOP,
                             Điểm = u.DIEMSO,
                             Lần_Thi = u.LANTHI
                         };

            dtgv_KQHT.DataSource = duLieu;

            dtgv_KQHT.Columns[0].Width = 120;
            dtgv_KQHT.Columns[1].Width = 120;
            dtgv_KQHT.Columns[2].Width = 120;
            dtgv_KQHT.Columns[3].Width = 120;
            dtgv_KQHT.Columns[4].Width = 120;
            dtgv_KQHT.Columns[5].Width = 120;
        }
    }
}
