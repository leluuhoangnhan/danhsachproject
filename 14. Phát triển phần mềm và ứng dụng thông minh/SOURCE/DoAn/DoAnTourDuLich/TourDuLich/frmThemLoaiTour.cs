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
    public partial class frmThemLoaiTour : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public frmThemLoaiTour()
        {
            InitializeComponent();

            LOAITOUR lt = db.LOAITOURs.OrderByDescending(t => t.MALOAITOUR).FirstOrDefault();
            txtMaLoaiTour.Text = (lt.MALOAITOUR + 1).ToString();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            quayLaiFormQuanLyTour();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txtTenLoaiTour.Text.Length > 0)
            {
                LOAITOUR lt = new LOAITOUR();
                lt.MALOAITOUR = Int16.Parse(txtMaLoaiTour.Text.ToString());
                lt.TENLOAITOUR = txtTenLoaiTour.Text;

                db.LOAITOURs.InsertOnSubmit(lt);
                db.SubmitChanges();

                DialogResult rs = MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (rs == DialogResult.OK)
                {
                    quayLaiFormQuanLyTour();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống các mục trên!");
            }
        }




        public void quayLaiFormQuanLyTour()
        {
            frmQuanLyTour tour = new frmQuanLyTour();
            this.Visible = false;
            tour.Show();
        }

        private void frmThemLoaiTour_Load(object sender, EventArgs e)
        {

        }
    }
}
