using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_Web_LeLuuHoangNhan_Masterpage
{
    public partial class QuanTam : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB_QLWeb_BDS.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_kq_quanTam.Text = String.Empty;
            mtv_quantam.ActiveViewIndex = 0;
            DisplayData();
            inThongTin_DangNhap();
            anNut_Insert_Delete_Edit();
        }
        private void DisplayData()
        {
            conn.Open();
            String sql = "SELECT * FROM [QUANTAM]";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dtl_QuanTam.DataSource = ds;
            dtl_QuanTam.DataBind();

            conn.Close();
        }


        protected void btn_insert_01_Click(object sender, EventArgs e)
        {
            mtv_quantam.ActiveViewIndex = 1;
        }

        protected void btn_insert_02_Click(object sender, EventArgs e)
        {
            String url = txt_url.Text.ToString();
            String tenSP = txt_tenSP.Text.ToString();
            String chiTiet = txt_chiTietSP.Text.ToString();
            String loai = txt_loai.Text.ToString();

            if (tenSP.Equals("") || chiTiet.Equals("") || loai.Equals(""))
            {
                lbl_kq_quanTam.Text = "Thêm thất bại. Không được bỏ trống các mục trên (Trừ URL)!";
            }
            else
            {
                String sql = "";
                if (!url.Equals(""))
                {
                    sql = "SELECT * FROM [QUANTAM] WHERE [IMG]=@URL AND [TENSP]=@TENSP AND [CHITIET_SP]=@CHITIET AND [LOAI]=@LOAI";
                }
                else
                {
                    sql = "SELECT * FROM [QUANTAM] WHERE [TENSP]=@TENSP AND [CHITIET_SP]=@CHITIET AND [LOAI]=@LOAI";
                }

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (!url.Equals(""))
                    {
                        cmd.Parameters.AddWithValue("@URL", url);
                    }
                    cmd.Parameters.AddWithValue("@TENSP", tenSP);
                    cmd.Parameters.AddWithValue("@CHITIET", chiTiet);
                    cmd.Parameters.AddWithValue("@LOAI", loai);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    int kt = 0;
                    while (sdr.Read())
                    {
                        kt++;
                    }
                    conn.Close();

                    if (kt != 0)
                    {
                        txt_url.Text = txt_tenSP.Text = txt_chiTietSP.Text = txt_loai.Text = string.Empty;
                        mtv_quantam.ActiveViewIndex = 0;
                        lbl_kq_quanTam.Text = "Thêm thất bại. Sản phẩm đã tồn tại!";
                    }
                    else
                    {
                        String sql_1 = "";
                        if (!url.Equals(""))
                        {
                            sql_1 = "INSERT INTO [QUANTAM] ([IMG],[TENSP],[CHITIET_SP],[LOAI]) " +
                                    "VALUES(@URL,@TENSP,@CHITIET,@LOAI)";
                        }
                        else
                        {
                            sql_1 = "INSERT INTO [QUANTAM] ([TENSP],[CHITIET_SP],[LOAI]) " +
                                    "VALUES(@TENSP,@CHITIET,@LOAI)";
                        }

                        try
                        {
                            conn.Open();
                            SqlCommand cmd_1 = new SqlCommand(sql_1, conn);
                            if (!url.Equals(""))
                            {
                                cmd_1.Parameters.AddWithValue("@URL", url);
                            }
                            cmd_1.Parameters.AddWithValue("@TENSP", tenSP);
                            cmd_1.Parameters.AddWithValue("@CHITIET", chiTiet);
                            cmd_1.Parameters.AddWithValue("@LOAI", loai);
                            cmd_1.ExecuteNonQuery();

                            conn.Close();

                            txt_url.Text = txt_tenSP.Text = txt_chiTietSP.Text = txt_loai.Text = string.Empty;
                            mtv_quantam.ActiveViewIndex = 0;
                            lbl_kq_quanTam.Text = "Thêm thành công!";
                            DisplayData();
                        }
                        catch (Exception ex)
                        {
                            lbl_kq_quanTam.Text = "Thêm thất bại. Erro soure code! (1)";
                        }
                    }
                }
                catch (Exception ex)
                {
                    lbl_kq_quanTam.Text = "Thêm thất bại. Erro soure code! (2)";
                }

            }
        }




        //-------------VIẾT DELETE DATALIST---------------
        protected void btn_delete_01_Click(object sender, EventArgs e)
        {
            mtv_quantam.ActiveViewIndex = 2;
        }

        protected void btn_delete_02_Click(object sender, EventArgs e)
        {
            String id = txt_id_delete.Text.ToString();
            if(id.Equals(""))
            {
                lbl_kq_quanTam.Text = "Không được bỏ trống mã bài viết!";
            }
            else
            {
                //Kiểm tra mã bài viết có tồn tại không
                String sql = "SELECT * FROM [QUANTAM] WHERE [ID]=@ID";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    int kt = 0;
                    while(sdr.Read())
                    {
                        kt++;
                    }
                    conn.Close();

                    //ID cần xóa tồn tại
                    if (kt!=0)
                    {
                        String sql1 = "DELETE FROM [QUANTAM] WHERE [ID]=@ID";
                        try
                        {
                            conn.Open();
                            SqlCommand cmd1 = new SqlCommand(sql1, conn);
                            cmd1.Parameters.AddWithValue("@ID", id);
                            cmd1.ExecuteNonQuery();

                            conn.Close();

                            mtv_quantam.ActiveViewIndex = 0;
                            DisplayData();
                            lbl_kq_quanTam.Text = "Xóa dữ liệu mã bài viết " + Convert.ToString(id) + " thành công!";
                        }
                        catch(Exception ex)
                        {
                            lbl_kq_quanTam.Text = "Erro delete (2).";
                        }
                    }
                    else //ID cần xóa không tồn tại
                    {
                        lbl_kq_quanTam.Text = "Mã bài viết cần xóa không tồn tại!";
                    }
                }
                catch(Exception ex)
                {
                    lbl_kq_quanTam.Text = "Erro delete (1).";
                }
            }
        }



        //-------------VIẾT EDIT DATALIST---------------
        protected void btn_edit_01_Click(object sender, EventArgs e)
        {
            mtv_quantam.ActiveViewIndex = 3;
        }


        protected void btn_edit_02_Click(object sender, EventArgs e)
        {
            String id = txt_id_edit.Text.ToString();
            if (id.Equals(""))
            {
                lbl_kq_quanTam.Text = "Không được bỏ trống mã bài viết!";
            }
            else
            {
                //Kiểm tra mã bài viết có tồn tại không
                String sql = "SELECT * FROM [QUANTAM] WHERE [ID]=@ID";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    int kt = 0;
                    while (sdr.Read())
                    {
                        kt++;
                    }
                    conn.Close();
                    
                    if(kt!=0)//Bài viết có tồn tại
                    {
                        Update(id);
                    }
                    else
                    {
                        lbl_kq_quanTam.Text = "Mã bài viết không tồn tại!";
                    }

                }
                catch(Exception ex)
                {
                    lbl_kq_quanTam.Text = "Erro edit (1).";
                }
            }
        }


        protected void Update(String ID)
        {
            String url = txt_url_edit.Text.ToString();
            String tenSP = txt_tenSP_edit.Text.ToString();
            String chiTiet = txt_chiTietSP_edit.Text.ToString();
            String loai = txt_loai_edit.Text.ToString();

            if (tenSP.Equals("") || chiTiet.Equals("") || loai.Equals(""))
            {
                lbl_kq_quanTam.Text = "Không được bỏ trống Tên sản phẩm, Chi tiết sản phẩm, Loại sản phẩm!";
            }
            else
            {
                String sql = "UPDATE [QUANTAM] SET [IMG]=@URL, [TENSP]=@TENSP, [CHITIET_SP]=@CHITIET, [LOAI]=@LOAI WHERE [ID]=@ID ";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (url.Equals(""))
                    {
                        cmd.Parameters.AddWithValue("@URL", "img/Default.jpg");

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@URL", url);
                    }
                    cmd.Parameters.AddWithValue("@TENSP", tenSP);
                    cmd.Parameters.AddWithValue("@CHITIET", chiTiet);
                    cmd.Parameters.AddWithValue("@LOAI", loai);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    mtv_quantam.ActiveViewIndex = 0;
                    DisplayData();
                    lbl_kq_quanTam.Text = "Cập nhật dữ liệu thành công!";
                }
                catch (Exception ex)
                {
                    lbl_kq_quanTam.Text = "Erro update (2).";
                }
            }
        }



        //-------------VIẾT TÌM KIẾM DATALIST---------------
        protected void btn_timKiem_01_Click(object sender, EventArgs e)
        {
            mtv_quantam.ActiveViewIndex = 4;
        }

        protected void btn_timKiem_02_Click(object sender, EventArgs e)
        {
            String id = txt_id_timKiem.Text.ToString();
            if(id.Equals(""))
            {
                lbl_kq_quanTam.Text = "Không được bỏ trống mã bài viết cần tìm!";
            } 
            else
            {
                String sql = "SELECT * FROM [QUANTAM] WHERE [ID]=@ID";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    int kt = 0;
                    while(sdr.Read())
                    {
                        kt++;
                    }    
                    if(kt!=0)//Tìm thấy
                    {
                        sdr.Close();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dtl_QuanTam.DataSource = ds;
                        dtl_QuanTam.DataBind();
                    }
                    else
                    {
                        lbl_kq_quanTam.Text = "Không tìm thấy mã bài viết bạn vừa nhập!";
                    }

                    conn.Close();

                }
                catch(Exception ex)
                {
                    lbl_kq_quanTam.Text = "Erro tìm kiếm (1).!";
                }
            }    
        }




        //-------------VIẾT NÚT RESET (LÀM MỚI)---------------
        protected void btn_lamMoi_Click(object sender, EventArgs e)
        {
            mtv_quantam.ActiveViewIndex = 0;
            DisplayData();
        }


        //---------------In tên tài khoản đăng nhập-------------
        public void inThongTin_DangNhap()
        {
            String sql = "SELECT [TEN],[LOAI] FROM [LUU_DANGNHAP]";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                lbl_userName.Text = "Vô danh";
                lbl_loai.Text = "(Chưa đăng nhập)";
                while (sdr.Read())
                {
                    lbl_userName.Text = "Xin chào: " + sdr.GetString(0);
                    if(sdr.GetString(1).Equals("KH"))
                    {
                        lbl_loai.Text = "(Khách hàng)";
                    }    
                    else
                    {
                        lbl_loai.Text = "(Admin)";
                    }    
                }    
                conn.Close();
            }
            catch(Exception ex)
            {
                lbl_userName.Text = "Lỗi lấy thông tin khách hàng!";
            }
        }



        //---------------Nếu là tài khoản khách hàng (Ẩn nút insert + delete + edit)-------------
        public void anNut_Insert_Delete_Edit()
        {
            String sql = "SELECT [LOAI] FROM [LUU_DANGNHAP]";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                btn_insert_01.Enabled = false;
                btn_edit_01.Enabled = false;
                btn_delete_01.Enabled = false;
                while (sdr.Read())
                {
                    if (!sdr.GetString(0).Equals("KH"))
                    {
                        btn_insert_01.Enabled = true;
                        btn_edit_01.Enabled = true;
                        btn_delete_01.Enabled = true;
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                lbl_userName.Text = "Lỗi ẩn nút insert, delete, edit!";
            }
        }



    }

}