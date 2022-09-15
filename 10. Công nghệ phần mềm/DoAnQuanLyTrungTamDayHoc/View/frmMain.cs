using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyTrungTamDayHoc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đăngKýHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKyHoc t = new frmDangKyHoc();
            this.Visible = false;
            t.Show();
        }

        private void quảnLýHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHocVien t = new frmQLHocVien();
            this.Visible = false;
            t.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Lay toa do cua lable
            int x = lblTieuDe.Location.X;
            x--;

            lblTieuDe.Location = new Point(x, lblTieuDe.Location.Y);
            lblTieuDe.Visible = false;
            lblTieuDe.Visible = true;

            //Lap lai
            if (x == 0)
            {
                x = this.Size.Width;
                lblTieuDe.Location = new Point(x, lblTieuDe.Location.Y);
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhanVien t = new frmQLNhanVien();
            this.Visible = false;
            t.Show();
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLLopHoc t = new frmQLLopHoc();
            this.Visible = false;
            t.Show();
        }

        private void quảnLýPhòngHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLPhongHoc t = new QLPhongHoc();
            this.Visible = false;
            t.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhanMem t = new frmPhanMem();
            this.Visible = false;
            t.Show();
        }
    }
}
