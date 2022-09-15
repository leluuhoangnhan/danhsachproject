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
    public partial class frmPhanMem : Form
    {
        public frmPhanMem()
        {
            InitializeComponent();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Close();
            main.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
