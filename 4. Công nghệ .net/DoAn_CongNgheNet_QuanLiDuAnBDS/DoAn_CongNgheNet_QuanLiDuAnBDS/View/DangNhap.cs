using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAn_CongNgheNet_QuanLiDuAnBDS.Model;

namespace DoAn_CongNgheNet_QuanLiDuAnBDS
{
    public partial class DangNhap : Form
    {
        DB_QLDA dt = new DB_QLDA();


        public DangNhap()
        {
            InitializeComponent();
        }

        //-----------------------Hàm gọi chạy---------------------------
        public int luuTaiKhoanVaoSave_DangNhap(string ten, string pass, string loai)
        {
            if(ten.Equals("") || pass.Equals("") || loai.Equals(""))
            {
                MessageBox.Show("Erro nhap tai khoan vao Save_DangNhap (1)!");
                return 0;
            }

            string sql = "DELETE FROM SAVE_DANGNHAP";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.ExecuteNonQuery();

                string sql1 = "INSERT INTO [SAVE_DANGNHAP] VALUES(@TEN, @PASS, @LOAI)";
                try
                {
                    SqlCommand sc1 = new SqlCommand(sql1, dt.conn);
                    sc1.Parameters.AddWithValue("@TEN", ten);
                    sc1.Parameters.AddWithValue("@PASS", pass);
                    sc1.Parameters.AddWithValue("@LOAI", loai);
                    sc1.ExecuteNonQuery();
                    dt.Close();

                    return 1;
                }
                catch(Exception ex)
                {
                    if (dt.checkConnect() == true)
                        dt.Close();
                    MessageBox.Show("Erro nhap tai khoan vao Save_DangNhap (3)!");
                    return 0;
                }
            }
            catch(Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                MessageBox.Show("Erro Clear Save_DangNhap (2)!");
                return 0;
            }
        }


        //-----------------------End hàm gọi chạy-----------------------

        private void txt_ten_Leave(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if (ct.Text.Length == 0)
                this.errorProvider1.SetError(ct, "Không được bỏ trống tên đăng nhập");
            else
                this.errorProvider1.Clear();
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if (ct.Text.Length == 0)
                this.errorProvider1.SetError(ct, "Không được bỏ trống mật khẩu");
            else
                this.errorProvider1.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            if(txt_pass.Text.Length==0 || txt_ten.Text.Length==0)
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập và mật khẩu!");
                return;
            }
            try {
                dt.Open();
                String sql = "INSERT INTO [TAIKHOAN] ([TEN], [PASS], [LOAI]) " + "VALUES (@TEN, @PASS, @LOAI)";
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.Add("@TEN", txt_ten.Text);
                sc.Parameters.Add("@PASS", txt_pass.Text);
                sc.Parameters.Add("@Loai", "Thong_thuong");
                sc.ExecuteNonQuery();

                dt.Close();
                MessageBox.Show("Đăng ký tài khoản thành công!"); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đăng ký tài khoản thất bại!");
                dt.Close();
            }

        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text.Length == 0 || txt_ten.Text.Length == 0)
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập và mật khẩu!");
                return;
            }
            try
            {
                dt.Open();
                String sql = "SELECT TOP 1 [LOAI] FROM [TAIKHOAN] WHERE [TEN] = @TEN AND [PASS] = @PASS";
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.Add("@TEN", txt_ten.Text);
                sc.Parameters.Add("@PASS", txt_pass.Text);

                string loai = (string)sc.ExecuteScalar();

                if (loai == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    dt.Close();
                    return;
                }
                dt.Close();

                this.Hide();
                Menu menu = new Menu();
                menu.Visible = true;
                MessageBox.Show("Đăng nhập thành công!");

                int save = luuTaiKhoanVaoSave_DangNhap(txt_ten.Text, txt_pass.Text, loai);
                if(save != 0)
                {
                    MessageBox.Show("Lưu thông tin đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Lưu thông tin đăng nhập không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại. Erro (1)!");
                dt.Close();
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_ten.Text = txt_pass.Text = string.Empty;
            txt_ten.Focus();
        }
    }
}
