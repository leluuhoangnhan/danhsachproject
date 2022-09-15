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
    public partial class Menu : Form
    {
        DB_QLDA dt = new DB_QLDA();

        public Menu()
        {
            InitializeComponent();
        }

        //------------------HÀM GỌI CHẠY-------------------
        public string layTenTK_DangNhap()
        {
            string value = "";
            String sql = "SELECT [TEN] FROM [SAVE_DANGNHAP]";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                value = (string)sc.ExecuteScalar();
                dt.Close();
            }
            catch(Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
            }

            return value;
        }

        public int ktAdmin(string ten)
        {
            String sql = "SELECT [LOAI] FROM [TAIKHOAN] WHERE [TEN] = @TEN";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TEN", ten);
                SqlDataReader sdr = sc.ExecuteReader();
                while(sdr.Read())
                {
                    string loai = sdr.GetString(0);
                    if (loai.Equals("Quan_tri"))
                    {
                        dt.Close();
                        return 1;
                    }    
                }
                dt.Close();
                return 0;
            }
            catch(Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return -1;
            }
        }

        public int checkQuyen(string tenBang, string tenQuyen, string tenTK)
        {
            String sql = "SELECT * FROM [PHANQUYEN] WHERE [BANG_CHON] = @TENBANG AND ([QUYEN] = @TENQUYEN OR [QUYEN] = 'ALL') AND [TEN] IN (SELECT [LOAI] FROM [TAIKHOAN] WHERE [TEN] = @TENTK GROUP BY [LOAI])";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@TENBANG", tenBang);
                sc.Parameters.AddWithValue("@TENQUYEN", tenQuyen);
                sc.Parameters.AddWithValue("@TENTK", tenTK);
                SqlDataReader sdr = sc.ExecuteReader();
                while(sdr.Read())
                {
                    dt.Close();
                    return 1;
                }

                dt.Close();
                return 0;
            }
            catch(Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return -1;
            }
        }


        //------------------END HÀM GỌI CHẠY-------------------


        private void btn_ok_Click(object sender, EventArgs e)
        {
            string tenTK = layTenTK_DangNhap();
            string tenQuyen = "SELECT";

            if (cb_menu.Text.ToLower() == "")
            {
                MessageBox.Show("Chưa chọn bảng cần mở!");
            }
            else if(cb_menu.Text.ToLower() == "chủ đầu tư")
            {
                string tenBang = "CHUDAUTU";
                int admin = ktAdmin(tenTK);
                int quyen = checkQuyen(tenBang, tenQuyen, tenTK);

                if(admin == 1 || quyen == 1)
                {
                    this.Hide();
                    ChuDauTu cdt = new ChuDauTu();
                    cdt.Visible = true;
                }
                else
                {
                    MessageBox.Show("Bạn chưa được cấp quyền truy cập mục này!");
                }
            }
            else if (cb_menu.Text.ToLower() == "dự án")
            {
                string tenBang = "DUAN";
                int admin = ktAdmin(tenTK);
                int quyen = checkQuyen(tenBang, tenQuyen, tenTK);

                if (admin == 1 || quyen == 1)
                {
                    this.Hide();
                    DuAn da = new DuAn();
                    da.Visible = true;
                }
                else
                {
                    MessageBox.Show("Bạn chưa được cấp quyền truy cập mục này!");
                }
            }
            else if (cb_menu.Text.ToLower() == "khách hàng")
            {
                string tenBang = "KHACHHANG";
                int admin = ktAdmin(tenTK);
                int quyen = checkQuyen(tenBang, tenQuyen, tenTK);

                if (admin == 1 || quyen == 1)
                {
                    this.Hide();
                    KhachHang kh = new KhachHang();
                    kh.Visible = true;
                }
                else
                {
                    MessageBox.Show("Bạn chưa được cấp quyền truy cập mục này!");
                }
            }
            else if (cb_menu.Text.ToLower() == "khu đất")
            {
                string tenBang = "KHUDAT";
                int admin = ktAdmin(tenTK);
                int quyen = checkQuyen(tenBang, tenQuyen, tenTK);

                if (admin == 1 || quyen == 1)
                {
                    this.Hide();
                    KhuDat kd = new KhuDat();
                    kd.Visible = true;
                }
                else
                {
                    MessageBox.Show("Bạn chưa được cấp quyền truy cập mục này!");
                }
            }
            else if (cb_menu.Text.ToLower() == "thuế")
            {
                string tenBang = "THUE";
                int admin = ktAdmin(tenTK);
                int quyen = checkQuyen(tenBang, tenQuyen, tenTK);

                if (admin == 1 || quyen == 1)
                {
                    this.Hide();
                    Thue t = new Thue();
                    t.Visible = true;
                }
                else
                {
                    MessageBox.Show("Bạn chưa được cấp quyền truy cập mục này!");
                }
            }
            else if (cb_menu.Text.ToLower() == "phân quyền")
            {
                int admin = ktAdmin(tenTK);
                if(admin == 1)
                {
                    this.Hide();
                    PhanQuyen pq = new PhanQuyen();
                    pq.Visible = true;
                }
                else
                {
                    MessageBox.Show("Chỉ tài khoản admin mới được sử dụng!");
                }
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại!");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM SAVE_DANGNHAP";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.ExecuteNonQuery();
                dt.Close();

                this.Hide();
                DangNhap dn = new DangNhap();
                dn.Visible = true;
                MessageBox.Show("Đăng xuất thành công!");
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                MessageBox.Show("Đăng xuất không thành công!");
            }
        }
    }
}
