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
    public partial class frmCTTour : Form
    {
        String _maTour;
        DataClasses1DataContext db = new DataClasses1DataContext();

        public frmCTTour()
        {
            InitializeComponent();
        }

        public frmCTTour(String maTour)
        {
            InitializeComponent();

            _maTour = maTour;
        }

        private void frmCTTour_Load(object sender, EventArgs e)
        {
            if(_maTour != null)
            {
                TOUR tour = (from t in db.TOURs where t.MATOUR == _maTour select t).SingleOrDefault();
                if(tour != null)
                {
                    txtMaTour.Text = tour.MATOUR;
                    txtMaLoaiTour.Text = tour.MALOAITOUR.ToString();
                    txtTenTour.Text = tour.TENTOUR;
                    txtChiPhi.Text = String.Format("{0:#,##0.##}", (double)tour.CHIPHI);
                    txtBienSoXe.Text = tour.CTTOUR.BIENSOXE;
                    dtp_ngayBD.Text = tour.CTTOUR.NGAYBD.ToString();
                    dtp_ngayKT.Text = tour.CTTOUR.NGAYKT.ToString();
                    if(tour.MAHINH != null)
                    {
                        ptb_image.Image = Image.FromFile(Application.StartupPath + "\\img\\" + tour.HINHANH.TENHINH);
                    }
                    

                    txtMaTour.Focus();
                }
            }
        }

        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            frmQuanLyTour tour = new frmQuanLyTour();
            this.Visible = false;
            tour.Show();
        }
    }
}
