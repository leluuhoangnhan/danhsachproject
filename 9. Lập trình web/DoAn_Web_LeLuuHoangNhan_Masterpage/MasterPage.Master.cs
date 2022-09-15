using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;


namespace DoAn_Web_LeLuuHoangNhan_Masterpage
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            out_thongbao_submit.Text = string.Empty;
            master_lbl_kq_dangNhap.Text= master_lbl_kq_dangKy.Text= master_lbl_chucMung.Text= string.Empty;
        }



        //-----Đăng nhập, đăng ký
        //----------------Mã hóa password bằng MD5.-------------
        public string maHoa(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        protected void btn_open_login_Click(object sender, EventArgs e)
        {
            master_btn_login_img.Visible = false;
            master_mtv_login.ActiveViewIndex = 0;
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            String pass = maHoa(master_txt_pass.Text.ToString());
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB_QLWeb_BDS.mdf;Integrated Security=True";
            conn.Open();

            String sql = "SELECT [NAME], [LOAI] FROM [LOGIN] WHERE [USERNAME]=@USER AND [PASSWORD]=@PASS";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@USER", master_txt_user.Text);
            cmd.Parameters.AddWithValue("@PASS", pass);


            SqlDataReader sdr = cmd.ExecuteReader();
            String name = "";
            String loai = "";
            while (sdr.Read())
            {
                name = sdr.GetString(0);
                loai = sdr.GetString(1);
            }
            conn.Close();


            if (!name.Equals("") && !loai.Equals(""))   //Đăng nhập thành công
            {
                //----------Start Code Mới
                String sql1 = "DELETE FROM [LUU_DANGNHAP]";
                try
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    cmd1.ExecuteNonQuery();

                    conn.Close();

                    String sql2 = "INSERT INTO [LUU_DANGNHAP] ([USER],[TEN],[LOAI]) VALUES(@USER,@TEN,@LOAI)";
                    try
                    {
                        conn.Open();
                        SqlCommand cmd2 = new SqlCommand(sql2, conn);
                        cmd2.Parameters.AddWithValue("@USER", master_txt_user.Text);
                        cmd2.Parameters.AddWithValue("@TEN", name);
                        cmd2.Parameters.AddWithValue("@LOAI", loai);
                        cmd2.ExecuteNonQuery();

                        conn.Close();
                        master_lbl_chucMung.Text = "Đăng nhập thành công!\n";
                    }
                    catch(Exception ex)
                    {
                        master_lbl_chucMung.Text = "Đăng nhập thành công! <br /><br />(Lưu dữ liệu không thành công (2))\n";
                    }
                }
                catch(Exception ex)
                {
                    master_lbl_chucMung.Text = "Đăng nhập thành công! <br /><br />(Lưu dữ liệu không thành công (1))\n";
                }

                //------------End Code Mới


                master_mtv_login.ActiveViewIndex = 2;
                //master_lbl_chucMung.Text = "Đăng nhập thành công.\n";
                master_lbl_chaoMung.Text = "Xin chào:";
                master_lbl_chaoMung_HoTen.Text = lay_HoTen(master_txt_user.Text.ToString());
                master_txt_user.Text = master_txt_pass.Text = string.Empty;
            }
            else
            {
                master_lbl_kq_dangNhap.Text = "Đăng nhập không thành công!";
            }

            
        }

        protected void btn_registration_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            String pass = maHoa(master_txt_pass_DK.Text.ToString());
            String pass_XN = maHoa(master_txt_pass_XN_DK.Text.ToString());
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB_QLWeb_BDS.mdf;Integrated Security=True";
            conn.Open();
            if (master_txt_hoTen_DK.Text.Equals("") || master_txt_user_DK.Text.Equals("") || master_txt_pass_DK.Text.ToString().Equals("") || master_txt_pass_XN_DK.Text.ToString().Equals(""))
            {
                master_lbl_kq_dangKy.Text = "Không được bỏ trống các mục nào phía trên!!!";
            }
            else if (!pass.Equals(pass_XN))
            {
                master_lbl_kq_dangKy.Text = "\nPassword xác nhận không chính xác!";
            }
            else
            {
                String sql = "INSERT INTO [LOGIN] ([NAME],[USERNAME],[PASSWORD]) " +
                           "VALUES(@NAME,@USER,@PASS)";
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@NAME", master_txt_hoTen_DK.Text);
                    cmd.Parameters.AddWithValue("@USER", master_txt_user_DK.Text);
                    cmd.Parameters.AddWithValue("@PASS", pass);
                    cmd.ExecuteNonQuery();

                    master_txt_hoTen_DK.Text = master_txt_user_DK.Text = master_txt_pass_DK.Text = master_txt_pass_XN_DK.Text = master_txt_user.Text= master_txt_pass.Text = string.Empty;
                    master_mtv_login.ActiveViewIndex = 0;
                    master_lbl_kq_dangNhap.Text = "Đăng ký thành công!";
                }
                catch (Exception ex)
                {
                    master_lbl_kq_dangKy.Text = "Đăng ký thất bại!";
                }
            }

            conn.Close();

        }

        protected void btn_quayLai_DangNhap_Click(object sender, EventArgs e)
        {
            master_txt_user.Text = master_txt_pass.Text = string.Empty;
            master_mtv_login.ActiveViewIndex = 0;
        }

        protected void btn_registration_Click1(object sender, EventArgs e)
        {
            master_txt_hoTen_DK.Text = master_txt_user_DK.Text = master_txt_pass_DK.Text = master_txt_pass_XN_DK.Text = string.Empty;
            master_mtv_login.ActiveViewIndex = 1;
        }

        protected void btn_dangXuat_Click(object sender, EventArgs e)
        {
            master_lbl_chucMung.Text = master_lbl_chaoMung.Text = master_lbl_chaoMung_HoTen.Text = string.Empty;
            master_txt_user.Text = master_txt_pass.Text = string.Empty;
            master_mtv_login.ActiveViewIndex = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB_QLWeb_BDS.mdf;Integrated Security=True";
            String sql = "DELETE FROM [LUU_DANGNHAP]";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                master_lbl_kq_dangNhap.Text = "Đăng xuất thành công!";
            }
            catch(Exception ex)
            {
                master_lbl_kq_dangNhap.Text = "Đăng xuất thất bại!";
            }
        }

        public string lay_HoTen(String user)
        {
            string ht= "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB_QLWeb_BDS.mdf;Integrated Security=True";
            conn.Open();
            string sql = "SELECT NAME FROM [LOGIN] WHERE [USERNAME]=@USER";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@USER", user);
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    ht = sdr.GetString(0);
                }    
            }
            catch(Exception e)
            {

            }
            conn.Close();

            return ht;
        }



        //---------BIỂU MẪU LIÊN HỆ
        protected void btn_guiBieuMau_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            String email = maHoa(master_txt_email.Text.ToString());
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB_QLWeb_BDS.mdf;Integrated Security=True";
            conn.Open();
            if (master_txt_ten.Text.Equals("") || master_txt_email.Text.ToString().Equals("") || master_txt_thongbao.Text.Equals(""))
            {
                out_thongbao_submit.Text = "Không được bỏ trống mục nào phía trên!";
            }
            else
            {
                String sql = "INSERT INTO [BIEUMAU] ([HOTEN],[EMAIL],[THONGBAO]) " +
                           "VALUES(@HOTEN,@EMAIL,@THONGBAO)";
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@HOTEN", master_txt_ten.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@THONGBAO", master_txt_thongbao.Text);
                    cmd.ExecuteNonQuery();

                    master_txt_ten.Text = master_txt_thongbao.Text = master_txt_email.Text = string.Empty;

                    out_thongbao_submit.Text = "Gửi thông báo thành công.";
                }
                catch (Exception ex)
                {
                    out_thongbao_submit.Text = "Gửi thông báo thất bại.";
                }
            }

            conn.Close();

        }
    }
}