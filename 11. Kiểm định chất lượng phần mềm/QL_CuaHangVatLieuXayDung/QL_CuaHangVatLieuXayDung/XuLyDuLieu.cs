using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QL_CuaHangVatLieuXayDung
{
    public class XuLyDuLieu
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        AppSetting appsetting = new AppSetting();
        public XuLyDuLieu()
        {
            //string chuoiketnoi = "server = DESKTOP-TIOKQ0E; database = QLSINHVIEN; Integrated Security = true";
            //string chuoiketnoi = "server = DESKTOP-TIOKQ0E; database = QLSINHVIEN; Integrated Security = false; user id = sa; password = 123";
            string chuoiketnoi = appsetting.getConnectionString("QL_CuaHangVLXDConnectionString");
            con = new SqlConnection(chuoiketnoi);
        }

        public bool testConnection(string connectionString)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public XuLyDuLieu(string sv, string db, bool au, string uid, string pwd)
        {
            string chuoiketnoi = "";
            if (au == true)
                chuoiketnoi = string.Format(@"Data source = {0}; Initial Catalog = {1}; Integrated Security = {2};", sv, db, au);
            else
                chuoiketnoi = string.Format(@"Data source = {0}; Initial Catalog = {1}; Integrated Security = false; uid = {2}; pwd = {3}", sv, db, uid, pwd);
            con = new SqlConnection(chuoiketnoi);
        }
        public DataTable DocDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void CapNhat(string lenhsql, DataTable dt)//Cap nhat 1 bang xuong databasse
        {
            da = new SqlDataAdapter(lenhsql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(dt);
        }

        public int ThemXoaSua(string sql)//Them xoa sua 1 dong vao database
        {
            if(con.State == ConnectionState.Closed)
                con.Open();
            cmd = new SqlCommand(sql, con);
            int kq = cmd.ExecuteNonQuery();
            con.Close();
            return kq;
        }

        public void DangNhap(string lenhsql)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(lenhsql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công !");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại !");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối lỗi !");
            }
        }

        public void Open()
        {
            con.Open();
        }

        public void Close()
        {
            con.Close();
        }
    }
}
