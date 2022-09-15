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
    public partial class frmMain : Form
    {
        public bool ktDN = false;
        public frmMain()
        {
            InitializeComponent();
            if (ktDN)
            {
                chứcNăngToolStripMenuItem.Enabled = true;
                đăngXuấtToolStripMenuItem.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
            }
            else
            {
                chứcNăngToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
            }
        }

        public frmMain(bool check)
        {
            InitializeComponent();
            ktDN = check;
            if (ktDN)
            {
                chứcNăngToolStripMenuItem.Enabled = true;
                đăngXuấtToolStripMenuItem.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
            }
            else
            {
                chứcNăngToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien n = new frmNhanVien();
            n.Show();
            this.Visible = false;
        }

        private void quảnLýLoạiTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTour t = new frmQuanLyTour();
            this.Visible = false;
            t.Show();
        }

        private void quảnLýXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyXe qlx = new frmQuanLyXe();
            this.Visible = false;
            qlx.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            this.Visible = false;
            kh.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHoaDon hd = new frmQuanLyHoaDon();
            this.Visible = false;
            hd.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan tk = new frmTaiKhoan();
            this.Visible = false;
            tk.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain(false);
            frm.Show();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {
                this.Close();
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
    }
}
