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
    public partial class frmThemSuaLoaiXe : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        LOAIXE update;
        public frmThemSuaLoaiXe()
        {
            InitializeComponent();

            LOAIXE lx = db.LOAIXEs.OrderByDescending(t => t.MALOAIXE).FirstOrDefault();
            txtMaLoaiXe.Text = (lx.MALOAIXE + 1).ToString();
        }

        public int checkRong()
        {
            if (txtMaLoaiXe.Text.Length > 0 && txtTenLoaiXe.Text.Length > 0 && txtChiPhi.Text.Length > 0)
            {
                return 0;
            }

            return 1;
        }
        private void frmThemLoaiXe_Load(object sender, EventArgs e)
        {

        }
        public void quayLaiFormQuanLyXe()
        {
            frmQuanLyXe xe = new frmQuanLyXe();
            xe.Show();
            this.Visible = false;
        }
        private void txtChiPhi_Leave(object sender, EventArgs e)
        {
            if (txtChiPhi.Text.Length > 0)
            {
                String[] value = txtChiPhi.Text.ToString().Split('.');
                String so = "";
                for (int i = 0; i < value.Length; i++)
                {
                    so += value[i];
                }

                float chiPhi = float.Parse(so);
                if (chiPhi < 0)
                {
                    txtChiPhi.Text = "0";
                }
                else
                {
                    txtChiPhi.Text = String.Format("{0:#,##0.##}", double.Parse(so.ToString()));
                }
            }
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            if (txtTenLoaiXe.Text.Length > 0)
            {
                LOAIXE lx = new LOAIXE();
                lx.MALOAIXE = Int16.Parse(txtMaLoaiXe.Text.ToString());
                lx.TENLOAI = txtTenLoaiXe.Text;
                lx.SOGHE = int.Parse(txtSoGhe.Text);
                String[] value = txtChiPhi.Text.ToString().Split('.');
                String so = "";
                for (int i = 0; i < value.Length; i++)
                {
                    so += value[i];
                }

                lx.CHIPHI = int.Parse(so);

                db.LOAIXEs.InsertOnSubmit(lx);
                db.SubmitChanges();

                DialogResult rs = MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (rs == DialogResult.OK)
                {
                    quayLaiFormQuanLyXe();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống các mục trên!");
            }
        }

        private void btn_huy_Click_1(object sender, EventArgs e)
        {
            quayLaiFormQuanLyXe();
        }
    }
}
