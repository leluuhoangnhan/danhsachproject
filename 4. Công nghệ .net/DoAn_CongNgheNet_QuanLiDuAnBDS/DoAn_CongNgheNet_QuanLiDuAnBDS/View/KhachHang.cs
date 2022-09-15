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
    public partial class KhachHang : Form
    {
        DB_QLDA dt = new DB_QLDA();
        DataTable kh;
        SqlDataAdapter sda;

        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            loadDefault();
        }

        //------------------Hàm gọi chạy---------------
        public void loadDefault()
        {
            docDuLieuLenTable();
            hienThiDSDuAn();

            txt_soLuong_KH.Text = goi_Ham_DemSL_SK().ToString();
            txt_maKH_Max.Text = goiHam_TimKH_GiaoDichMax();
            txt_duAn_Max.Text = goiHam_LayTenDA_GiaoDichMax();


            //Phân quyền
            string tenTK = layTenTK_DangNhap();
            int admin = ktAdmin(tenTK);
            if (admin != 1) //Không phải là admin
            {
                int insert = checkQuyen("KHACHHANG", "INSERT", tenTK);
                if (insert != 1) //Không có quyền insert
                {
                    btn_them.Visible = false;
                }

                int delete = checkQuyen("KHACHHANG", "DELETE", tenTK);
                if (delete != 1) //Không có quyền delete
                {
                    btn_xoa.Visible = false;
                }

                int update = checkQuyen("KHACHHANG", "UPDATE", tenTK);
                if (update != 1) //Không có quyền update
                {
                    btn_sua.Visible = false;
                }

                if (btn_them.Visible == false && btn_sua.Visible == false)
                {
                    btn_luu.Visible = false;
                }
            }

        }

        public void ktNhapDuLieu(Control ct)
        {
            if (ct.Text.Length == 0)
                this.errorProvider1.SetError(ct, "Không được bỏ trống!");
            else
                this.errorProvider1.Clear();
        }

        public void hienThiDSDuAn()
        {
            String sql = "SELECT * FROM [DUAN]";
            SqlDataAdapter sda1 = new SqlDataAdapter(sql, dt.conn);

            DataTable duAn = new DataTable();
            sda1.Fill(duAn);

            cb_maDA.DataSource = duAn;
            cb_maDA.DisplayMember = "MADUAN";
            cb_maDA.ValueMember = "MADUAN";
        }

        public void docDuLieuLenTable()
        {
            kh = new DataTable();
            String sql = "SELECT * FROM [KHACHHANG]";
            sda = new SqlDataAdapter(sql, dt.conn);
            sda.Fill(kh);

            dtg_duLieu.DataSource = kh;
            taoKhoaChinh(kh);
            dataBingDing(kh);
        }

        public void taoKhoaChinh(DataTable table)
        {
            DataColumn[] dc = new DataColumn[2];
            dc[0] = table.Columns[0];
            dc[1] = table.Columns[5];
            table.PrimaryKey = dc;
        }

        public void dataBingDing(DataTable table)
        {
            txt_maKH.DataBindings.Clear();
            txt_hoTen.DataBindings.Clear();
            dtp_ngaySinh.DataBindings.Clear();
            txt_gioiTinh.DataBindings.Clear();
            dtp_ngayMuaThue.DataBindings.Clear();
            cb_maDA.DataBindings.Clear();


            txt_maKH.DataBindings.Add("Text", table, table.Columns[0].ToString());
            txt_hoTen.DataBindings.Add("Text", table, table.Columns[1].ToString());
            dtp_ngaySinh.DataBindings.Add("Text", table, table.Columns[2].ToString());
            txt_gioiTinh.DataBindings.Add("Text", table, table.Columns[3].ToString());
            dtp_ngayMuaThue.DataBindings.Add("Text", table, table.Columns[4].ToString());
            cb_maDA.DataBindings.Add("Text", table, table.Columns[5].ToString());
        }

        public void nhapValueColumn(string line, DataTable table)
        {
            string[] value = line.Split(';'); //Đọc từng giá trị trên dòng
            DataColumn maKH = new DataColumn(value[0]);
            DataColumn hoTen = new DataColumn(value[1]);
            DataColumn ngaySinh = new DataColumn(value[2]);
            DataColumn gioiTinh = new DataColumn(value[3]);
            DataColumn ngayMua_Thue = new DataColumn(value[4]);
            DataColumn maDA = new DataColumn(value[5]);

            table.Columns.Add(maKH);
            table.Columns.Add(hoTen);
            table.Columns.Add(ngaySinh);
            table.Columns.Add(gioiTinh);
            table.Columns.Add(ngayMua_Thue);
            table.Columns.Add(maDA);

            taoKhoaChinh(table);

        }

        public void nhapValueRow(string line, DataTable table)
        {
            string[] value = line.Split(';'); //Đọc từng giá trị trên dòng

            table.Rows.Add(value[0], value[1], value[2], value[3], value[4], value[5]);
        }

        public int checkPrimaryKeyExists(string maKH, string maDA)
        {
            String sql = "SELECT * FROM [KHACHHANG] WHERE [MAKH] = @MAKH AND [MADUAN] = @MADA";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@MAKH", maKH);
                sc.Parameters.AddWithValue("@MADA", maDA);

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

        public int nhapDataVaoSQL()
        {
            int kq = 0;
            for (int i = 0; i < dtg_duLieu.Rows.Count - 1; i++)
            {
                string maKH = dtg_duLieu.Rows[i].Cells[0].Value.ToString();
                string maDA = dtg_duLieu.Rows[i].Cells[5].Value.ToString();

                int ktKhoaChinh = checkPrimaryKeyExists(maKH, maDA);
                if (ktKhoaChinh == 0)
                {
                    String sql = "SET DATEFORMAT DMY " + "INSERT INTO [KHACHHANG] ([MAKH], [HOTEN], [NGAYSINH], [GTINH], [NGAYMUA_THUE], [MADUAN]) VALUES(@MAKH, @HOTEN, @NGAYSINH, @GTINH, @NGAYMUA_THUE, @MADUAN)";
                    try
                    {
                        string[] date = dtg_duLieu.Rows[i].Cells[2].Value.ToString().Split(' ');
                        string[] date1 = dtg_duLieu.Rows[i].Cells[4].Value.ToString().Split(' ');

                        dt.Open();
                        SqlCommand sc = new SqlCommand(sql, dt.conn);
                        sc.Parameters.AddWithValue("@MAKH", dtg_duLieu.Rows[i].Cells[0].Value.ToString());
                        sc.Parameters.AddWithValue("@HOTEN", dtg_duLieu.Rows[i].Cells[1].Value.ToString());
                        sc.Parameters.AddWithValue("@NGAYSINH", date[0].ToString());
                        sc.Parameters.AddWithValue("@GTINH", dtg_duLieu.Rows[i].Cells[3].Value.ToString());
                        sc.Parameters.AddWithValue("@NGAYMUA_THUE", date1[0].ToString());
                        sc.Parameters.AddWithValue("@MADUAN", dtg_duLieu.Rows[i].Cells[5].Value.ToString());
                        sc.ExecuteNonQuery();

                        dt.Close();
                        kq++;
                    }
                    catch (Exception ex)
                    {
                        if (dt.checkConnect() == true)
                            dt.Close();
                        MessageBox.Show("Lỗi nhập dữ liệu từ data grid view vào sql dong thu " + i);
                    }
                }
            }

            return kq;
        }

        public void reset()
        {
            this.Hide();
            KhachHang kh = new KhachHang();
            kh.Visible = true;
        }

        public int goi_Ham_DemSL_SK()
        {
            int sl = 0;
            String sql = "SELECT DBO.HAM_DEMSO_KH()";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sl = (int)sc.ExecuteScalar();

                dt.Close();
            }
            catch (Exception e)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                return -1;
            }
            return sl;
        }

        public string goiHam_TimKH_GiaoDichMax()
        {
            string maKH = "";
            string sql = "SELECT DBO.HAM_LAY_MAKH_GIAODICH_MAX()";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                maKH = (string)sc.ExecuteScalar();

                dt.Close();
            }
            catch (Exception e)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
            }
            return maKH;
        }

        public string goiHam_LayTenDA_GiaoDichMax()
        {
            string tenDA = "";
            string sql = "SELECT DBO.HAM_LAY_TENDA_GIAODICH_MAX()";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                tenDA = (string)sc.ExecuteScalar();

                dt.Close();
            }
            catch (Exception e)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
            }
            return tenDA;
        }

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
            catch (Exception ex)
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
                while (sdr.Read())
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
            catch (Exception ex)
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
                while (sdr.Read())
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


        //------------------End hàm gọi chạy---------------


        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Visible = true;
        }

        private void txt_maKH_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void txt_hoTen_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void dtp_ngaySinh_Leave(object sender, EventArgs e)
        {
            DateTime ngay_sinh = dtp_ngaySinh.Value.Date;
            if (DateTime.Compare(ngay_sinh, DateTime.Now) > 0)
                this.errorProvider1.SetError((Control)sender, "Ngày sinh phải bé hơn hoặc bằng ngày hiện tại!");
            else
                this.errorProvider1.Clear();
        }

        private void dtp_ngayMuaThue_Leave(object sender, EventArgs e)
        {
            DateTime ngayMuaThue = dtp_ngayMuaThue.Value.Date;
            DateTime ngay_sinh = dtp_ngaySinh.Value.Date;
            if (DateTime.Compare(ngayMuaThue, DateTime.Now) > 0 || DateTime.Compare(ngayMuaThue, ngay_sinh) < 0)
                this.errorProvider1.SetError((Control)sender, "Ngày mua (thuê) phải bé hơn hoặc bằng ngày hiện tại và lớn hơn hoặc bằng ngày sinh!");
            else
                this.errorProvider1.Clear();
        }

        private void dtg_duLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtg_duLieu.Rows[e.RowIndex];
                txt_maKH.Text = row.Cells[0].Value.ToString();
                txt_hoTen.Text = row.Cells[1].Value.ToString();
                dtp_ngaySinh.Text = row.Cells[2].Value.ToString();
                txt_gioiTinh.Text = row.Cells[3].Value.ToString();
                if(txt_gioiTinh.Text.Trim().ToLower().Equals("nam"))
                {
                    rd_nam.Checked = true;
                }
                else
                {
                    rd_nu.Checked = true;
                }
                dtp_ngayMuaThue.Text = row.Cells[4].Value.ToString();
                cb_maDA.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btn_xuatFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.CreateText(saveFileDialog1.FileName);

                for (int i = 0; i < kh.Columns.Count; i++) //Ghi tên cột ra file
                {
                    sw.Write(kh.Columns[i].ToString());
                    if (i + 1 != kh.Columns.Count)
                    {
                        sw.Write(";");
                    }
                    else
                    {
                        sw.Write("\n");
                    }
                }

                for (int i = 0; i < kh.Rows.Count; i++) //Ghi nội dung từng hàng ra file
                {
                    for (int j = 0; j < kh.Columns.Count; j++)
                    {
                        sw.Write(kh.Rows[i][j].ToString());

                        if (j + 1 != kh.Columns.Count)
                        {
                            sw.Write(";");
                        }
                    }
                    if (i + 1 != kh.Rows.Count)
                    {
                        sw.Write("\n");
                    }

                }
                sw.Close();

                MessageBox.Show("Xuất file thành công!");
            }
        }

        private void btn_nhapFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Text File (*.txt)|*.txt|All Document (*.pdf)|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader f = new StreamReader(openFileDialog1.FileName);
                string noiDung = f.ReadToEnd(); //Lấy hết giá trị trong file bỏ vào biến noiDung

                DataTable dt_nhapFile = new DataTable();
                string[] line = noiDung.Split('\n'); //Đọc từng dòng

                for (int i = 0; i < line.Length; i++)
                {
                    if (i == 0)
                    {
                        nhapValueColumn(line[i], dt_nhapFile);
                    }
                    else
                    {
                        nhapValueRow(line[i], dt_nhapFile);
                    }
                }

                dtg_duLieu.DataSource = dt_nhapFile;
                f.Close();

                DialogResult rs = MessageBox.Show("Bạn có muốn lưu file vừa nhập vào CSDL không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (rs == DialogResult.Yes)
                {
                    int kq = nhapDataVaoSQL();
                    if (kq == 0)
                    {
                        MessageBox.Show("Nhập file thất bại!");
                    }
                    else
                    {
                        MessageBox.Show("Nhập file thành công!");
                    }
                }
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_hoTen.ReadOnly = false;
            txt_maKH.Enabled = dtp_ngaySinh.Enabled = rd_nam.Enabled = rd_nu.Enabled = dtp_ngayMuaThue.Enabled = cb_maDA.Enabled = btn_luu.Enabled = true;

            txt_maKH.Text = txt_hoTen.Text = string.Empty;
            rd_nam.Checked = true;
            txt_maKH.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_hoTen.ReadOnly = false;
            dtp_ngaySinh.Enabled = rd_nam.Enabled = rd_nu.Enabled = dtp_ngayMuaThue.Enabled = cb_maDA.Enabled = btn_luu.Enabled = true;
            txt_maKH.Enabled = false;
            txt_hoTen.Focus();

            dtg_duLieu.ReadOnly = false;
            dtg_duLieu.Columns[0].ReadOnly = dtg_duLieu.Columns[5].ReadOnly = true;
            dtg_duLieu.AllowUserToAddRows = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_maKH.Text == "" || txt_hoTen.Text == "") //Kiểm tra bỏ trống
            {
                MessageBox.Show("Không được bỏ trống các mục trên!");
                return;
            }

            if (txt_maKH.Enabled == true) //TH: Thêm
            {
                int check = checkPrimaryKeyExists(txt_maKH.Text, cb_maDA.Text);
                if (check != 0)
                {
                    MessageBox.Show("Thêm mới thất bại (Khóa chính đã tồn tại)!");
                    return;
                }
                DataRow row = kh.NewRow();
                row[0] = txt_maKH.Text;
                row[1] = txt_hoTen.Text;
                row[2] = dtp_ngaySinh.Value.Date.ToString("dd/MM/yyyy");
                if(rd_nam.Checked == true)
                {
                    row[3] = "NAM";
                }
                else
                {
                    row[3] = "NỮ";
                }
                row[4] = dtp_ngayMuaThue.Value.Date.ToString("dd/MM/yyyy");
                row[5] = cb_maDA.Text;

                kh.Rows.Add(row);
            }
            else //TH: Sửa
            {
                string[] key = new string[2];
                key[0] = txt_maKH.Text;
                key[1] = cb_maDA.Text;

                DataRow row = kh.Rows.Find(key);

                if (row != null)
                {
                    row.BeginEdit();
                    row[1] = txt_hoTen.Text;
                    row[2] = dtp_ngaySinh.Value.Date.ToString("dd/MM/yyyy");
                    if (rd_nam.Checked == true)
                    {
                        row[3] = "NAM";
                    }
                    else
                    {
                        row[3] = "NỮ";
                    }
                    row[4] = dtp_ngayMuaThue.Value.Date.ToString("dd/MM/yyyy");
                    row[5] = cb_maDA.Text;
                    row.EndEdit();
                }
            }

            //Update CSDL
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);

            //Update table DA
            sda.Update(kh);

            btn_luu.Enabled = false;
            MessageBox.Show("Lưu thông tin thành công!");   
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String[] key = new String[2];
            key[0] = txt_maKH.Text;
            key[1] = cb_maDA.Text;

            DataRow row = kh.Rows.Find(key);

            if (row != null)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    row.Delete();
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.Update(kh);
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txt_hoTen.ReadOnly == true)
            {
                txt_hoTen.ReadOnly = false;
            }
            else
            {
                if (txt_hoTen.Text.Length == 0)
                {
                    MessageBox.Show("Không được bỏ trống họ tên khách hàng!");
                    return;
                }
                else
                {
                    DataTable timKiem = new DataTable();
                    String sql = "SELECT * FROM [KHACHHANG] WHERE [HOTEN] = N'" + txt_hoTen.Text.Trim() + "' ";
                    SqlDataAdapter sda_timKiem = new SqlDataAdapter(sql, dt.conn);
                    sda_timKiem.Fill(timKiem);


                    if (timKiem.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu!");
                    }
                    else
                    {
                        dtg_duLieu.DataSource = timKiem;
                        taoKhoaChinh(timKiem);
                        dataBingDing(timKiem);
                    }

                }
            }
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


    }
}
