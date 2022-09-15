using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DemoDocFileExcelDriveGoogle.Model;
using System.IO;
using LinqToExcel;
using System.Linq;

namespace DemoDocFileExcelDriveGoogle
{
    public partial class SupportSalesBDS : Form
    {
        string PathDefault = "";
        ExcelQueryFactory excel = null;
        int tongSoCanHo_Cty = 0;
        DataTable lsTableBan = new DataTable();
        DataTable lsTableThue = new DataTable();

        public SupportSalesBDS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addColumnHeaderListTable(lsTableBan); // List Table Bán
            addColumnHeaderListTable(lsTableThue); // List Table Thuê
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            LoadRoHang();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                string[] value = comboBox1.Text.ToString().Split('(');
                string nameSheet = value[0].Trim();
                string soCanHoTrongDuAn = "";
                foreach (char c in value[1])
                {
                    if (Char.IsDigit(c))
                    {
                        soCanHoTrongDuAn += c.ToString();
                    }
                }
                OpenDuAn_ClickCombobox(nameSheet, Int16.Parse(soCanHoTrongDuAn));
            }
        }

        private void cbLoaiCanHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiCanHo.Text.Length > 0)
            {
                if(cbPhapLy.Text.Length > 0)
                {
                    OpenLoaiCanHo_ClickCombobox(cbLoaiCanHo.Text.ToString().Trim(), cbPhapLy.Text.ToString().Trim());
                }
                else
                {
                    OpenLoaiCanHo_ClickCombobox(cbLoaiCanHo.Text.ToString().Trim(), "");
                }
            }
        }

        private void cbPhapLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhapLy.Text.Length > 0)
            {
                if (cbLoaiCanHo.Text.Length > 0)
                {
                    OpenPhapLy_ClickCombobox(cbPhapLy.Text.ToString().Trim(), cbLoaiCanHo.Text.ToString().Trim());
                }
                else
                {
                    OpenPhapLy_ClickCombobox(cbPhapLy.Text.ToString().Trim(), "");
                }
            }
        }

        private void btnTimMaxMin_Click(object sender, EventArgs e)
        {
            if (cbLoaiCanHo.Text.Length > 0)
            {
                long min = timGiaMinBan(cbLoaiCanHo.Text.ToString());
                textBox1.Text = String.Format("{0:#,##0.##}", min);

                long max = timGiaMaxBan(cbLoaiCanHo.Text.ToString());
                textBox2.Text = String.Format("{0:#,##0.##}", max);

                long minT = timGiaMinThue(cbLoaiCanHo.Text.ToString());
                textBox3.Text = String.Format("{0:#,##0.##}", minT);

                long maxT = timGiaMaxThue(cbLoaiCanHo.Text.ToString());
                textBox4.Text = String.Format("{0:#,##0.##}", maxT);
            }

        }

        private void btnSapXepTangTruong_Click(object sender, EventArgs e)
        {
            sapXepTangTruongGiamDan();
            for (int i = 0; i < dtgv_data.RowCount; i++) //Ẩn những dòng không có giá trị tăng trưởng && số phòng ngủ
            {
                if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()))
                {
                    if (dtgv_data.Rows[i].Cells[13].Value == null || dtgv_data.Rows[i].Cells[2].Value == null)
                    {
                        dtgv_data.Rows[i].Visible = false;
                    }
                    else
                    {
                        string value = dtgv_data.Rows[i].Cells[13].Value.ToString().Trim();
                        string value1 = dtgv_data.Rows[i].Cells[2].Value.ToString().Trim();
                        if (value.Length == 0 || value1.Length == 0)
                        {
                            dtgv_data.Rows[i].Visible = false;
                        }
                    }
                }
            }

            dtgv_data.Refresh();

            MessageBox.Show("Sort Descending Growth Complete!");
        }

        private void btnOpenAllSheet_Click(object sender, EventArgs e)
        {
            DataTable dtMoi = new DataTable();
            addColumnHeaderListTable(dtMoi);
            dtMoi.Rows.Add("STT", "Mã Căn", "Số PN", "Diện Tích", "Giá", "Chi Tiết", "Tình Trạng", "Pháp Lý", "Ghi Chú", "Tên DA", "Tầng", "Hướng", "Ngày Update", "%Tăng Trưởng");

            dtMoi.Merge(lsTableBan);
            dtMoi.AcceptChanges();

            dtMoi.Merge(lsTableThue);
            dtMoi.AcceptChanges();

            dtgv_data.DataSource = dtMoi;
            dtgv_data.Refresh();

            try
            {
                dtgv_data.Columns[0].Width = dtgv_data.Columns[1].Width = dtgv_data.Columns[2].Width = dtgv_data.Columns[3].Width
                = dtgv_data.Columns[4].Width = dtgv_data.Columns[6].Width = dtgv_data.Columns[7].Width = 100;

                dtgv_data.Columns[5].Width = 360;
                dtgv_data.Columns[8].Width = 200;

                int k = 0;
                for (int i = 0; i < dtgv_data.RowCount; i++)
                {
                    if (dtgv_data.Rows[i].Cells[0].Value != null) //Nếu dữ liệu khác căn hộ
                    {
                        if (!IsNumber(dtgv_data.Rows[i].Cells[0].Value.ToString()) && !dtgv_data.Rows[i].Cells[0].Value.ToString().Trim().Equals(""))
                        {
                            if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("hàng"))//Nếu là tên rổ hàng
                            {
                                dtgv_data.Rows[i].DefaultCellStyle.BackColor = Color.Brown;
                                dtgv_data.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                                k = 0;
                            }
                            else if (dtgv_data.Rows[i].Cells[1].Value.ToString().Length == 0)//Nếu là tên block hoặc cho thuê
                            {
                                dtgv_data.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                                dtgv_data.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                            }
                            else//Nếu là filter
                            {
                                dtgv_data.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                            }

                            if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                            {
                                k++;
                            }
                        }
                    }

                    if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()))
                    {
                        if (dtgv_data.Rows[i].Cells[13].Value != null)
                        {
                            string value = dtgv_data.Rows[i].Cells[13].Value.ToString().Trim();
                            if (value.Length > 0)
                            {
                                double tangTruong = double.Parse(value);
                                if (tangTruong >= 0)
                                {
                                    dtgv_data.Rows[i].Cells[13].Style.ForeColor = Color.Green;
                                }
                                else
                                {
                                    dtgv_data.Rows[i].Cells[13].Style.ForeColor = Color.Red;
                                }
                            }
                        }

                        dtgv_data.Rows[i].Cells[4].Style.ForeColor = Color.Red; //Tô màu đỏ lại cho column 'Giá'
                        dtgv_data.Rows[i].Cells[2].Style.ForeColor = dtgv_data.Rows[i].Cells[7].Style.ForeColor = Color.Blue; //Tô màu xanh dương lại cho column 'Số PN' và 'Pháp Lý'

                        if (k > 0) //Tô màu nền những căn cho thuê
                        {
                            dtgv_data.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                        }
                    }
                }


                dtgv_data.Refresh();
                addItemLoaiCanHo_Combobox();

            }
            catch (Exception ex) { }
        }

        private void btnTimKiemGia_Click(object sender, EventArgs e)
        {
            if (txtTimKiemMin.Text.Length == 0 && txtTimKiemMax.Text.Length == 0)
                return;

            string[] value1 = txtTimKiemMin.Text.ToString().Split('.');
            string[] value2 = txtTimKiemMax.Text.ToString().Split('.');

            string min = "";
            string max = "";

            long valueMin = 0;
            long valueMax = 0;

            foreach (string x in value1)
            {
                min += x;
            }

            foreach (string x in value2)
            {
                max += x;
            }

            if (min.Trim().Length > 0 && IsNumber(min.Trim()))
            {
                valueMin = long.Parse(min.Trim());
            }

            if (max.Trim().Length > 0 && IsNumber(max.Trim()))
            {
                valueMax = long.Parse(max.Trim());
            }

            timKiemTheoGia(valueMin, valueMax);

        }

        private void txtTimKiemMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTimKiemMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTimKiemMin_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiemMin.Text.Length > 0)
                {
                    long value;
                    string[] value1 = txtTimKiemMin.Text.ToString().Trim().Split('.');
                    string t = "";
                    foreach (string x in value1)
                    {
                        t += x;
                    }
                    value = long.Parse(t);

                    txtTimKiemMin.Text = String.Format("{0:#,##0.##}", value);
                }

            }
            catch (Exception ex) { }
        }

        private void txtTimKiemMax_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiemMax.Text.Length > 0)
                {
                    long value;
                    string[] value1 = txtTimKiemMax.Text.ToString().Trim().Split('.');
                    string t = "";
                    foreach (string x in value1)
                    {
                        t += x;
                    }
                    value = long.Parse(t);

                    txtTimKiemMax.Text = String.Format("{0:#,##0.##}", value);
                }

            }
            catch (Exception ex) { }
        }

        private void txtSoCanHoCTy_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSoCanHoCTy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        public void addColumnHeaderListTable(DataTable dt)
        {
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã Căn");
            dt.Columns.Add("Số PN");
            dt.Columns.Add("Diện Tích");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Chi Tiết");
            dt.Columns.Add("Tình Trạng");
            dt.Columns.Add("Pháp Lý");
            dt.Columns.Add("Ghi Chú");

            //Các column new được thêm vào sau khi phân tích xong data rổ hàng
            dt.Columns.Add("Tên DA");
            dt.Columns.Add("Tầng");
            dt.Columns.Add("Hướng");
            dt.Columns.Add("Ngày Update");
            dt.Columns.Add("% Tăng Trưởng");

        }

        public bool checkRowExistTable(DataTable dataTable, string maCan, string gia, string tenDA)
        {
            bool contains = dataTable.AsEnumerable().Any(row => maCan == row.Field<String>("Mã Căn") && gia == row.Field<String>("Giá") && tenDA == row.Field<String>("Tên DA"));

            return contains;
        }

        int p = 0;
        public void addDuLieuVaoListTable()
        {
            int k = 0;
            for(int i = 0; i < dtgv_data.RowCount; i++)
            {
                if(checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString())) //Nếu không phải căn hộ
                {
                    if(dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                    {
                        k++;
                        p++;
                        if(p == 1)
                        {
                            lsTableThue.Rows.Add(dtgv_data.Rows[i].Cells[0].Value.ToString(), dtgv_data.Rows[i].Cells[1].Value.ToString(), dtgv_data.Rows[i].Cells[2].Value.ToString(), dtgv_data.Rows[i].Cells[3].Value.ToString(), dtgv_data.Rows[i].Cells[4].Value.ToString(), dtgv_data.Rows[i].Cells[5].Value.ToString(), dtgv_data.Rows[i].Cells[6].Value.ToString(), dtgv_data.Rows[i].Cells[7].Value.ToString(), dtgv_data.Rows[i].Cells[8].Value.ToString(), dtgv_data.Rows[i].Cells[9].Value.ToString(), dtgv_data.Rows[i].Cells[10].Value.ToString(), dtgv_data.Rows[i].Cells[11].Value.ToString(), dtgv_data.Rows[i].Cells[12].Value.ToString(), dtgv_data.Rows[i].Cells[13].Value.ToString());
                        }
                    }
                }
                else
                {
                    DataRow dataRow;
                    if(k == 0) //Add vào List Căn Bán
                    {
                        bool checkContains = checkRowExistTable(lsTableBan, dtgv_data.Rows[i].Cells[1].Value.ToString(), dtgv_data.Rows[i].Cells[4].Value.ToString(), dtgv_data.Rows[i].Cells[9].Value.ToString()); 
                        if(checkContains == false)
                        {
                            dataRow = lsTableBan.NewRow();
                            dataRow[0] = dtgv_data.Rows[i].Cells[0].Value.ToString();
                            dataRow[1] = dtgv_data.Rows[i].Cells[1].Value.ToString();
                            dataRow[2] = dtgv_data.Rows[i].Cells[2].Value.ToString();
                            dataRow[3] = dtgv_data.Rows[i].Cells[3].Value.ToString();
                            dataRow[4] = dtgv_data.Rows[i].Cells[4].Value.ToString();
                            dataRow[5] = dtgv_data.Rows[i].Cells[5].Value.ToString();
                            dataRow[6] = dtgv_data.Rows[i].Cells[6].Value.ToString();
                            dataRow[7] = dtgv_data.Rows[i].Cells[7].Value.ToString();
                            dataRow[8] = dtgv_data.Rows[i].Cells[8].Value.ToString();
                            dataRow[9] = dtgv_data.Rows[i].Cells[9].Value.ToString();
                            dataRow[10] = dtgv_data.Rows[i].Cells[10].Value.ToString();
                            dataRow[11] = dtgv_data.Rows[i].Cells[11].Value.ToString();
                            dataRow[12] = dtgv_data.Rows[i].Cells[12].Value.ToString();
                            dataRow[13] = dtgv_data.Rows[i].Cells[13].Value.ToString();
                            lsTableBan.Rows.Add(dataRow);
                        }     
                    }
                    else //Add vào List Căn Thuê
                    {
                        bool checkContains = checkRowExistTable(lsTableThue, dtgv_data.Rows[i].Cells[1].Value.ToString(), dtgv_data.Rows[i].Cells[4].Value.ToString(), dtgv_data.Rows[i].Cells[9].Value.ToString());
                        if (checkContains == false)
                        {
                            dataRow = lsTableThue.NewRow();
                            dataRow[0] = dtgv_data.Rows[i].Cells[0].Value.ToString();
                            dataRow[1] = dtgv_data.Rows[i].Cells[1].Value.ToString();
                            dataRow[2] = dtgv_data.Rows[i].Cells[2].Value.ToString();
                            dataRow[3] = dtgv_data.Rows[i].Cells[3].Value.ToString();
                            dataRow[4] = dtgv_data.Rows[i].Cells[4].Value.ToString();
                            dataRow[5] = dtgv_data.Rows[i].Cells[5].Value.ToString();
                            dataRow[6] = dtgv_data.Rows[i].Cells[6].Value.ToString();
                            dataRow[7] = dtgv_data.Rows[i].Cells[7].Value.ToString();
                            dataRow[8] = dtgv_data.Rows[i].Cells[8].Value.ToString();
                            dataRow[9] = dtgv_data.Rows[i].Cells[9].Value.ToString();
                            dataRow[10] = dtgv_data.Rows[i].Cells[10].Value.ToString();
                            dataRow[11] = dtgv_data.Rows[i].Cells[11].Value.ToString();
                            dataRow[12] = dtgv_data.Rows[i].Cells[12].Value.ToString();
                            dataRow[13] = dtgv_data.Rows[i].Cells[13].Value.ToString();
                            lsTableThue.Rows.Add(dataRow);
                        }

                    }
                }
            }
        }
        
        public void LoadRoHang()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "All file | *.*;";
            of.Multiselect = true; //Cho phép chọn nhiều file
            if(of.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string fileName in of.FileNames)
                {
                    xuLyRoHang(fileName);
                }

                MessageBox.Show("Load rổ hàng thành công!");
            }

        }

        public void xuLyRoHang(string fileName)
        {
            txtPath.Text = fileName;

            if(PathDefault.Equals(""))
            {
                for (int i = 0; i < fileName.Split('\\').Length - 2; i++)
                {
                    PathDefault += fileName.Split('\\')[i] + "//";
                }
            }

            string ext = Path.GetExtension(fileName);
            if (ext.ToLower().Equals(".xls") || ext.ToLower().Equals(".xlsx"))
            {
                excel = new ExcelQueryFactory(fileName);
                string tenRoHang = fileName.Split('\\').LastOrDefault();
                if (tenRoHang.Contains("KHU BÌNH TRƯNG"))
                {
                    xuLyFileExCel_KhuBinhTrung();
                }
                else if(tenRoHang.Contains("KHU MỸ LỢI"))
                {
                    xuLyFileExCel_KhuMyLoi();
                }
                else if(tenRoHang.Contains("QUẬN 9"))
                {
                    xuLyFileExCel_KhuQuan9();
                }

                txtSoCanHoCTy.Text = String.Format("{0:#,##0.##}", tongSoCanHo_Cty);
            }
        }

        public int xuLyFileExCel(string sheet)
        {
            int soLuongCanHo = 0;
            try
            {
                var rohang = from rh in excel.Worksheet<RoHang>(sheet) select rh;

                DataTable dt = new DataTable();
                dt.Columns.Add("STT");
                dt.Columns.Add("Mã Căn");
                dt.Columns.Add("Số PN");
                dt.Columns.Add("Diện Tích");
                dt.Columns.Add("Giá");
                dt.Columns.Add("Chi Tiết");
                dt.Columns.Add("Tình Trạng");
                dt.Columns.Add("Pháp Lý");
                dt.Columns.Add("Ghi Chú");

                //Các column new được thêm vào sau khi phân tích xong data rổ hàng
                dt.Columns.Add("Tên DA");
                dt.Columns.Add("Tầng");
                dt.Columns.Add("Hướng");
                dt.Columns.Add("Ngày Update");
                dt.Columns.Add("%Tăng Trưởng");

                

                foreach (var item in rohang)
                {
                    if (item.maCan != null || item.stt != null)
                    {
                        if(item.maCan == null)
                        {
                            item.maCan = "";
                        }
                        dt.Rows.Add(item.stt, item.maCan, item.soPN, item.dienTich, item.gia, item.chiTiet, item.tinhTrang, item.phapLy, item.ghiChu,"","","","","");
                        soLuongCanHo++;
                    }
                    if(item.maCan != null)
                    {
                        if(item.maCan.Trim().Length == 0 || item.maCan.ToLower().Contains("mã"))
                        {
                            soLuongCanHo--;
                        }
                    }
                }

                dt.AcceptChanges();
                dtgv_data.DataSource = dt;

                dtgv_data.Columns[0].Width = dtgv_data.Columns[1].Width = dtgv_data.Columns[2].Width = dtgv_data.Columns[3].Width
                = dtgv_data.Columns[4].Width = dtgv_data.Columns[6].Width = dtgv_data.Columns[7].Width = 100;

                dtgv_data.Columns[5].Width = 360;
                dtgv_data.Columns[8].Width = 200;

                for (int i = 0; i < dtgv_data.RowCount - 1; i++)
                {
                    if (dtgv_data.Rows[i].Cells[0].Value != null) //Nếu dữ liệu khác căn hộ
                    {
                        if (!IsNumber(dtgv_data.Rows[i].Cells[0].Value.ToString()) && !dtgv_data.Rows[i].Cells[0].Value.ToString().Trim().Equals(""))
                        {
                            if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("hàng"))//Nếu là tên rổ hàng
                            {
                                dtgv_data.Rows[i].DefaultCellStyle.BackColor = Color.Brown;
                                dtgv_data.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                            }
                            else if (dtgv_data.Rows[i].Cells[1].Value.ToString().Length == 0)//Nếu là tên block hoặc cho thuê
                            {
                                dtgv_data.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                                dtgv_data.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                            }
                            else//Nếu là filter
                            {
                                dtgv_data.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                            }
                        }
                    }
                }

                lamMoiLaiDataGridView();
                addItemLoaiCanHo_Combobox();

                addValueColumnTenDuAn();
                addValueColumnTangTruong();

                addDuLieuVaoListTable();

            }
            catch (Exception ex) { }

            return soLuongCanHo;

        }

        public void xuLyFileExCel_KhuBinhTrung()
        {
            if(excel != null)
            {
                string txtSheet = "";
                for (int i = 0; i < 8; i++)
                {
                    switch(i)
                    {
                        case 0:
                            {
                                txtSheet = "HOMYLAND";
                                break;
                            }
                        case 1:
                            {
                                txtSheet = "PRECIA";
                                break;
                            }
                        case 2:
                            {
                                txtSheet = "DLUSSO";
                                break;
                            }
                        case 3:
                            {
                                txtSheet = "PARCSPRING";
                                break;
                            }
                        case 4:
                            {
                                txtSheet = "LA ASTORIA";
                                break;
                            }
                        case 5:
                            {
                                txtSheet = "KRISTA";
                                break;
                            }
                        case 6:
                            {
                                txtSheet = "KRISVUE";
                                break;
                            }
                        case 7:
                            {
                                txtSheet = "CAO ỐC THỊNH VƯỢNG";
                                break;
                            }
                    }

                    int soCanHo = xuLyFileExCel(txtSheet);
                    //if (!comboBox1.Items.Contains(txtSheet + " (" + soCanHo + ")"))
                    //{
                    //    comboBox1.Items.Add(txtSheet + " (" + soCanHo + ")");
                    //    tongSoCanHo_Cty += soCanHo;
                    //}

                    int kt = -1;
                    int index = 0;
                    int soCanHoCu = 0;
                    foreach (var item in comboBox1.Items)
                    {
                        if (item.ToString().Contains(txtSheet))
                        {
                            kt = index;
                            soCanHoCu = Int16.Parse(item.ToString().Split('(')[1].Split(')')[0].Trim());
                        }
                        index++;
                        if (kt != -1)
                            break;
                    }

                    comboBox1.Items.Add(txtSheet + " (" + soCanHo + ")");
                    if (kt == -1)
                    {
                        tongSoCanHo_Cty += soCanHo;
                    }
                    else
                    {
                        comboBox1.Items.RemoveAt(kt);
                        tongSoCanHo_Cty += soCanHo - soCanHoCu;
                    }
                }
            }
        }

        public void xuLyFileExCel_KhuMyLoi()
        {
            if (excel != null)
            {
                string txtSheet = "";
                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                txtSheet = "CBD";
                                break;
                            }
                        case 1:
                            {
                                txtSheet = "FELIZ EN VISTA";
                                break;
                            }
                        case 2:
                            {
                                txtSheet = "VISTA VERDE";
                                break;
                            }
                        case 3:
                            {
                                txtSheet = "ONE VENRANDAH";
                                break;
                            }
                        case 4:
                            {
                                txtSheet = "PALM HEIGHT";
                                break;
                            }
                    }

                    int soCanHo = xuLyFileExCel(txtSheet);
                    //if (!comboBox1.Items.Contains(txtSheet + " (" + soCanHo + ")"))
                    //{
                    //    comboBox1.Items.Add(txtSheet + " (" + soCanHo + ")");
                    //    tongSoCanHo_Cty += soCanHo;
                    //}

                    int kt = -1;
                    int index = 0;
                    int soCanHoCu = 0;
                    foreach(var item in comboBox1.Items)
                    {
                        if(item.ToString().Contains(txtSheet))
                        {
                            kt = index;
                            soCanHoCu = Int16.Parse(item.ToString().Split('(')[1].Split(')')[0].Trim());
                        }
                        index++;
                        if (kt != -1)
                            break;
                    }

                    comboBox1.Items.Add(txtSheet + " (" + soCanHo + ")");
                    if(kt == -1)
                    {
                        tongSoCanHo_Cty += soCanHo;
                    }
                    else
                    {
                        comboBox1.Items.RemoveAt(kt);
                        tongSoCanHo_Cty += soCanHo - soCanHoCu;
                    }

                }
            }
        }

        public void xuLyFileExCel_KhuQuan9()
        {
            if (excel != null)
            {
                string txtSheet = "";
                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                txtSheet = "JAMILA";
                                break;
                            }
                        case 1:
                            {
                                txtSheet = "SKY 9";
                                break;
                            }
                        case 2:
                            {
                                txtSheet = "SAFIRA";
                                break;
                            }
                        case 3:
                            {
                                txtSheet = "RICCA";
                                break;
                            }
                        case 4:
                            {
                                txtSheet = "HAUSNEO";
                                break;
                            }
                    }

                    int soCanHo = xuLyFileExCel(txtSheet);
                    //if (!comboBox1.Items.Contains(txtSheet + " (" + soCanHo + ")"))
                    //{
                    //    comboBox1.Items.Add(txtSheet + " (" + soCanHo + ")");
                    //    tongSoCanHo_Cty += soCanHo;
                    //}

                    int kt = -1;
                    int index = 0;
                    int soCanHoCu = 0;
                    foreach (var item in comboBox1.Items)
                    {
                        if (item.ToString().Contains(txtSheet))
                        {
                            kt = index;
                            soCanHoCu = Int16.Parse(item.ToString().Split('(')[1].Split(')')[0].Trim());
                        }
                        index++;
                        if (kt != -1)
                            break;
                    }

                    comboBox1.Items.Add(txtSheet + " (" + soCanHo + ")");
                    if (kt == -1)
                    {
                        tongSoCanHo_Cty += soCanHo;
                    }
                    else
                    {
                        comboBox1.Items.RemoveAt(kt);
                        tongSoCanHo_Cty += soCanHo - soCanHoCu;
                    }
                }
            }
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public void OpenDuAn_ClickCombobox(string nameSheet, int soCanHoTrongDuAn)
        {
            int kq = -1;
            string daTest = "";
            int lanTest = 0;
            do
            {
                if (lanTest > 0)
                {
                    string fileName = "";
                    if (txtPath.Text.ToString().ToLower().Contains("khu bình trưng"))
                    {
                        if (daTest.Contains("khu mỹ lợi"))
                        {
                            //fileName = PathDefault + "RỔ HÀNG QUẬN 9//RỖ HÀNG QUẬN 9.xlsx";
                            fileName = PathDefault + "1. Rổ hàng//RỖ HÀNG QUẬN 9.xlsx";
                            daTest += "quận 9";
                            txtPath.Text = fileName;
                        }
                        else
                        {
                            //fileName = PathDefault + "RỔ HÀNG QUẬN 2//RỖ HÀNG KHU MỸ LỢI.xlsx";
                            fileName = PathDefault + "1. Rổ hàng//RỖ HÀNG KHU MỸ LỢI.xlsx";
                            daTest += "khu mỹ lợi";
                            txtPath.Text = fileName;
                        }
                    }
                    else
                    {
                        //fileName = PathDefault + "RỔ HÀNG QUẬN 2//RỖ HÀNG KHU BÌNH TRƯNG.xlsx";
                        fileName = PathDefault + "1. Rổ hàng//RỖ HÀNG KHU BÌNH TRƯNG.xlsx";
                        daTest += "khu bình trưng";
                        txtPath.Text = fileName;
                    }

                    excel = new ExcelQueryFactory(fileName);
                }

                kq = xuLyFileExCel(nameSheet);
                lanTest++;

                if (lanTest > 10 && kq != soCanHoTrongDuAn) //Do Admin đang chỉnh sửa file, nên không cần load nữa. => Dừng
                {
                    return;
                }

            } while (kq != soCanHoTrongDuAn);

        }

        public bool checkDuLieuKhongPhaiCanHo(string value) //Tieu de, ten block, filter...
        {
            if (value != null)
            {
                if (!IsNumber(value.Trim()) && !value.Trim().Equals(""))
                {
                    return true;
                }
            }
            return false;
        }

        public void addItemLoaiCanHo_Combobox()
        {
            cbLoaiCanHo.Items.Clear();

            for (int i = 0; i < dtgv_data.RowCount; i++)
            {
                if(!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()) && dtgv_data.Rows[i].Cells[2].Value != null)
                {
                    string value = dtgv_data.Rows[i].Cells[2].Value.ToString().Trim();
                    if (value.Length > 0 && !cbLoaiCanHo.Items.Contains(value))
                    {
                        cbLoaiCanHo.Items.Add(value);
                    }
                }
            }
        }

        public void OpenLoaiCanHo_ClickCombobox(string loaiCanHo, string phapLy)
        {
            for (int i = 1; i < dtgv_data.RowCount; i++)
            {
                if (dtgv_data.Rows[i].Cells[2].Value != null)
                {
                    if (!loaiCanHo.Equals(dtgv_data.Rows[i].Cells[2].Value.ToString().Trim()))
                    {
                        if (dtgv_data.Rows[i].Visible.Equals(true))
                        {
                            try { dtgv_data.Rows[i].Visible = false; }
                            catch (Exception ex) { };
                        }      
                    }
                    else
                    {
                        if (!phapLy.Equals(""))
                        {
                            if (dtgv_data.Rows[i].Cells[7].Value != null)
                            {
                                if (phapLy.Equals(dtgv_data.Rows[i].Cells[7].Value.ToString().Trim()))
                                {
                                    dtgv_data.Rows[i].Visible = true;
                                }
                            }
                        }
                        else
                        {
                            dtgv_data.Rows[i].Visible = true;
                        }
                    }
                }
            }
        }

        public void OpenPhapLy_ClickCombobox(string phapLy, string loaiCan)
        {
            for (int i = 1; i < dtgv_data.RowCount; i++)
            {
                if (dtgv_data.Rows[i].Cells[7].Value != null)
                {
                    if (!phapLy.Equals(dtgv_data.Rows[i].Cells[7].Value.ToString().Trim()))
                    {
                        if (dtgv_data.Rows[i].Visible.Equals(true))
                        {
                            try { dtgv_data.Rows[i].Visible = false; }
                            catch (Exception ex) { };
                        }
                    }
                    else
                    {
                        if (!loaiCan.Equals(""))
                        {
                            if (dtgv_data.Rows[i].Cells[2].Value != null)
                            {
                                if (loaiCan.Equals(dtgv_data.Rows[i].Cells[2].Value.ToString().Trim()))
                                {
                                    dtgv_data.Rows[i].Visible = true;
                                }
                            }
                        }
                        else
                        {
                            dtgv_data.Rows[i].Visible = true;
                        }
                    }
                }
            }


        }

        public void addValueColumnTenDuAn()
        {
            string tenDA = "";
            for (int i = 0; i < dtgv_data.RowCount; i++)
            {
                if (dtgv_data.Rows[i].Cells[0].Value != null && !tenDA.Equals("")) //Nếu dữ liệu khác căn hộ && tên dự án != rỗng
                {
                    if (checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()))
                    {
                        if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("hàng"))//Nếu là tên rổ hàng
                        {
                            tenDA = "";
                        }
                    }
                }
                if (dtgv_data.Rows[i].Cells[0].Value != null && tenDA.Equals("")) //Nếu dữ liệu khác căn hộ && tên dự án = rỗng
                {
                    if (checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()))
                    {
                        if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("hàng"))//Nếu là tên rổ hàng
                        {
                            string[] x = dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Split(':');
                            for(int j = 1; j < x.Length; j++)
                            {
                                tenDA += x[j];
                            }
                            tenDA = tenDA.Trim().ToUpper();
                        }
                    }
                }
                else if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()))
                {
                    dtgv_data.Rows[i].Cells[9].Value = tenDA;
                }
            }

            dtgv_data.Refresh();
        }

        public void addValueColumnTangTruong()
        {
            long min = 0;
            long max = 0;
            double tb = 0;

            int k = 0;
            for (int i = 0; i < dtgv_data.RowCount; i++)
            {
                if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                {
                    k++;
                }
                if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()) && k == 0) //Loại căn bán
                {
                    if(dtgv_data.Rows[i].Cells[2].Value != null)
                    {
                        min = timGiaMinBan(dtgv_data.Rows[i].Cells[2].Value.ToString());
                        max = timGiaMaxBan(dtgv_data.Rows[i].Cells[2].Value.ToString());
                    }
                }
                else if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()) && k != 0) //Loại căn thuê
                {
                    if (dtgv_data.Rows[i].Cells[2].Value != null)
                    {
                        min = timGiaMinThue(dtgv_data.Rows[i].Cells[2].Value.ToString());
                        max = timGiaMaxThue(dtgv_data.Rows[i].Cells[2].Value.ToString());
                    }
                }

                tb = (double)(min + max) / 2;

                if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()))
                {
                    if (dtgv_data.Rows[i].Cells[4].Value != null)
                    {
                        string[] value = dtgv_data.Rows[i].Cells[4].Value.ToString().Split('.');
                        string t = "";
                        foreach (string x in value)
                        {
                            t += x;
                        }
                        if (t.Trim().Length > 0)
                        {
                            double tangTruong = (double)(tb - long.Parse(t)) * 100 / long.Parse(t);

                            dtgv_data.Rows[i].Cells[13].Value = String.Format("{0:#,##0.##}", tangTruong);
                            if (tangTruong >= 0)
                            {
                                dtgv_data.Rows[i].Cells[13].Style.ForeColor = Color.Green;
                            }
                            else
                            {
                                dtgv_data.Rows[i].Cells[13].Style.ForeColor = Color.Red;
                            }
                        }
                    }

                }

            }

            dtgv_data.Refresh();
        }

        public long timGiaMinBan(string loaiCan)
        {
            long min = 0;
            for (int i = 0; i < dtgv_data.RowCount; i++)
            {
                if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                {
                    return min;
                }

                if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString())) //Nếu dữ liệu là căn hộ && căn bán
                {
                    if (dtgv_data.Rows[i].Cells[2].Value != null)
                    {
                        if(dtgv_data.Rows[i].Cells[2].Value.ToString().Equals(loaiCan))
                        {
                            if (dtgv_data.Rows[i].Cells[4].Value != null)
                            {
                                string[] value = dtgv_data.Rows[i].Cells[4].Value.ToString().Split('.');
                                string t = "";
                                foreach (string x in value)
                                {
                                    t += x;
                                }
                                if (t.Trim().Length > 0)
                                {
                                    if (min == 0 || long.Parse(t) < min) //Gán min cho giá trị ban đầu
                                    {
                                        min = long.Parse(t);
                                    }
                                }
                            }
                        }

                    }
                }

            }

            return min;
        }

        public long timGiaMaxBan(string loaiCan)
        {
            long max = 0;
            for (int i = 0; i < dtgv_data.RowCount; i++)
            {
                if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                {
                    return max;
                }

                if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString())) //Nếu dữ liệu là căn hộ && căn bán
                {
                    if (dtgv_data.Rows[i].Cells[2].Value != null)
                    {
                        if (dtgv_data.Rows[i].Cells[2].Value.ToString().Equals(loaiCan))
                        {
                            if (dtgv_data.Rows[i].Cells[4].Value != null)
                            {
                                string[] value = dtgv_data.Rows[i].Cells[4].Value.ToString().Split('.');
                                string t = "";
                                foreach (string x in value)
                                {
                                    t += x;
                                }
                                if (t.Trim().Length > 0)
                                {
                                    if (max == 0 || long.Parse(t) > max) //Gán min cho giá trị ban đầu
                                    {
                                        max = long.Parse(t);
                                    }
                                }
                            }
                        }

                    }
                }

            }

            return max;
        }

        public long timGiaMinThue(string loaiCan)
        {
            long min = 0;
            for (int i = dtgv_data.RowCount - 1; i >= 0; i--)
            {
                if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                {
                    return min;
                }

                if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString())) //Nếu dữ liệu là căn hộ && căn thuê
                {
                    if (dtgv_data.Rows[i].Cells[2].Value != null)
                    {
                        if (dtgv_data.Rows[i].Cells[2].Value.ToString().Equals(loaiCan))
                        {
                            if (dtgv_data.Rows[i].Cells[4].Value != null)
                            {
                                string[] value = dtgv_data.Rows[i].Cells[4].Value.ToString().Split('.');
                                string t = "";
                                foreach (string x in value)
                                {
                                    t += x;
                                }
                                if (t.Trim().Length > 0)
                                {
                                    if (min == 0 || long.Parse(t) < min) //Gán min cho giá trị ban đầu
                                    {
                                        min = long.Parse(t);
                                    }
                                }
                            }
                        }

                    }
                }

            }

            return min;
        }

        public long timGiaMaxThue(string loaiCan)
        {
            long max = 0;
            for (int i = dtgv_data.RowCount - 1; i >= 0; i--)
            {
                if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                {
                    return max;
                }

                if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString())) //Nếu dữ liệu là căn hộ && căn thuê
                {
                    if (dtgv_data.Rows[i].Cells[2].Value != null)
                    {
                        if (dtgv_data.Rows[i].Cells[2].Value.ToString().Equals(loaiCan))
                        {
                            if (dtgv_data.Rows[i].Cells[4].Value != null)
                            {
                                string[] value = dtgv_data.Rows[i].Cells[4].Value.ToString().Split('.');
                                string t = "";
                                foreach (string x in value)
                                {
                                    t += x;
                                }
                                if (t.Trim().Length > 0)
                                {
                                    if (max == 0 || long.Parse(t) > max) //Gán min cho giá trị ban đầu
                                    {
                                        max = long.Parse(t);
                                    }
                                }
                            }
                        }

                    }
                }

            }

            return max;
        }

        public int demSoDongLoaiCanBan()
        {
            int t = 0;
            for (int i = 0; i < dtgv_data.RowCount; i++)
            {
                if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                {
                    return t;
                }
                t++;
            }
            return t;
        }

        public int demSoDongLoaiCanThue()
        {
            int t = 0;
            for (int i = dtgv_data.RowCount - 1; i >= 0; i--)
            {
                if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                {
                    return t;
                }
                t++;
            }
            return t;
        }

        public void swap2Row(int r1, int r2)
        {
            for (int j = 0; j < this.dtgv_data.Columns.Count; j++)
            {
                object tmp = this.dtgv_data[j, r1].Value;
                this.dtgv_data[j, r1].Value = this.dtgv_data[j, r2].Value;
                this.dtgv_data[j, r2].Value = tmp;

                Color tmp2 = this.dtgv_data[j, r1].Style.ForeColor;
                this.dtgv_data[j, r1].Style.ForeColor = this.dtgv_data[j, r2].Style.ForeColor;
                this.dtgv_data[j, r2].Style.ForeColor = tmp2;
            }

        }

        public void sapXepTangTruongGiamDan()
        {
            int dongBan = demSoDongLoaiCanBan();
            int dongThue = demSoDongLoaiCanThue();

            int k = 0;
            for(int i = 0; i < dtgv_data.RowCount; i++)
            {
                if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                {
                    k++;
                }

                if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()) && k == 0) //Nếu dữ liệu là căn hộ && căn bán
                {
                    for (int j = i; j < dongBan - 1; j++)
                    {
                        if (dtgv_data.Rows[j].Cells[13].Value != null && dtgv_data.Rows[j].Visible.Equals(true))
                        {
                            string value = dtgv_data.Rows[j].Cells[13].Value.ToString().Trim();
                            if (value.Length > 0)
                            {
                                double max = double.Parse(value);
                                for (int u = j + 1; u < dongBan; u++)
                                {
                                    if (dtgv_data.Rows[u].Cells[13].Value != null && dtgv_data.Rows[u].Visible.Equals(true))
                                    {
                                        string value1 = dtgv_data.Rows[u].Cells[13].Value.ToString().Trim();
                                        if (value1.Length > 0)
                                        {
                                            double valueMoi = double.Parse(value1);
                                            if (valueMoi > max)
                                            {
                                                max = valueMoi;
                                                swap2Row(j, u);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }

                    i = dongBan - 1;
                }
                else if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()) && k != 0) //Nếu dữ liệu là căn hộ && căn thuê
                {
                    for (int j = i; j <= dongBan + dongThue - 1; j++)
                    {
                        if (dtgv_data.Rows[j].Cells[13].Value != null && dtgv_data.Rows[j].Visible.Equals(true))
                        {
                            string value = dtgv_data.Rows[j].Cells[13].Value.ToString().Trim();
                            if (value.Length > 0)
                            {
                                double max = double.Parse(value);
                                for (int u = j + 1; u <= dongBan + dongThue; u++)
                                {
                                    if (dtgv_data.Rows[u].Cells[13].Value != null && dtgv_data.Rows[u].Visible.Equals(true))
                                    {
                                        string value1 = dtgv_data.Rows[u].Cells[13].Value.ToString().Trim();
                                        if (value1.Length > 0)
                                        {
                                            double valueMoi = double.Parse(value1);
                                            if (valueMoi > max)
                                            {
                                                max = valueMoi;
                                                swap2Row(j, u);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }

                    i = dtgv_data.RowCount - 1;
                }

            }
        }

        public void sortGia(long min, long max, int i)
        {
            dtgv_data.Rows[i].Visible = true;

            if (dtgv_data.Rows[i].Cells[4].Value != null)
            {
                string[] value = dtgv_data.Rows[i].Cells[4].Value.ToString().Split('.');
                string t = "";
                foreach (string x in value)
                {
                    t += x;
                }
                if (t.Trim().Length > 0)
                {
                    long giaCanHo = long.Parse(t);
                    if (giaCanHo < min || giaCanHo > max)
                    {
                        if (dtgv_data.Rows[i].Visible.Equals(true))
                            dtgv_data.Rows[i].Visible = false;
                    }
                }
            }
        }

        public void timKiemTheoGia(long min, long max)
        {
            for (int i = 1; i < dtgv_data.RowCount; i++)
            {
                if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()))
                {
                    if (cbKetHopLoaiCan.Checked.Equals(true))
                    {
                        if (dtgv_data.Rows[i].Visible.Equals(true))
                        {
                            sortGia(min, max, i);
                        }
                    }
                    else
                    {
                        sortGia(min, max, i);
                    }
                }
            }

        }

        public void lamMoiLaiDataGridView()
        {
            int k = 0;
            for (int i = 0; i < dtgv_data.RowCount; i++)
            {
                if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains("thuê"))
                {
                    k++;
                }
                else if (dtgv_data.Rows[i].Cells[0].Value.ToString().ToLower().Contains(":"))
                {
                    k = 0;
                }

                if (k > 0 && !checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString()))
                {
                    dtgv_data.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                }

                if (!checkDuLieuKhongPhaiCanHo(dtgv_data.Rows[i].Cells[0].Value.ToString())) //Nếu dữ liệu là căn hộ
                {
                    xuLyColGia(dtgv_data.Rows[i].Cells[4].Value.ToString(), k, i);
                    xuLyColSoPN(dtgv_data.Rows[i].Cells[2].Value.ToString(), i);
                    xuLyColPhapLy(dtgv_data.Rows[i].Cells[7].Value.ToString(), k, i);
                }

            }

            dtgv_data.Refresh();
        }


        //start xử lý column 'Giá'

        public void xuLyColGia(string value, int k, int i)
        {
            if (value != null)
            {
                string[] _value = value.ToLower().Split('-')[0].Split('t');
                int usd = 0;
                if (_value[0].Length > 0)
                {
                    foreach(char c in _value[0])
                    {
                        if(c.Equals('$'))
                        {
                            usd++;
                        }
                    }
                    if(usd > 0)
                    {
                        string x = _value[0].Split('$')[0];
                        _value[0] = x;
                    }
                }

                long gia = xuLyGia(_value[0], k, usd);
                if(gia > 0)
                {
                    dtgv_data.Rows[i].Cells[4].Value = String.Format("{0:#,##0.##}", gia);
                    dtgv_data.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                }
                else
                {
                    dtgv_data.Rows[i].Cells[4].Value = "";
                }

            }

        }

        public long xuLyGia(string value, int k, int usd)
        {
            long giaTri = 0;

            if (value.Length != 0)
            {
                string _value = "";
                string phanTruoc = "";
                string phanSau = "";
                
                if(k == 0) //Loại căn bán
                {
                    phanSau = "000000";
                }
                else //Loại căn thuê
                {
                    phanSau = "000";
                }

                string[] x = value.Split('.');
                if(x.Length == 1)
                {
                    string[] y = x[0].Split(',');
                    x = y;
                }

                phanTruoc = x[0];
                if(x.Length == 1) //Sau khi xử lý độ dài mảng x vẫn = 1
                {
                    if(x[0].Trim().Length == 0)
                    {
                        return giaTri;
                    }
                    else if(Int16.Parse(x[0]) < 100)
                    {
                        if (k == 0)
                        {
                            phanSau = "000000000";
                        }
                        else
                        {
                            phanSau = "000000";
                        }
                    }
                    _value = phanTruoc.Trim() + phanSau.Trim();
                }
                else
                {
                    string phanKeTruoc = x[1].Trim();
                    if(phanKeTruoc.Length < 3)
                    {
                        int n = 3 - phanKeTruoc.Length;
                        for(int i = 0; i < n ; i++)
                        {
                            phanKeTruoc += "0";
                        }
                    }

                    _value = phanTruoc.Trim() + phanKeTruoc + phanSau.Trim();
                }

                if(usd > 0)
                {
                    giaTri = long.Parse(_value) * 23;
                }
                else
                {
                    giaTri = long.Parse(_value);
                }

            }

            return giaTri;
        }

        //end xử lý column 'Giá'



        //start xử lý column 'Số PN'
        public void xuLyColSoPN(string value, int i)
        {
            if (value != null)
            {
                string soPNMoi = "";
                
                if (value.Trim().ToString().Length == 0)
                {
                    return;
                }
                else if (IsNumber(value[0].ToString().Trim()))
                {
                    soPNMoi = value[0].ToString().Trim();
                }
                else if (value[0].ToString().Trim().ToLower().Equals("d")) //Dạng duplex
                {
                    string x = value.Trim();
                    string phanDuoi = x[x.Length - 1].ToString();
                    if (IsNumber(phanDuoi))
                    {
                        soPNMoi = x[0].ToString().ToUpper() + phanDuoi;
                    }
                    else
                    {
                        soPNMoi = x[0].ToString().ToUpper() + "2";
                    }
                }
                else if (value[0].ToString().Trim().ToLower().Equals("s")) //Dạng shophouse
                {
                    soPNMoi = "Shop";
                }
                else if (value[0].ToString().Trim().ToLower().Equals("o")) //Dạng offictel
                {
                    soPNMoi = "Off";
                }
                else if (value[0].ToString().Trim().ToLower().Equals("p")) //Dạng penhouse
                {
                    soPNMoi = "Pen";
                }

                if (soPNMoi.Length > 0)
                {
                    dtgv_data.Rows[i].Cells[2].Value = soPNMoi;
                    dtgv_data.Rows[i].Cells[2].Style.ForeColor = Color.Blue;
                }
                else
                {
                    dtgv_data.Rows[i].Cells[2].Value = "erro";
                    dtgv_data.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                }

            }
        }

        //end xử lý column 'Số PN'



        //start xử lý column 'Pháp Lý'
        public void xuLyColPhapLy(string value, int k, int i)
        {
            if (value != null && k == 0)
            {
                string phapLyMoi = "";

                if (value.ToLower().Contains("đã"))
                {
                    phapLyMoi = "Đã có sổ";
                }
                else
                {
                    phapLyMoi = "Chưa có sổ";
                }

                dtgv_data.Rows[i].Cells[7].Value = phapLyMoi;
                dtgv_data.Rows[i].Cells[7].Style.ForeColor = Color.Blue;
            }
        }


        //end xử lý column 'Pháp Lý'




    }
}
