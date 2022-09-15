using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QL_CuaHangVatLieuXayDung
{
    public partial class QL_CuaHangVatLieuXayDung : Form
    {
        private int childFormNumber = 0;

        public QL_CuaHangVatLieuXayDung()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void kếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = true;
            danhMụcToolStripMenuItem.Enabled = true;
            btnKhachHang.Enabled = true;
            btnNCC.Enabled = true;
            btnNhanVien.Enabled = true;
            btnVatLieu.Enabled = true;
            btnHoaDonBan.Enabled = true;
            btnHoaDonNhap.Enabled = true;  
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }

            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "KetNoiHeThong")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                KetNoiHeThong f2 = new KetNoiHeThong();
                f2.MdiParent = this;
                f2.Show();
            }
            toolStripProgressBar1.Value = 0;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "KhachHang")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                KhachHang f2 = new KhachHang();
                f2.MdiParent = this;
                f2.Show();
            }
            toolStripProgressBar1.Value = 0;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Bạn thực sự muốn thoát?", "Thoát ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void QL_CuaHangVatLieuXayDung_Load(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = false;
            danhMụcToolStripMenuItem.Enabled = false;
            btnKhachHang.Enabled = false;
            btnNCC.Enabled = false;
            btnNhanVien.Enabled = false;
            btnVatLieu.Enabled = false;
            btnHoaDonBan.Enabled = false;
            btnHoaDonNhap.Enabled = false;          
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "NhanVien")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                NhanVien f2 = new NhanVien();
                f2.MdiParent = this;
                f2.Show();
            }
            toolStripProgressBar1.Value = 0;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            NhanVien f = new NhanVien();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            NhaCungCap f = new NhaCungCap();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;       
        }

        private void btnVatLieu_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            VatLieu f = new VatLieu();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;      
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Bạn thực sự muốn thoát?", "Thoát ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = true;
            danhMụcToolStripMenuItem.Enabled = true;
            btnKhachHang.Enabled = true;
            btnNCC.Enabled = true;
            btnNhanVien.Enabled = true;
            btnVatLieu.Enabled = true;
            btnHoaDonBan.Enabled = true;
            btnHoaDonNhap.Enabled = true;
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            KetNoiHeThong f = new KetNoiHeThong();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            KhachHang f = new KhachHang();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            HoaDonNhap f = new HoaDonNhap();
            //f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            HoaDonXuat f = new HoaDonXuat();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            for (int i = toolStripProgressBar1.Minimum; i <= toolStripProgressBar1.Maximum; i += 1)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(10);
            }
            DangNhap f = new DangNhap();
            f.MdiParent = this;
            f.Show();
            toolStripProgressBar1.Value = 0;
        }
    }
}
