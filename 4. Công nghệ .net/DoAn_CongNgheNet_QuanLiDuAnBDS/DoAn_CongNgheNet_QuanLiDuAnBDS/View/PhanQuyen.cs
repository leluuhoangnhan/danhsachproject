using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAn_CongNgheNet_QuanLiDuAnBDS.Model;
using System.Data.SqlClient;
using System.IO;

namespace DoAn_CongNgheNet_QuanLiDuAnBDS
{
    public partial class PhanQuyen : Form
    {
        DB_QLDA dt = new DB_QLDA();
        DataTable tk;
        SqlDataAdapter sda;


        public PhanQuyen()
        {
            InitializeComponent();
        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        //------------------Hàm gọi chạy-------------------
        public void loadForm()
        {
            docDuLieuLenTable();
            hienThiDSNhom();
            hienThiDSBang();
        }

        public void reset()
        {
            this.Hide();
            PhanQuyen pq = new PhanQuyen();
            pq.Visible = true;
        }

        public void ktNhapDuLieu(Control ct)
        {
            if (ct.Text.Length == 0)
                this.errorProvider1.SetError(ct, "Không được bỏ trống!");
            else
                this.errorProvider1.Clear();
        }

        public void hienThiDSNhom()
        {
            String sql = "SELECT * FROM [DS_NHOM]";
            SqlDataAdapter sda1 = new SqlDataAdapter(sql, dt.conn);

            DataTable ds_nhom = new DataTable();
            sda1.Fill(ds_nhom);

            cb_nhomND_tk.DataSource = ds_nhom;
            cb_nhomND_tk.DisplayMember = "TENNHOM";
            cb_nhomND_tk.ValueMember = "TENNHOM";

            cb_nhomND_phanQuyen.DataSource = ds_nhom;
            cb_nhomND_phanQuyen.DisplayMember = "TENNHOM";
            cb_nhomND_phanQuyen.ValueMember = "TENNHOM";
        }

        public void hienThiDSBang()
        {
            String sql = "SELECT * FROM [DS_TABLE]";
            SqlDataAdapter sda1 = new SqlDataAdapter(sql, dt.conn);

            DataTable ds_table = new DataTable();
            sda1.Fill(ds_table);

            cb_bangDuLieu.DataSource = ds_table;
            cb_bangDuLieu.DisplayMember = "TEN_TABLE";
            cb_bangDuLieu.ValueMember = "TEN_TABLE";
        }

        public void docDuLieuLenTable()
        {
            tk = new DataTable();
            String sql = "SELECT * FROM [TAIKHOAN]";
            sda = new SqlDataAdapter(sql, dt.conn);
            sda.Fill(tk);

            dtg_duLieu.DataSource = tk;
            taoKhoaChinh(tk);
            dataBingDing(tk);
        }

        public void taoKhoaChinh(DataTable table)
        {
            DataColumn[] dc = new DataColumn[2];
            dc[0] = table.Columns[0];
            dc[1] = table.Columns[2];
            table.PrimaryKey = dc;
        }

        public void dataBingDing(DataTable table)
        {
            txt_taiKhoan.DataBindings.Clear();
            txt_matKhau.DataBindings.Clear();
            cb_nhomND_tk.DataBindings.Clear();

            txt_taiKhoan.DataBindings.Add("Text", table, table.Columns[0].ToString());
            txt_matKhau.DataBindings.Add("Text", table, table.Columns[1].ToString());
            cb_nhomND_tk.DataBindings.Add("Text", table, table.Columns[2].ToString());
        }

        public int checkPrimaryKeyExists_TaiKhoan(string ten, string loai)
        {
            String sql = "SELECT * FROM [TAIKHOAN] WHERE [TEN] = @TEN AND [LOAI] = @LOAI";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TEN", ten);
                sc.Parameters.AddWithValue("@LOAI", loai);

                SqlDataReader sdr = sc.ExecuteReader();
                if (sdr.Read() == true)
                {
                    dt.Close();
                    return 1;
                }
                dt.Close();
                return 0;
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return -1;
            }
        }

        public int checkForeignKeyExists_TaiKhoan(string ten, string loai)
        {
            String sql = "SELECT COUNT(*) FROM [SAVE_DANGNHAP] WHERE [TEN] = @TEN AND [LOAI] = @LOAI";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TEN", ten);
                sc.Parameters.AddWithValue("@LOAI", loai);

                int count = (int)sc.ExecuteScalar();
                if (count != 0)
                {
                    dt.Close();
                    return 1;
                }
                dt.Close();
                return 0;
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return -1;
            }
        }

        public int checkPrimaryKeyExists_Nhom(string tenNhom)
        {
            String sql = "SELECT * FROM [DS_NHOM] WHERE [TENNHOM] = @TEN";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TEN", tenNhom);

                SqlDataReader sdr = sc.ExecuteReader();
                if (sdr.Read() == true)
                {
                    dt.Close();
                    return 1;
                }
                dt.Close();
                return 0;
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return -1;
            }
        }

        public int checkForeignKeyExists_Nhom(string tenNhom)
        {
            String sql = "SELECT COUNT(*) FROM [TAIKHOAN] WHERE [LOAI] = @TEN";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TEN", tenNhom);

                int count = (int)sc.ExecuteScalar();
                if (count != 0)
                {
                    dt.Close();
                    return 1;
                }
                dt.Close();
                return 0;
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return -1;
            }
        }

        public int checkPrimaryKeyExists_PhanQuyen(string tenNhom, string quyen, string bang)
        {
            String sql = "SELECT * FROM [PHANQUYEN] WHERE [TEN] = @TEN AND [QUYEN] = @QUYEN AND [BANG_CHON] = @BANG";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TEN", tenNhom);
                sc.Parameters.AddWithValue("@QUYEN", quyen);
                sc.Parameters.AddWithValue("@BANG", bang);

                SqlDataReader sdr = sc.ExecuteReader();
                if (sdr.Read() == true)
                {
                    dt.Close();
                    return 1;
                }
                dt.Close();
                return 0;
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return -1;
            }
        }

        public int taoNhom(string tenNhom)
        {
            String sql = "INSERT INTO [DS_NHOM] VALUES (@TEN)";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TEN", tenNhom);
                sc.ExecuteNonQuery();

                dt.Close();
                return 1;
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return 0;
            }
        }

        public int xoaNhom(string tenNhom)
        {
            if(checkForeignKeyExists_Nhom(tenNhom)!=0)
            {
                MessageBox.Show("Không thể xóa nhóm này => Còn tồn tại tài khoản thuộc nhóm này!");
                return 0;
            }
            String sql = "DELETE FROM [DS_NHOM] WHERE [TENNHOM] = @TEN";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TEN", tenNhom);
                sc.ExecuteNonQuery();

                dt.Close();
                return 1;
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return 0;
            }
        }

        public int taoQuyen(string tenNhom, string quyen, string bang)
        {
            if(checkPrimaryKeyExists_PhanQuyen(tenNhom,quyen,bang) != 0)
            {
                MessageBox.Show("Không thể tạo quyền này => Quyền này đã tồn tại!");
                return 0;
            }
            String sql = "INSERT INTO [PHANQUYEN] VALUES(@TEN, @QUYEN, @BANG)";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TEN", tenNhom);
                sc.Parameters.AddWithValue("@QUYEN", quyen);
                sc.Parameters.AddWithValue("@BANG", bang);
                sc.ExecuteNonQuery();

                dt.Close();
                return 1;
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return 0;
            }
        }

        public int xoaQuyen(string tenNhom, string quyen, string bang)
        {
            String sql = "DELETE FROM [PHANQUYEN] WHERE [TEN] = @TEN AND [QUYEN] = @QUYEN AND [BANG_CHON] = @BANG";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TEN", tenNhom);
                sc.Parameters.AddWithValue("@QUYEN", quyen);
                sc.Parameters.AddWithValue("@BANG", bang);
                sc.ExecuteNonQuery();

                dt.Close();
                return 1;
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return 0;
            }
        }


        //------------------End hàm gọi chạy---------------



        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Visible = true;
        }

        private void btn_saoLuu_Click(object sender, EventArgs e)
        {
            String sql = "EXEC DBO.TT_BACKUP";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.ExecuteNonQuery();

                dt.Close();

                MessageBox.Show("Sao lưu dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                MessageBox.Show("Sao lưu dữ liệu không thành công!");
            }
        }

        private void btn_khoiPhuc_Click(object sender, EventArgs e)
        {
            String sql = "USE master " + "EXEC DBO.TT_RESTORE";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.ExecuteNonQuery();
                dt.Close();

                reset();
                MessageBox.Show("Khôi phục dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                MessageBox.Show("Khôi phục dữ liệu không thành công!");
            }
        }

        private void btn_resetForm_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_taiKhoan_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void txt_matKhau_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void txt_tenNhom_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void cb_quyen_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void dtg_duLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtg_duLieu.Rows[e.RowIndex];
                txt_taiKhoan.Text = row.Cells[0].Value.ToString();
                txt_matKhau.Text = row.Cells[1].Value.ToString();
                cb_nhomND_tk.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btn_them_tk_Click(object sender, EventArgs e)
        {
            if (txt_taiKhoan.Text == "" || txt_matKhau.Text == "") //Kiểm tra bỏ trống
            {
                MessageBox.Show("Không được bỏ trống các mục trên!");
                return;
            }

            int check = checkPrimaryKeyExists_TaiKhoan(txt_taiKhoan.Text, cb_nhomND_tk.Text);
            if (check != 0)
            {
                MessageBox.Show("Thêm mới thất bại (Khóa chính đã tồn tại)!");
                return;
            }
            DataRow row = tk.NewRow();
            row[0] = txt_taiKhoan.Text;
            row[1] = txt_matKhau.Text;
            row[2] = cb_nhomND_tk.Text;

            tk.Rows.Add(row);

            //Update CSDL
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);

            //Update table DA
            sda.Update(tk);

            MessageBox.Show("Thêm tài khoản thành công!");   
        }

        private void btn_xoa_tk_Click(object sender, EventArgs e)
        {
            String[] key = new String[2];
            key[0] = txt_taiKhoan.Text;
            key[1] = cb_nhomND_tk.Text;

            DataRow row = tk.Rows.Find(key);

            if (row != null)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    if (checkForeignKeyExists_TaiKhoan(key[0], key[1]) != 0)
                    {
                        MessageBox.Show("Không thể xóa tài khoản này vì tài khoản này đang đăng nhập!");
                        return;
                    }
                    row.Delete();
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.Update(tk);
                    MessageBox.Show("Xóa tài khoản thành công!");
                }

            }
        }

        private void btn_taoNhom_Click(object sender, EventArgs e)
        {
            if (txt_tenNhom.Text == "") //Kiểm tra bỏ trống
            {
                MessageBox.Show("Không được bỏ trống tên nhóm!");
                return;
            }

            int check = checkPrimaryKeyExists_Nhom(txt_tenNhom.Text);
            if (check != 0)
            {
                MessageBox.Show("Thêm mới thất bại (Nhóm đã tồn tại)!");
                return;
            }

            int kq = taoNhom(txt_tenNhom.Text);
            if(kq == 0)
            {
                MessageBox.Show("Tạo nhóm không thành công!");   
            }
            else
            {
                MessageBox.Show("Tạo nhóm thành công!");
                hienThiDSNhom();
            }
        }

        private void btn_xoaNhom_Click(object sender, EventArgs e)
        {
            if (txt_tenNhom.Text == "") //Kiểm tra bỏ trống
            {
                MessageBox.Show("Không được bỏ trống tên nhóm!");
                return;
            }

            int kq = xoaNhom(txt_tenNhom.Text);
            if (kq == 0)
            {
                MessageBox.Show("Xóa nhóm không thành công!");
            }
            else
            {
                MessageBox.Show("Xóa nhóm thành công!");
                hienThiDSNhom();
            }
        }

        private void btn_taoQuyen_Click(object sender, EventArgs e)
        {
            if (cb_quyen.Text == "") //Kiểm tra bỏ trống
            {
                MessageBox.Show("Không được bỏ trống quyền thực thi!");
                return;
            }

            int kq = taoQuyen(cb_nhomND_phanQuyen.Text, cb_quyen.Text, cb_bangDuLieu.Text);
            if (kq == 0)
            {
                MessageBox.Show("Tạo quyền không thành công!");
            }
            else
            {
                MessageBox.Show("Tạo quyền thành công!");
            }
        }

        private void btn_xoaQuyen_Click(object sender, EventArgs e)
        {
            if (cb_quyen.Text == "") //Kiểm tra bỏ trống
            {
                MessageBox.Show("Không được bỏ trống quyền thực thi!");
                return;
            }

            int kq = xoaQuyen(cb_nhomND_phanQuyen.Text, cb_quyen.Text, cb_bangDuLieu.Text);
            if (kq == 0)
            {
                MessageBox.Show("Xóa quyền không thành công!");
            }
            else
            {
                MessageBox.Show("Xóa quyền thành công!");
            }
        }





    }
}
