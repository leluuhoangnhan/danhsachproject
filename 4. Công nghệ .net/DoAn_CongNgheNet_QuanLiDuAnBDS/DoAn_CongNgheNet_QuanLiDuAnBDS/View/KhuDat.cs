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
    public partial class KhuDat : Form
    {
        DB_QLDA dt = new DB_QLDA();
        DataTable kd;
        SqlDataAdapter sda;

        public KhuDat()
        {
            InitializeComponent();
        }

        private void KhuDat_Load(object sender, EventArgs e)
        {
            loadDefault();
        }

        //------------------Hàm gọi chạy---------------
        public void loadDefault()
        {
            docDuLieuLenTable();
            hienThiDSDuAn();


            //Phân quyền
            string tenTK = layTenTK_DangNhap();
            int admin = ktAdmin(tenTK);
            if (admin != 1) //Không phải là admin
            {
                int insert = checkQuyen("KHUDAT", "INSERT", tenTK);
                if (insert != 1) //Không có quyền insert
                {
                    btn_them.Visible = false;
                }

                int delete = checkQuyen("KHUDAT", "DELETE", tenTK);
                if (delete != 1) //Không có quyền delete
                {
                    btn_xoa.Visible = false;
                }

                int update = checkQuyen("KHUDAT", "UPDATE", tenTK);
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
            kd = new DataTable();
            String sql = "SELECT * FROM [KHUDAT]";
            sda = new SqlDataAdapter(sql, dt.conn);
            sda.Fill(kd);

            dtg_duLieu.DataSource = kd;
            taoKhoaChinh(kd);
            dataBingDing(kd);
        }

        public void taoKhoaChinh(DataTable table)
        {
            DataColumn[] dc = new DataColumn[1];
            dc[0] = table.Columns[0];
            table.PrimaryKey = dc;
        }

        public void dataBingDing(DataTable table)
        {
            txt_maKD.DataBindings.Clear();
            txt_chuSH.DataBindings.Clear();
            cb_maDA.DataBindings.Clear();

            txt_maKD.DataBindings.Add("Text", table, table.Columns[0].ToString());
            txt_chuSH.DataBindings.Add("Text", table, table.Columns[1].ToString());
            cb_maDA.DataBindings.Add("Text", table, table.Columns[2].ToString());
        }

        public void nhapValueColumn(string line, DataTable table)
        {
            string[] value = line.Split(';'); //Đọc từng giá trị trên dòng
            DataColumn maKD = new DataColumn(value[0]);
            DataColumn chuSH = new DataColumn(value[1]);
            DataColumn maDA = new DataColumn(value[2]);

            table.Columns.Add(maKD);
            table.Columns.Add(chuSH);
            table.Columns.Add(maDA);

            taoKhoaChinh(table);

        }

        public void nhapValueRow(string line, DataTable table)
        {
            string[] value = line.Split(';'); //Đọc từng giá trị trên dòng

            table.Rows.Add(value[0], value[1], value[2]);
        }

        public int checkPrimaryKeyExists(string maKD)
        {
            String sql = "SELECT * FROM [KHUDAT] WHERE [MAKD] = @MAKD";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@MAKD", maKD);

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

        public int checkForeignKeyExists(string maKD)
        {
            String sql = "SELECT COUNT(*) FROM DUAN WHERE MAKD = @MAKD";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@MAKD", maKD);

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

        public int nhapDataVaoSQL()
        {
            int kq = 0;
            for (int i = 0; i < dtg_duLieu.Rows.Count - 1; i++)
            {
                string maKD = dtg_duLieu.Rows[i].Cells[0].Value.ToString();

                int ktKhoaChinh = checkPrimaryKeyExists(maKD);
                if (ktKhoaChinh == 0)
                {
                    String sql = "INSERT INTO [KHUDAT] ([MAKD], [CHUSOHUU], [MADUAN]) VALUES(@MAKD, @CHUSH, @MADA)";
                    try
                    {
                        dt.Open();
                        SqlCommand sc = new SqlCommand(sql, dt.conn);
                        sc.Parameters.AddWithValue("@MAKD", dtg_duLieu.Rows[i].Cells[0].Value.ToString());
                        sc.Parameters.AddWithValue("@CHUSH", dtg_duLieu.Rows[i].Cells[1].Value.ToString());
                        sc.Parameters.AddWithValue("@MADA", dtg_duLieu.Rows[i].Cells[2].Value.ToString());
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
            KhuDat kd = new KhuDat();
            kd.Visible = true;
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

        private void txt_maKD_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void txt_chuSH_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void dtg_duLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtg_duLieu.Rows[e.RowIndex];
                txt_maKD.Text = row.Cells[0].Value.ToString();
                txt_chuSH.Text = row.Cells[1].Value.ToString();
                cb_maDA.Text = row.Cells[2].Value.ToString();
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

        private void btn_xuatFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.CreateText(saveFileDialog1.FileName);

                for (int i = 0; i < kd.Columns.Count; i++) //Ghi tên cột ra file
                {
                    sw.Write(kd.Columns[i].ToString());
                    if (i + 1 != kd.Columns.Count)
                    {
                        sw.Write(";");
                    }
                    else
                    {
                        sw.Write("\n");
                    }
                }

                for (int i = 0; i < kd.Rows.Count; i++) //Ghi nội dung từng hàng ra file
                {
                    for (int j = 0; j < kd.Columns.Count; j++)
                    {
                        sw.Write(kd.Rows[i][j].ToString());

                        if (j + 1 != kd.Columns.Count)
                        {
                            sw.Write(";");
                        }
                    }
                    if (i + 1 != kd.Rows.Count)
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_chuSH.ReadOnly = false;
            txt_maKD.Enabled = cb_maDA.Enabled = btn_luu.Enabled = true;

            txt_maKD.Text = txt_chuSH.Text = string.Empty;
            txt_maKD.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_chuSH.ReadOnly = false;
            cb_maDA.Enabled = btn_luu.Enabled = true;
            txt_maKD.Enabled = false;
            txt_chuSH.Focus();

            dtg_duLieu.ReadOnly = false;
            dtg_duLieu.Columns[0].ReadOnly = true;
            dtg_duLieu.AllowUserToAddRows = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_maKD.Text == "" || txt_chuSH.Text == "") //Kiểm tra bỏ trống
            {
                MessageBox.Show("Không được bỏ trống các mục trên!");
                return;
            }

            if (txt_maKD.Enabled == true) //TH: Thêm
            {
                int check = checkPrimaryKeyExists(txt_maKD.Text);
                if (check != 0)
                {
                    MessageBox.Show("Thêm mới thất bại (Khóa chính đã tồn tại)!");
                    return;
                }
                DataRow row = kd.NewRow();
                row[0] = txt_maKD.Text;
                row[1] = txt_chuSH.Text;
                row[2] = cb_maDA.Text;

                kd.Rows.Add(row);
            }
            else //TH: Sửa
            {
                DataRow row = kd.Rows.Find(txt_maKD.Text);

                if (row != null)
                {
                    row.BeginEdit();
                    row[1] = txt_chuSH.Text;
                    row[2] = cb_maDA.Text;
                    row.EndEdit();
                }
            }

            //Update CSDL
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);

            //Update table DA
            sda.Update(kd);

            btn_luu.Enabled = false;
            MessageBox.Show("Lưu thông tin thành công!");   
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String[] key = new String[1];
            key[0] = txt_maKD.Text;

            DataRow row = kd.Rows.Find(key);

            if (row != null)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    if (checkForeignKeyExists(key[0]) != 0)
                    {
                        MessageBox.Show("Không thể xóa mục này vì nó đang là khóa ngoại của bảng khác!");
                        return;
                    }
                    row.Delete();
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.Update(kd);
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }

            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txt_chuSH.ReadOnly == true)
            {
                txt_chuSH.ReadOnly = false;
            }
            else
            {
                if (txt_chuSH.Text.Length == 0)
                {
                    MessageBox.Show("Không được bỏ trống tên chủ sở hữu!");
                    return;
                }
                else
                {
                    DataTable timKiem = new DataTable();
                    String sql = "SELECT * FROM [KHUDAT] WHERE [CHUSOHUU] = N'" + txt_chuSH.Text.Trim() + "' ";
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
