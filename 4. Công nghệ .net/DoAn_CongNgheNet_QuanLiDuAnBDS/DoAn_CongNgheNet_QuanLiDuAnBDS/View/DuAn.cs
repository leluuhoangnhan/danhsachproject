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
    public partial class DuAn : Form
    {

        DB_QLDA dt = new DB_QLDA();
        DataTable da;
        SqlDataAdapter sda;

        public DuAn()
        {
            InitializeComponent();
        }

        private void DuAn_Load(object sender, EventArgs e)
        {
            loadDefault();
        }


        //------------------Hàm gọi chạy---------------
        public void loadDefault()
        {
            docDuLieuLenTable();
            hienThiDSKhuDat();

            //Phân quyền
            string tenTK = layTenTK_DangNhap();
            int admin = ktAdmin(tenTK);
            if (admin != 1) //Không phải là admin
            {
                int insert = checkQuyen("DUAN", "INSERT", tenTK);
                if (insert != 1) //Không có quyền insert
                {
                    btn_them.Visible = false;
                }

                int delete = checkQuyen("DUAN", "DELETE", tenTK);
                if (delete != 1) //Không có quyền delete
                {
                    btn_xoa.Visible = false;
                }

                int update = checkQuyen("DUAN", "UPDATE", tenTK);
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

        public void hienThiDSKhuDat()
        {
            String sql = "SELECT * FROM [KHUDAT]";
            SqlDataAdapter sda1 = new SqlDataAdapter(sql, dt.conn);

            DataTable khuDat = new DataTable();
            sda1.Fill(khuDat);

            cb_maKD.DataSource = khuDat;
            cb_maKD.DisplayMember = "MAKD";
            cb_maKD.ValueMember = "CHUSOHUU";
        }

        public void docDuLieuLenTable()
        {
            da = new DataTable();
            String sql = "SELECT * FROM [DUAN]";
            sda = new SqlDataAdapter(sql, dt.conn);
            sda.Fill(da);

            dtg_duLieu.DataSource = da;
            taoKhoaChinh(da);
            dataBingDing(da);
        }

        public void taoKhoaChinh(DataTable table)
        {
            DataColumn[] dc = new DataColumn[1];
            dc[0] = table.Columns[0];
            table.PrimaryKey = dc;
        }

        public void dataBingDing(DataTable table)
        {
            txt_maDA.DataBindings.Clear();
            txt_tenDA.DataBindings.Clear();
            txt_diaChi.DataBindings.Clear();
            txt_namBG.DataBindings.Clear();
            cb_maKD.DataBindings.Clear();
            txt_soLuongKH.DataBindings.Clear();
            txt_soLuongCDT.DataBindings.Clear();


            txt_maDA.DataBindings.Add("Text", table, table.Columns[0].ToString());
            txt_tenDA.DataBindings.Add("Text", table, table.Columns[1].ToString());
            txt_diaChi.DataBindings.Add("Text", table, table.Columns[2].ToString());
            txt_namBG.DataBindings.Add("Text", table, table.Columns[3].ToString());
            cb_maKD.DataBindings.Add("Text", table, table.Columns[4].ToString());
            txt_soLuongKH.DataBindings.Add("Text", table, table.Columns[5].ToString());
            txt_soLuongCDT.DataBindings.Add("Text", table, table.Columns[6].ToString());
        }

        public void nhapValueColumn(string line, DataTable table)
        {
            string[] value = line.Split(';'); //Đọc từng giá trị trên dòng
            DataColumn maDA = new DataColumn(value[0]);
            DataColumn tenDA = new DataColumn(value[1]);
            DataColumn diaChi = new DataColumn(value[2]);
            DataColumn namBG = new DataColumn(value[3]);
            DataColumn maKD = new DataColumn(value[4]);
            DataColumn soLuongKH = new DataColumn(value[5]);
            DataColumn soLuongCDT = new DataColumn(value[6]);

            table.Columns.Add(maDA);
            table.Columns.Add(tenDA);
            table.Columns.Add(diaChi);
            table.Columns.Add(namBG);
            table.Columns.Add(maKD);
            table.Columns.Add(soLuongKH);
            table.Columns.Add(soLuongCDT);

            taoKhoaChinh(table);

        }

        public void nhapValueRow(string line, DataTable table)
        {
            string[] value = line.Split(';'); //Đọc từng giá trị trên dòng

            table.Rows.Add(value[0], value[1], value[2], value[3], value[4], value[5], value[6]);
        }

        public int checkPrimaryKeyExists(string maDA)
        {
            String sql = "SELECT * FROM [DUAN] WHERE [MADUAN] = @MADA";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
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
                string maDA = dtg_duLieu.Rows[i].Cells[0].Value.ToString();

                int ktKhoaChinh = checkPrimaryKeyExists(maDA);
                if (ktKhoaChinh == 0)
                {
                    String sql = "INSERT INTO [DUAN] ([MADUAN], [TENDUAN], [DIACHI], [NAMBG], [MAKD], [SOLUONG_KH], [SOLUONG_CDT]) VALUES(@MADA, @TENDA, @DCHI, @NAMBG, @MAKD, @SL_KH, @SL_CDT)";
                    try
                    {
                        dt.Open();
                        SqlCommand sc = new SqlCommand(sql, dt.conn);
                        sc.Parameters.AddWithValue("@MADA", dtg_duLieu.Rows[i].Cells[0].Value.ToString());
                        sc.Parameters.AddWithValue("@TENDA", dtg_duLieu.Rows[i].Cells[1].Value.ToString());
                        sc.Parameters.AddWithValue("@DCHI", dtg_duLieu.Rows[i].Cells[2].Value.ToString());
                        sc.Parameters.AddWithValue("@NAMBG", dtg_duLieu.Rows[i].Cells[3].Value.ToString());
                        sc.Parameters.AddWithValue("@MAKD", dtg_duLieu.Rows[i].Cells[4].Value.ToString());
                        sc.Parameters.AddWithValue("@SL_KH", dtg_duLieu.Rows[i].Cells[5].Value.ToString());
                        sc.Parameters.AddWithValue("@SL_CDT", dtg_duLieu.Rows[i].Cells[6].Value.ToString());
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

        public int checkForeignKeyExists(string maDA)
        {
            String sql = "SELECT COUNT(*) FROM CHUDAUTU CDT, KHACHHANG KH, KHUDAT KD WHERE CDT.MADUAN = @MADA OR KH.MADUAN = @MADA OR KD.MADUAN = @MADA";
            try
            {
                dt.Open();
                SqlCommand sc = new SqlCommand(sql, dt.conn);
                sc.Parameters.AddWithValue("@MADA", maDA);

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

        public void reset()
        {
            this.Hide();
            DuAn da = new DuAn();
            da.Visible = true;
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

        private void txt_maDA_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void txt_tenDA_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void txt_diaChi_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void txt_namBG_Leave(object sender, EventArgs e)
        {
            ktNhapDuLieu((Control)sender);
        }

        private void dtg_duLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtg_duLieu.Rows[e.RowIndex];
                txt_maDA.Text = row.Cells[0].Value.ToString();
                txt_tenDA.Text = row.Cells[1].Value.ToString();
                txt_diaChi.Text = row.Cells[2].Value.ToString();
                txt_namBG.Text = row.Cells[3].Value.ToString();
                cb_maKD.Text = row.Cells[4].Value.ToString();
                txt_soLuongKH.Text = row.Cells[5].Value.ToString();
                txt_soLuongCDT.Text = row.Cells[6].Value.ToString();
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

        private void btn_xuatFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.CreateText(saveFileDialog1.FileName);

                for (int i = 0; i < da.Columns.Count; i++) //Ghi tên cột ra file
                {
                    sw.Write(da.Columns[i].ToString());
                    if (i + 1 != da.Columns.Count)
                    {
                        sw.Write(";");
                    }
                    else
                    {
                        sw.Write("\n");
                    }
                }

                for (int i = 0; i < da.Rows.Count; i++) //Ghi nội dung từng hàng ra file
                {
                    for (int j = 0; j < da.Columns.Count; j++)
                    {
                        sw.Write(da.Rows[i][j].ToString());

                        if (j + 1 != da.Columns.Count)
                        {
                            sw.Write(";");
                        }
                    }
                    if (i + 1 != da.Rows.Count)
                    {
                        sw.Write("\n");
                    }

                }
                sw.Close();

                MessageBox.Show("Xuất file thành công!");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_tenDA.ReadOnly = txt_diaChi.ReadOnly = txt_namBG.ReadOnly = false;
            txt_maDA.Enabled = cb_maKD.Enabled = btn_luu.Enabled = true;

            txt_maDA.Text = txt_tenDA.Text = txt_diaChi.Text = txt_namBG.Text = string.Empty;
            txt_maDA.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_tenDA.ReadOnly = txt_diaChi.ReadOnly = txt_namBG.ReadOnly = false;
            cb_maKD.Enabled = btn_luu.Enabled = true;
            txt_maDA.Enabled = false;

            txt_tenDA.Focus();

            dtg_duLieu.ReadOnly = false;
            dtg_duLieu.Columns[0].ReadOnly = true;
            dtg_duLieu.AllowUserToAddRows = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_maDA.Text == "" || txt_tenDA.Text == "" || txt_diaChi.Text == "" || txt_namBG.Text == "") //Kiểm tra bỏ trống
            {
                MessageBox.Show("Không được bỏ trống các mục trên!");
                return;
            }

            if (txt_maDA.Enabled == true) //TH: Thêm
            {
                int check = checkPrimaryKeyExists(txt_maDA.Text);
                if (check != 0)
                {
                    MessageBox.Show("Thêm mới thất bại (Khóa chính đã tồn tại)!");
                    return;
                }
                DataRow row = da.NewRow();
                row[0] = txt_maDA.Text;
                row[1] = txt_tenDA.Text;
                row[2] = txt_diaChi.Text;
                row[3] = txt_namBG.Text;
                row[4] = cb_maKD.Text;
                row[5] = "0";
                row[6] = "0";

                da.Rows.Add(row);
            }
            else //TH: Sửa
            {
                DataRow row = da.Rows.Find(txt_maDA.Text);

                if (row != null)
                {
                    row.BeginEdit();
                    row[1] = txt_tenDA.Text;
                    row[2] = txt_diaChi.Text;
                    row[3] = txt_namBG.Text;
                    row[4] = cb_maKD.Text;
                    row.EndEdit();
                }
            }

            //Update CSDL
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);

            //Update table DA
            sda.Update(da);

            btn_luu.Enabled = false;
            MessageBox.Show("Lưu thông tin thành công!");     
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String[] key = new String[1];
            key[0] = txt_maDA.Text;

            DataRow row = da.Rows.Find(key);

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
                    sda.Update(da);
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }

            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txt_tenDA.ReadOnly == true)
            {
                txt_tenDA.ReadOnly = false;
            }
            else
            {
                if (txt_tenDA.Text.Length == 0)
                {
                    MessageBox.Show("Không được bỏ trống tên dự án!");
                    return;
                }
                else
                {
                    DataTable timKiem = new DataTable();
                    String sql = "SELECT * FROM [DUAN] WHERE [TENDUAN] = N'" + txt_tenDA.Text.Trim() + "' ";
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
