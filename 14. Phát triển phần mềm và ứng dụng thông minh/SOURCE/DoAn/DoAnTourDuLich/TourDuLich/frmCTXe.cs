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
    public partial class frmCTXe : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        String _biensoxe;
        public frmCTXe()
        {
            InitializeComponent();
        }
        public frmCTXe(String biensoxe)
        {
            InitializeComponent();
            _biensoxe = biensoxe;

        }
        public void LoadCombobox()
        {
            if(_biensoxe !=null)
            {
                var lsghe = from t in db.GHEs where t.BIENSOXE == _biensoxe select t.MAGHE;
                cboMaGhe.DataSource = lsghe;
            }
        }

        private void frmCTXe_Load(object sender, EventArgs e)
        {
            if (_biensoxe != null)
            {
                LoadCombobox();
                XE xe = (from t in db.XEs where t.BIENSOXE == _biensoxe select t).FirstOrDefault();
                if (xe != null)
                {
                    txtMaNV.Text = xe.MANV.ToString();
                    txtTinhTrang.Text = xe.TINHTRANG.ToString();
                }
            }
        }

        private void cboMaGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            GHE g = (from t in db.GHEs where t.MAGHE == cboMaGhe.Text select t).FirstOrDefault();
            txtTinhTrangGhe.Text = g.TINHTRANG.ToString();
        }

        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            frmQuanLyXe xe = new frmQuanLyXe();
            this.Visible = false;
            xe.Show();
        }
    }
}
