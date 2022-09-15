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
using System.Drawing.Imaging;

namespace DoAn_CongNgheNet_QuanLiDuAnBDS
{
    public partial class ChuDauTu : Form
    {
        DB_QLDA dt = new DB_QLDA();
        DataTable cdt;
        SqlDataAdapter sda;


        public ChuDauTu()
        {
            InitializeComponent();
        }

        private void ChuDauTu_Load(object sender, EventArgs e)
        {
            loadDefault();
        }

        //------------------Hàm gọi chạy---------------
        public void loadDefault()
        {
            String tenFile = "LeLuuHoangNhan.jpg";
            logoDefault(tenFile);
            docDuLieuLenTable();
            hienThiDSDuAn();
            hienThiDSThue();

            //Phân quyền
            string tenTK = layTenTK_DangNhap();
            int admin = ktAdmin(tenTK);
            if(admin != 1) //Không phải là admin
            {
                int insert = checkQuyen("CHUDAUTU", "INSERT", tenTK);
                if(insert != 1) //Không có quyền insert
                {
                    btn_them.Visible = false;
                }

                int delete = checkQuyen("CHUDAUTU", "DELETE", tenTK);
                if (delete != 1) //Không có quyền delete
                {
                    btn_xoa.Visible = false;
                }

                int update = checkQuyen("CHUDAUTU", "UPDATE", tenTK);
                if (update != 1) //Không có quyền update
                {
                    btn_sua.Visible = false;
                }

                if(btn_them.Visible == false && btn_sua.Visible == false)
                {
                    btn_luu.Visible = false;
                }
            }

        }

        public void docDuLieuLenTable()
        {
            cdt = new DataTable();
            String sql = "SELECT * FROM [CHUDAUTU]";
            sda = new SqlDataAdapter(sql, dt.conn);
            sda.Fill(cdt);

            dtg_duLieu.DataSource = cdt;
            taoKhoaChinh(cdt);
            dataBingDing(cdt);
        }

        public void taoKhoaChinh(DataTable table)
        {
            DataColumn[] dc = new DataColumn[3];
            dc[0] = table.Columns[0];
            dc[1] = table.Columns[3];
            dc[2] = table.Columns[4];
            table.PrimaryKey = dc;
        }

        public void logoDefault(string tenFile)
        {
            ptb_logo.Image = new Bitmap(Application.StartupPath + "\\img\\" + tenFile);
            txt_urlImage.Text = tenFile;
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
            SqlDataAdapter sda1 = new SqlDataAdapter(sql,dt.conn);

            DataTable duAn = new DataTable();
            sda1.Fill(duAn);

            cb_duAnDT.DataSource = duAn;
            cb_duAnDT.DisplayMember = "MADUAN";
            cb_duAnDT.ValueMember = "MADUAN";
        }

        public void hienThiDSThue()
        {
            String sql = "SELECT * FROM [THUE]";
            SqlDataAdapter sda1 = new SqlDataAdapter(sql, dt.conn);

            DataTable t = new DataTable();
            sda1.Fill(t);

            cb_thue.DataSource = t;
            cb_thue.DisplayMember = "MASOTHUE";
            cb_thue.ValueMember = "MASOTHUE";
        }

        public void nhapHinhAnh()
        {
            //BMP, GIF, JPEG, EXIF, PNG và TIFF, ICO...
            openFileDialog1.Filter = "All Image (*.jpg)|*.jpg|All Image (*.png)|*.png|All Image (*.gif)|*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptb_logo.Image = Image.FromFile(openFileDialog1.FileName.ToString());

                string[] name = openFileDialog1.FileName.Split('\\');
                string tenFile = name[name.Length - 1].ToString().Trim();

                txt_urlImage.Text = tenFile;
            }
        }

        public void luuHinhAnh(string tenFile)
        {
            bool kt = File.Exists(Application.StartupPath + "\\img\\" + tenFile);
            if (kt == false)
                ptb_logo.Image.Save(Application.StartupPath + "\\img\\" + tenFile, ImageFormat.Png);
        }

        public void hienThiSoLuongDADauTu(string maCDT)
        {
            if (maCDT == null)
                return;

            String sql = "SELECT DBO.HAM_DEM_SL_DUAN_CDT(@MACDT)";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@MACDT", maCDT);
                int soLuong = (int)sc.ExecuteScalar();
                txt_tenCDT_Search.Text = soLuong.ToString();

                dt.Close();
            }
            catch(Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                txt_tenCDT_Search.Text = "Lỗi hiển thị dự án đầu tư!";
            }
        }

        public void hienThiTGianThanhLapCDT(string maCDT)
        {
            if (maCDT == null)
                return;

            String sql = "SELECT DBO.HAM_TINH_THOIGIANTHANHLAPCDT(@MACDT)";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@MACDT", maCDT);
                int month = (int)sc.ExecuteScalar();
                txt_tgianThanhLap.Text = month + " tháng";

                dt.Close();
            }
            catch (Exception ex)
            {
                if (dt.checkConnect() == true)
                    dt.Close();
                txt_tenCDT_Search.Text = "Lỗi hiển thị thời gian thành lập đầu tư!";
            }
        }

        public void dataBingDing(DataTable table)
        {
            txt_maCDT.DataBindings.Clear();
            txt_tenCDT.DataBindings.Clear();
            dtp_ngayDKKD.DataBindings.Clear();
            cb_thue.DataBindings.Clear();
            cb_duAnDT.DataBindings.Clear();
            txt_urlImage.DataBindings.Clear();

            txt_maCDT.DataBindings.Add("Text", table, table.Columns[0].ToString());
            txt_tenCDT.DataBindings.Add("Text", table, table.Columns[1].ToString());
            dtp_ngayDKKD.DataBindings.Add("Text", table, table.Columns[2].ToString());
            cb_thue.DataBindings.Add("Text", table, table.Columns[3].ToString());
            cb_duAnDT.DataBindings.Add("Text", table, table.Columns[4].ToString());
            txt_urlImage.DataBindings.Add("Text", table, table.Columns[5].ToString());
        }

        public void nhapValueColumn(string line, DataTable table)
        {
            string[] value = line.Split(';'); //Đọc từng giá trị trên dòng
            DataColumn maCDT = new DataColumn(value[0]);
            DataColumn tenCDT = new DataColumn(value[1]);
            DataColumn ngayDKKD = new DataColumn(value[2]);
            DataColumn maST = new DataColumn(value[3]);
            DataColumn maDA = new DataColumn(value[4]);
            DataColumn img = new DataColumn(value[5]);

            table.Columns.Add(maCDT);
            table.Columns.Add(tenCDT);
            table.Columns.Add(ngayDKKD);
            table.Columns.Add(maST);
            table.Columns.Add(maDA);
            table.Columns.Add(img);

            taoKhoaChinh(table);

        }

        public void nhapValueRow(string line, DataTable table)
        {
            string[] value = line.Split(';'); //Đọc từng giá trị trên dòng

            table.Rows.Add(value[0], value[1], value[2], value[3], value[4], value[5]);
        }

        public int checkPrimaryKeyExists(string maCDT, string maST, string maDA)
        {
            String sql = "SELECT * FROM [CHUDAUTU] WHERE [MACDT] = @MACDT AND [MASOTHUE] = @MAST AND [MADUAN] = @MADA";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@MACDT", maCDT);
                sc.Parameters.AddWithValue("@MAST", maST);
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
                string maCDT = dtg_duLieu.Rows[i].Cells[0].Value.ToString();
                string maST = dtg_duLieu.Rows[i].Cells[3].Value.ToString();
                string maDA = dtg_duLieu.Rows[i].Cells[4].Value.ToString();

                int ktKhoaChinh = checkPrimaryKeyExists(maCDT, maST, maDA);
                if(ktKhoaChinh == 0)
                {
                    String sql = "SET DATEFORMAT DMY " + "INSERT INTO [CHUDAUTU] ([MACDT], [TENCDT], [NGAY_DKKD], [MASOTHUE], [MADUAN], [IMG]) VALUES(@MACDT, @TENCDT, @NGAY_DKKD, @MASOTHUE, @MADA, @IMG)";
                    try
                    {
                        string[] date = dtg_duLieu.Rows[i].Cells[2].Value.ToString().Split(' ');

                        dt.Open();
                        SqlCommand sc = new SqlCommand(sql, dt.conn);
                        sc.Parameters.AddWithValue("@MACDT", dtg_duLieu.Rows[i].Cells[0].Value.ToString());
                        sc.Parameters.AddWithValue("@TENCDT", dtg_duLieu.Rows[i].Cells[1].Value.ToString());
                        sc.Parameters.AddWithValue("@NGAY_DKKD", date[0].ToString());
                        sc.Parameters.AddWithValue("@MASOTHUE", dtg_duLieu.Rows[i].Cells[3].Value.ToString());
                        sc.Parameters.AddWithValue("@MADA", dtg_duLieu.Rows[i].Cells[4].Value.ToString());
                        sc.Parameters.AddWithValue("@IMG", dtg_duLieu.Rows[i].Cells[5].Value.ToString());
                        sc.ExecuteNonQuery();

                        dt.Close();
                        kq++;
                    }
                    catch(Exception ex)
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
            ChuDauTu chuDauTu = new ChuDauTu();
            chuDauTu.Visible = true;
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




        private void txt_maCDT_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void txt_tenCDT_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void dtp_ngayDKKD_Leave(object sender, EventArgs e)
        {
            DateTime ngay_dkkd = dtp_ngayDKKD.Value.Date;
            if (DateTime.Compare(ngay_dkkd, DateTime.Now) > 0)
                this.errorProvider1.SetError((Control)sender, "Ngày đăng ký kinh doanh phải bé hơn hoặc bằng ngày hiện tại!");
            else
                this.errorProvider1.Clear();
        }

        private void btn_addImg_Click(object sender, EventArgs e)
        {
            nhapHinhAnh();
        }

        private void dtg_duLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int dongCuoi = dtg_duLieu.Rows.Count - 1;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtg_duLieu.Rows[e.RowIndex];
                txt_maCDT.Text = row.Cells[0].Value.ToString();
                txt_tenCDT.Text = row.Cells[1].Value.ToString();
                dtp_ngayDKKD.Text = row.Cells[2].Value.ToString();
                cb_thue.Text = row.Cells[3].Value.ToString();
                cb_duAnDT.Text = row.Cells[4].Value.ToString();
                txt_urlImage.Text = row.Cells[5].Value.ToString();
                
                //Kiểm tra file đã tồn tại chưa
                bool ktFileTonTai = File.Exists(Application.StartupPath + "\\img\\" + txt_urlImage.Text);

                //Nếu có đường dẫn và file ảnh có tồn tại
                if (txt_urlImage.Text.Length > 0 && ktFileTonTai == true)
                    ptb_logo.Image = Image.FromFile(Application.StartupPath + "\\img\\" + txt_urlImage.Text);
                else
                    logoDefault("LeLuuHoangNhan.jpg");

                hienThiSoLuongDADauTu(txt_maCDT.Text);
                hienThiTGianThanhLapCDT(txt_maCDT.Text);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_tenCDT.ReadOnly = false;
            txt_maCDT.Enabled = dtp_ngayDKKD.Enabled = cb_thue.Enabled = cb_duAnDT.Enabled = btn_addImg.Enabled = btn_luu.Enabled = true;

            txt_maCDT.Text = txt_tenCDT.Text = string.Empty;
            txt_maCDT.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_tenCDT.ReadOnly = false;
            dtp_ngayDKKD.Enabled = cb_thue.Enabled = cb_duAnDT.Enabled = btn_addImg.Enabled = btn_luu.Enabled = true;
            txt_maCDT.Enabled = false;
            txt_tenCDT.Focus();

            dtg_duLieu.ReadOnly = false;
            dtg_duLieu.Columns[0].ReadOnly = true;
            dtg_duLieu.AllowUserToAddRows = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_maCDT.Text == "" || txt_tenCDT.Text == "") //Kiểm tra bỏ trống
            {
                MessageBox.Show("Không được bỏ trống các mục trên!");
                return;
            }

            string url = txt_urlImage.Text;

            if(txt_maCDT.Enabled == true) //TH: Thêm
            {
                int check = checkPrimaryKeyExists(txt_maCDT.Text, cb_thue.Text, cb_duAnDT.Text);
                if(check != 0)
                {
                    MessageBox.Show("Thêm mới thất bại (Khóa chính đã tồn tại)!");
                    return;
                }
                DataRow row = cdt.NewRow();
                row[0] = txt_maCDT.Text;
                row[1] = txt_tenCDT.Text;
                row[2] = dtp_ngayDKKD.Value.Date.ToString("dd/MM/yyyy");
                row[3] = cb_thue.Text;
                row[4] = cb_duAnDT.Text;
                row[5] = url;

                cdt.Rows.Add(row);
            }
            else //TH: Sửa
            {
                string[] key = new string[3];
                key[0] = txt_maCDT.Text;
                key[1] = cb_thue.Text;
                key[2] = cb_duAnDT.Text;

                DataRow row = cdt.Rows.Find(key);

                if(row != null)
                {
                    row.BeginEdit();
                    row[1] = txt_tenCDT.Text;
                    row[2] = dtp_ngayDKKD.Value.Date.ToString("dd/MM/yyyy");
                    row[3] = cb_thue.Text;
                    row[4] = cb_duAnDT.Text;
                    row[5] = url;
                    row.EndEdit();
                }

            }

            //Lưu ảnh vào thư mục img
            luuHinhAnh(url);

            //Update CSDL
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);

            //Update table CDT
            sda.Update(cdt);

            btn_luu.Enabled = false;
            MessageBox.Show("Lưu thông tin thành công!");     
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String []key = new String[3];
            key[0] = txt_maCDT.Text;
            key[1] = cb_thue.Text;
            key[2] = cb_duAnDT.Text;

            DataRow row = cdt.Rows.Find(key);

            if (row != null)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(rs == DialogResult.Yes)
                {
                    row.Delete();
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.Update(cdt);
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
                    
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if(txt_tenCDT.ReadOnly == true)
            {
                txt_tenCDT.ReadOnly = false;
            }
            else
            {
                if(txt_tenCDT.Text.Length == 0)
                {
                    MessageBox.Show("Không được bỏ trống tên chủ đầu tư!");
                    return;
                }
                else
                {
                    DataTable timKiem = new DataTable();
                    String sql = "SELECT * FROM [CHUDAUTU] WHERE [TENCDT] = N'" + txt_tenCDT.Text.Trim() + "' ";
                    SqlDataAdapter sda_timKiem = new SqlDataAdapter(sql,dt.conn);
                    sda_timKiem.Fill(timKiem);


                    if(timKiem.Rows.Count == 0)
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_resetForm_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_xuatFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.CreateText(saveFileDialog1.FileName);

                for (int i = 0; i < cdt.Columns.Count; i++) //Ghi tên cột ra file
                {
                    sw.Write(cdt.Columns[i].ToString());
                    if (i + 1 != cdt.Columns.Count)
                    {
                        sw.Write(";");
                    }
                    else
                    {
                        sw.Write("\n");
                    }
                }

                for (int i = 0; i < cdt.Rows.Count; i++) //Ghi nội dung từng hàng ra file
                {
                    for (int j = 0; j < cdt.Columns.Count; j++)
                    {
                        sw.Write(cdt.Rows[i][j].ToString());

                        if (j + 1 != cdt.Columns.Count)
                        {
                            sw.Write(";");
                        }
                    }
                    if(i + 1 != cdt.Rows.Count)
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
                string noiDung=f.ReadToEnd(); //Lấy hết giá trị trong file bỏ vào biến noiDung

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
                if(rs == DialogResult.Yes)
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


    }
}
