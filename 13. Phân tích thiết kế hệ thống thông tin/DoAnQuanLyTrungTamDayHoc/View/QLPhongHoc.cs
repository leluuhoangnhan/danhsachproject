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
    public partial class QLPhongHoc : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public QLPhongHoc()
        {
            InitializeComponent();
            docDSPhongHoc();
        }
        public void docDSPhongHoc()
        {

            var lsPH = 
                       from u in db.CTPHONGs
                       select new
                       {
                           Mã_PHÒNG = u.MAPHONG,
                           
                           Thứ = u.THU,
                           Buổi = u.BUOI,
                           Tiết = u.TIET

                       };
            dataGridView1.DataSource = lsPH;
        }
        
        public void xuLySearch_HV()
        {
            if (txttimkiem.Text.Length > 0)
            {
                dataGridView1.DataSource = null;
                var hv = from u in db.CTPHONGs
                         where u.THU == Int16.Parse(txttimkiem.Text.ToString())
                         select new
                         {
                             Mã_PHÒNG = u.MAPHONG,
                             Thứ = u.THU,
                             Buổi = u.BUOI,
                             Tiết = u.TIET
                         };
                dataGridView1.DataSource = hv;
            }
            else
            {
                MessageBox.Show("Không được bỏ trống MAPHONG!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


            txtmaphong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtthu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtbuoi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttiet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();



        }

        private void bntthem_Click(object sender, EventArgs e)
        {
            txtmaphong.Text = txtthu.Text = txtbuoi.Text = txttiet.Text = String.Empty;

            bntxoa.Enabled = bntsua.Enabled = false;
            bntluu.Enabled = bnthuy.Enabled =true;

        }

        private void bntxoa_Click(object sender, EventArgs e)
        {
            //using (DataClasses1DataContext db = new DataClasses1DataContext())
            //{
            //    string maphong = dataGridView1.SelectedCells[0].OwningRow.Cells["MAPHONG"].Value.ToString();
            //    CTPHONG delete = db.CTPHONGs.Where(ctp => ctp.MAPHONG.Equals(maphong)).SingleOrDefault();
            //    db.CTPHONGs.DeleteOnSubmit(delete);
            //    db.SubmitChanges();
            //}
            //docDSPhongHoc();
            bntxoa.Enabled = bntsua.Enabled = false;
            bntluu.Enabled = bnthuy.Enabled = true;
        }

        private void bntsua_Click(object sender, EventArgs e)
        {

            bntxoa.Enabled = bntsua.Enabled = false;
            bntluu.Enabled = bnthuy.Enabled = true;
        }

        private void bnttimkiem_Click(object sender, EventArgs e)
        {
            xuLySearch_HV();
        }

        private void frmQLphonghoc_Load(object sender, EventArgs e)
        {

        }

        private void bntluu_Click(object sender, EventArgs e)
        {
            if (bntthem.Enabled == true) //TH: Thêm
            {
                xuLyThem();
            }
            //else if (bntxoa.Enabled == true) //TH: Xóa
            //{
            //    xuLyXoa();
            //}
            //else //TH: Sửa
            //{
            //    xuLySua();
            //}

            bntxoa.Enabled = bntsua.Enabled = bntthem.Enabled = true;
            bntluu.Enabled = bnthuy.Enabled = false;
        }

        private void bnthuy_Click(object sender, EventArgs e)
        {
            bntxoa.Enabled = bntsua.Enabled = bntthem.Enabled = true;
            bntluu.Enabled = bnthuy.Enabled = false;
        }

        public void xuLyThem()
        {
            if (txtmaphong.Text == String.Empty || txtthu.Text == String.Empty || txtbuoi.Text == String.Empty || txttiet.Text == String.Empty)
            {
                MessageBox.Show("Không được bỏ trống các mục trên");
            }
            else
            {
                
                CTPHONG ctp = new CTPHONG();
                ctp.MAPHONG = txtmaphong.Text;
                ctp.THU = int.Parse(txtthu.Text);
                ctp.BUOI = int.Parse(txtbuoi.Text);
                ctp.TIET = txttiet.Text;

                try
                {
                    
                    db.CTPHONGs.InsertOnSubmit(ctp);
                    db.SubmitChanges();
                    DialogResult rs = MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        docDSPhongHoc();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Thêm phòng học thất bại!"); }

            }
        }
    }
}
