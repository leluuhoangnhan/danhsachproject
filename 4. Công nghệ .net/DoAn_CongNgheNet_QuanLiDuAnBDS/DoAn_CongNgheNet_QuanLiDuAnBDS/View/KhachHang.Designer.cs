namespace DoAn_CongNgheNet_QuanLiDuAnBDS
{
    partial class KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_quayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rd_nam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_ngayMuaThue = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_maDA = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtg_duLieu = new System.Windows.Forms.DataGridView();
            this.btn_nhapFile = new System.Windows.Forms.Button();
            this.btn_xuatFile = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.btn_resetForm = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.rd_nu = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txt_gioiTinh = new System.Windows.Forms.Label();
            this.btn_saoLuu = new System.Windows.Forms.Button();
            this.btn_khoiPhuc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_duAn_Max = new System.Windows.Forms.TextBox();
            this.txt_maKH_Max = new System.Windows.Forms.TextBox();
            this.txt_soLuong_KH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_duLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_quayLai
            // 
            this.btn_quayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quayLai.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_quayLai.Image = global::DoAn_CongNgheNet_QuanLiDuAnBDS.Properties.Resources.icon_quayLai;
            this.btn_quayLai.Location = new System.Drawing.Point(12, 12);
            this.btn_quayLai.Name = "btn_quayLai";
            this.btn_quayLai.Size = new System.Drawing.Size(81, 35);
            this.btn_quayLai.TabIndex = 64;
            this.btn_quayLai.Text = "Quay lại";
            this.btn_quayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quayLai.UseVisualStyleBackColor = true;
            this.btn_quayLai.Click += new System.EventHandler(this.btn_quayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(449, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 65;
            this.label1.Text = "Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mã khách hàng:";
            // 
            // txt_maKH
            // 
            this.txt_maKH.Enabled = false;
            this.txt_maKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_maKH.Location = new System.Drawing.Point(209, 89);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(284, 29);
            this.txt_maKH.TabIndex = 67;
            this.txt_maKH.Leave += new System.EventHandler(this.txt_maKH_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(46, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Họ tên:";
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoTen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_hoTen.Location = new System.Drawing.Point(209, 156);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.ReadOnly = true;
            this.txt_hoTen.Size = new System.Drawing.Size(284, 29);
            this.txt_hoTen.TabIndex = 94;
            this.txt_hoTen.Leave += new System.EventHandler(this.txt_hoTen_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(46, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 95;
            this.label4.Text = "Ngày sinh:";
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_ngaySinh.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dtp_ngaySinh.Enabled = false;
            this.dtp_ngaySinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaySinh.Location = new System.Drawing.Point(209, 218);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(284, 29);
            this.dtp_ngaySinh.TabIndex = 96;
            this.dtp_ngaySinh.Leave += new System.EventHandler(this.dtp_ngaySinh_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(46, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 97;
            this.label5.Text = "Giới tính:";
            // 
            // rd_nam
            // 
            this.rd_nam.AutoSize = true;
            this.rd_nam.Checked = true;
            this.rd_nam.Enabled = false;
            this.rd_nam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nam.Location = new System.Drawing.Point(209, 292);
            this.rd_nam.Name = "rd_nam";
            this.rd_nam.Size = new System.Drawing.Size(63, 25);
            this.rd_nam.TabIndex = 0;
            this.rd_nam.TabStop = true;
            this.rd_nam.Text = "Nam";
            this.rd_nam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(46, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 23);
            this.label6.TabIndex = 99;
            this.label6.Text = "Ngày mua (thuê):";
            // 
            // dtp_ngayMuaThue
            // 
            this.dtp_ngayMuaThue.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_ngayMuaThue.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dtp_ngayMuaThue.Enabled = false;
            this.dtp_ngayMuaThue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayMuaThue.Location = new System.Drawing.Point(209, 359);
            this.dtp_ngayMuaThue.Name = "dtp_ngayMuaThue";
            this.dtp_ngayMuaThue.Size = new System.Drawing.Size(284, 29);
            this.dtp_ngayMuaThue.TabIndex = 100;
            this.dtp_ngayMuaThue.Leave += new System.EventHandler(this.dtp_ngayMuaThue_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(46, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 101;
            this.label7.Text = "Mã dự án:";
            // 
            // cb_maDA
            // 
            this.cb_maDA.Enabled = false;
            this.cb_maDA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_maDA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_maDA.FormattingEnabled = true;
            this.cb_maDA.Location = new System.Drawing.Point(209, 427);
            this.cb_maDA.Name = "cb_maDA";
            this.cb_maDA.Size = new System.Drawing.Size(284, 29);
            this.cb_maDA.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(712, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 103;
            this.label9.Text = "Bảng dữ liệu:";
            // 
            // dtg_duLieu
            // 
            this.dtg_duLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_duLieu.Location = new System.Drawing.Point(545, 134);
            this.dtg_duLieu.Name = "dtg_duLieu";
            this.dtg_duLieu.ReadOnly = true;
            this.dtg_duLieu.Size = new System.Drawing.Size(452, 205);
            this.dtg_duLieu.TabIndex = 104;
            this.dtg_duLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_duLieu_CellClick);
            // 
            // btn_nhapFile
            // 
            this.btn_nhapFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapFile.Location = new System.Drawing.Point(652, 356);
            this.btn_nhapFile.Name = "btn_nhapFile";
            this.btn_nhapFile.Size = new System.Drawing.Size(112, 32);
            this.btn_nhapFile.TabIndex = 105;
            this.btn_nhapFile.Text = "Nhập file.txt";
            this.btn_nhapFile.UseVisualStyleBackColor = true;
            this.btn_nhapFile.Click += new System.EventHandler(this.btn_nhapFile_Click);
            // 
            // btn_xuatFile
            // 
            this.btn_xuatFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatFile.Location = new System.Drawing.Point(798, 356);
            this.btn_xuatFile.Name = "btn_xuatFile";
            this.btn_xuatFile.Size = new System.Drawing.Size(112, 32);
            this.btn_xuatFile.TabIndex = 106;
            this.btn_xuatFile.Text = "Xuất file.txt";
            this.btn_xuatFile.UseVisualStyleBackColor = true;
            this.btn_xuatFile.Click += new System.EventHandler(this.btn_xuatFile_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Green;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(50, 497);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 31);
            this.btn_them.TabIndex = 107;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(162, 496);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 31);
            this.btn_xoa.TabIndex = 108;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Chocolate;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(276, 496);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(97, 31);
            this.btn_sua.TabIndex = 109;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.Gray;
            this.btn_luu.Enabled = false;
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Location = new System.Drawing.Point(397, 496);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(97, 31);
            this.btn_luu.TabIndex = 110;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_timKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_timKiem.Location = new System.Drawing.Point(50, 544);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(97, 32);
            this.btn_timKiem.TabIndex = 111;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // btn_resetForm
            // 
            this.btn_resetForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_resetForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_resetForm.Location = new System.Drawing.Point(756, 568);
            this.btn_resetForm.Name = "btn_resetForm";
            this.btn_resetForm.Size = new System.Drawing.Size(132, 31);
            this.btn_resetForm.TabIndex = 112;
            this.btn_resetForm.Text = "Reset Form";
            this.btn_resetForm.UseVisualStyleBackColor = false;
            this.btn_resetForm.Click += new System.EventHandler(this.btn_resetForm_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(909, 568);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(102, 31);
            this.btn_thoat.TabIndex = 113;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // rd_nu
            // 
            this.rd_nu.AutoSize = true;
            this.rd_nu.Enabled = false;
            this.rd_nu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nu.Location = new System.Drawing.Point(290, 292);
            this.rd_nu.Name = "rd_nu";
            this.rd_nu.Size = new System.Drawing.Size(51, 25);
            this.rd_nu.TabIndex = 114;
            this.rd_nu.Text = "Nữ";
            this.rd_nu.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_gioiTinh
            // 
            this.txt_gioiTinh.AutoSize = true;
            this.txt_gioiTinh.Location = new System.Drawing.Point(394, 299);
            this.txt_gioiTinh.Name = "txt_gioiTinh";
            this.txt_gioiTinh.Size = new System.Drawing.Size(29, 13);
            this.txt_gioiTinh.TabIndex = 115;
            this.txt_gioiTinh.Text = "Nam";
            this.txt_gioiTinh.Visible = false;
            // 
            // btn_saoLuu
            // 
            this.btn_saoLuu.BackColor = System.Drawing.Color.Yellow;
            this.btn_saoLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saoLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saoLuu.Location = new System.Drawing.Point(162, 545);
            this.btn_saoLuu.Name = "btn_saoLuu";
            this.btn_saoLuu.Size = new System.Drawing.Size(97, 31);
            this.btn_saoLuu.TabIndex = 116;
            this.btn_saoLuu.Text = "Sao lưu";
            this.btn_saoLuu.UseVisualStyleBackColor = false;
            this.btn_saoLuu.Click += new System.EventHandler(this.btn_saoLuu_Click);
            // 
            // btn_khoiPhuc
            // 
            this.btn_khoiPhuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_khoiPhuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khoiPhuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_khoiPhuc.Location = new System.Drawing.Point(276, 545);
            this.btn_khoiPhuc.Name = "btn_khoiPhuc";
            this.btn_khoiPhuc.Size = new System.Drawing.Size(106, 31);
            this.btn_khoiPhuc.TabIndex = 117;
            this.btn_khoiPhuc.Text = "Khôi phục";
            this.btn_khoiPhuc.UseVisualStyleBackColor = false;
            this.btn_khoiPhuc.Click += new System.EventHandler(this.btn_khoiPhuc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_duAn_Max);
            this.groupBox1.Controls.Add(this.txt_maKH_Max);
            this.groupBox1.Controls.Add(this.txt_soLuong_KH);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(545, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 141);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // txt_duAn_Max
            // 
            this.txt_duAn_Max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duAn_Max.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_duAn_Max.Location = new System.Drawing.Point(243, 93);
            this.txt_duAn_Max.Name = "txt_duAn_Max";
            this.txt_duAn_Max.ReadOnly = true;
            this.txt_duAn_Max.Size = new System.Drawing.Size(191, 26);
            this.txt_duAn_Max.TabIndex = 72;
            // 
            // txt_maKH_Max
            // 
            this.txt_maKH_Max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKH_Max.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_maKH_Max.Location = new System.Drawing.Point(243, 59);
            this.txt_maKH_Max.Name = "txt_maKH_Max";
            this.txt_maKH_Max.ReadOnly = true;
            this.txt_maKH_Max.Size = new System.Drawing.Size(191, 26);
            this.txt_maKH_Max.TabIndex = 71;
            // 
            // txt_soLuong_KH
            // 
            this.txt_soLuong_KH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuong_KH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_soLuong_KH.Location = new System.Drawing.Point(243, 27);
            this.txt_soLuong_KH.Name = "txt_soLuong_KH";
            this.txt_soLuong_KH.ReadOnly = true;
            this.txt_soLuong_KH.Size = new System.Drawing.Size(191, 26);
            this.txt_soLuong_KH.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(24, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 19);
            this.label11.TabIndex = 69;
            this.label11.Text = "Dự án KH giao dịch nhiều nhất:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(24, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 19);
            this.label10.TabIndex = 68;
            this.label10.Text = "Mã KH giao dịch nhiều nhất:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(24, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "Số lượng KH hiện tại:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(408, 582);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(248, 17);
            this.label12.TabIndex = 119;
            this.label12.Text = "@Lê Lưu Hoàng Nhân - 2001190186";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 611);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_khoiPhuc);
            this.Controls.Add(this.btn_saoLuu);
            this.Controls.Add(this.txt_gioiTinh);
            this.Controls.Add(this.rd_nu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.rd_nam);
            this.Controls.Add(this.btn_resetForm);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xuatFile);
            this.Controls.Add(this.btn_nhapFile);
            this.Controls.Add(this.dtg_duLieu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_maDA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_ngayMuaThue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_ngaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_maKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quayLai);
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_duLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rd_nam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_ngayMuaThue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_maDA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtg_duLieu;
        private System.Windows.Forms.Button btn_nhapFile;
        private System.Windows.Forms.Button btn_xuatFile;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.Button btn_resetForm;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.RadioButton rd_nu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label txt_gioiTinh;
        private System.Windows.Forms.Button btn_saoLuu;
        private System.Windows.Forms.Button btn_khoiPhuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_duAn_Max;
        private System.Windows.Forms.TextBox txt_maKH_Max;
        private System.Windows.Forms.TextBox txt_soLuong_KH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
    }
}