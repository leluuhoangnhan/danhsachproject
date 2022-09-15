namespace DoAn_CongNgheNet_QuanLiDuAnBDS
{
    partial class ChuDauTu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maCDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenCDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_ngayDKKD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_duAnDT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_resetForm = new System.Windows.Forms.Button();
            this.dtg_duLieu = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_nhapFile = new System.Windows.Forms.Button();
            this.btn_xuatFile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tenCDT_Search = new System.Windows.Forms.TextBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_addImg = new System.Windows.Forms.Button();
            this.txt_urlImage = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tgianThanhLap = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_quayLai = new System.Windows.Forms.Button();
            this.btn_saoLuu = new System.Windows.Forms.Button();
            this.btn_khoiPhuc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_thue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_duLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chủ Đầu Tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã CĐT:";
            // 
            // txt_maCDT
            // 
            this.txt_maCDT.Enabled = false;
            this.txt_maCDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maCDT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_maCDT.Location = new System.Drawing.Point(216, 74);
            this.txt_maCDT.Name = "txt_maCDT";
            this.txt_maCDT.Size = new System.Drawing.Size(284, 29);
            this.txt_maCDT.TabIndex = 3;
            this.txt_maCDT.Leave += new System.EventHandler(this.txt_maCDT_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên CĐT:";
            // 
            // txt_tenCDT
            // 
            this.txt_tenCDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenCDT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_tenCDT.Location = new System.Drawing.Point(216, 140);
            this.txt_tenCDT.Name = "txt_tenCDT";
            this.txt_tenCDT.ReadOnly = true;
            this.txt_tenCDT.Size = new System.Drawing.Size(284, 29);
            this.txt_tenCDT.TabIndex = 5;
            this.txt_tenCDT.Leave += new System.EventHandler(this.txt_tenCDT_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(21, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày DKKD:";
            // 
            // dtp_ngayDKKD
            // 
            this.dtp_ngayDKKD.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_ngayDKKD.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dtp_ngayDKKD.Enabled = false;
            this.dtp_ngayDKKD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayDKKD.Location = new System.Drawing.Point(216, 199);
            this.dtp_ngayDKKD.Name = "dtp_ngayDKKD";
            this.dtp_ngayDKKD.Size = new System.Drawing.Size(284, 29);
            this.dtp_ngayDKKD.TabIndex = 7;
            this.dtp_ngayDKKD.Leave += new System.EventHandler(this.dtp_ngayDKKD_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(21, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã số thuế:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(21, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dự án đầu tư:";
            // 
            // cb_duAnDT
            // 
            this.cb_duAnDT.Enabled = false;
            this.cb_duAnDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_duAnDT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_duAnDT.FormattingEnabled = true;
            this.cb_duAnDT.Location = new System.Drawing.Point(216, 332);
            this.cb_duAnDT.Name = "cb_duAnDT";
            this.cb_duAnDT.Size = new System.Drawing.Size(284, 29);
            this.cb_duAnDT.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(21, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hình ảnh đại diện:";
            // 
            // ptb_logo
            // 
            this.ptb_logo.Location = new System.Drawing.Point(216, 403);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(284, 155);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_logo.TabIndex = 13;
            this.ptb_logo.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(921, 667);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(102, 31);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Green;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(16, 605);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 31);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(138, 604);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 31);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Chocolate;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(259, 604);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(97, 31);
            this.btn_sua.TabIndex = 17;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_resetForm
            // 
            this.btn_resetForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_resetForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_resetForm.Location = new System.Drawing.Point(767, 667);
            this.btn_resetForm.Name = "btn_resetForm";
            this.btn_resetForm.Size = new System.Drawing.Size(132, 31);
            this.btn_resetForm.TabIndex = 18;
            this.btn_resetForm.Text = "Reset Form";
            this.btn_resetForm.UseVisualStyleBackColor = false;
            this.btn_resetForm.Click += new System.EventHandler(this.btn_resetForm_Click);
            // 
            // dtg_duLieu
            // 
            this.dtg_duLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_duLieu.Location = new System.Drawing.Point(563, 121);
            this.dtg_duLieu.Name = "dtg_duLieu";
            this.dtg_duLieu.ReadOnly = true;
            this.dtg_duLieu.Size = new System.Drawing.Size(452, 305);
            this.dtg_duLieu.TabIndex = 19;
            this.dtg_duLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_duLieu_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(742, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Bảng dữ liệu:";
            // 
            // btn_nhapFile
            // 
            this.btn_nhapFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapFile.Location = new System.Drawing.Point(684, 441);
            this.btn_nhapFile.Name = "btn_nhapFile";
            this.btn_nhapFile.Size = new System.Drawing.Size(112, 32);
            this.btn_nhapFile.TabIndex = 21;
            this.btn_nhapFile.Text = "Nhập file.txt";
            this.btn_nhapFile.UseVisualStyleBackColor = true;
            this.btn_nhapFile.Click += new System.EventHandler(this.btn_nhapFile_Click);
            // 
            // btn_xuatFile
            // 
            this.btn_xuatFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatFile.Location = new System.Drawing.Point(824, 441);
            this.btn_xuatFile.Name = "btn_xuatFile";
            this.btn_xuatFile.Size = new System.Drawing.Size(112, 32);
            this.btn_xuatFile.TabIndex = 22;
            this.btn_xuatFile.Text = "Xuất file.txt";
            this.btn_xuatFile.UseVisualStyleBackColor = true;
            this.btn_xuatFile.Click += new System.EventHandler(this.btn_xuatFile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(559, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Số dự án đã đầu tư:";
            // 
            // txt_tenCDT_Search
            // 
            this.txt_tenCDT_Search.Enabled = false;
            this.txt_tenCDT_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenCDT_Search.ForeColor = System.Drawing.Color.Black;
            this.txt_tenCDT_Search.Location = new System.Drawing.Point(824, 501);
            this.txt_tenCDT_Search.Name = "txt_tenCDT_Search";
            this.txt_tenCDT_Search.Size = new System.Drawing.Size(157, 26);
            this.txt_tenCDT_Search.TabIndex = 24;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_timKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_timKiem.Location = new System.Drawing.Point(16, 652);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(97, 32);
            this.btn_timKiem.TabIndex = 25;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_addImg
            // 
            this.btn_addImg.Enabled = false;
            this.btn_addImg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addImg.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_addImg.Location = new System.Drawing.Point(39, 442);
            this.btn_addImg.Name = "btn_addImg";
            this.btn_addImg.Size = new System.Drawing.Size(120, 30);
            this.btn_addImg.TabIndex = 26;
            this.btn_addImg.Text = "(Add Image)";
            this.btn_addImg.UseVisualStyleBackColor = true;
            this.btn_addImg.Click += new System.EventHandler(this.btn_addImg_Click);
            // 
            // txt_urlImage
            // 
            this.txt_urlImage.AutoSize = true;
            this.txt_urlImage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_urlImage.ForeColor = System.Drawing.Color.Crimson;
            this.txt_urlImage.Location = new System.Drawing.Point(22, 572);
            this.txt_urlImage.Name = "txt_urlImage";
            this.txt_urlImage.Size = new System.Drawing.Size(98, 17);
            this.txt_urlImage.TabIndex = 27;
            this.txt_urlImage.Text = "Text Url Image";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(559, 545);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "Thời gian thành lập:";
            // 
            // txt_tgianThanhLap
            // 
            this.txt_tgianThanhLap.Enabled = false;
            this.txt_tgianThanhLap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tgianThanhLap.ForeColor = System.Drawing.Color.Black;
            this.txt_tgianThanhLap.Location = new System.Drawing.Point(824, 545);
            this.txt_tgianThanhLap.Name = "txt_tgianThanhLap";
            this.txt_tgianThanhLap.Size = new System.Drawing.Size(157, 26);
            this.txt_tgianThanhLap.TabIndex = 29;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.Gray;
            this.btn_luu.Enabled = false;
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Location = new System.Drawing.Point(377, 604);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(97, 31);
            this.btn_luu.TabIndex = 30;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_quayLai
            // 
            this.btn_quayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quayLai.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_quayLai.Image = global::DoAn_CongNgheNet_QuanLiDuAnBDS.Properties.Resources.icon_quayLai;
            this.btn_quayLai.Location = new System.Drawing.Point(16, 9);
            this.btn_quayLai.Name = "btn_quayLai";
            this.btn_quayLai.Size = new System.Drawing.Size(81, 35);
            this.btn_quayLai.TabIndex = 31;
            this.btn_quayLai.Text = "Quay lại";
            this.btn_quayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quayLai.UseVisualStyleBackColor = true;
            this.btn_quayLai.Click += new System.EventHandler(this.btn_quayLai_Click);
            // 
            // btn_saoLuu
            // 
            this.btn_saoLuu.BackColor = System.Drawing.Color.Yellow;
            this.btn_saoLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saoLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saoLuu.Location = new System.Drawing.Point(138, 652);
            this.btn_saoLuu.Name = "btn_saoLuu";
            this.btn_saoLuu.Size = new System.Drawing.Size(97, 31);
            this.btn_saoLuu.TabIndex = 32;
            this.btn_saoLuu.Text = "Sao lưu";
            this.btn_saoLuu.UseVisualStyleBackColor = false;
            this.btn_saoLuu.Click += new System.EventHandler(this.btn_saoLuu_Click);
            // 
            // btn_khoiPhuc
            // 
            this.btn_khoiPhuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_khoiPhuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khoiPhuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_khoiPhuc.Location = new System.Drawing.Point(259, 652);
            this.btn_khoiPhuc.Name = "btn_khoiPhuc";
            this.btn_khoiPhuc.Size = new System.Drawing.Size(106, 31);
            this.btn_khoiPhuc.TabIndex = 33;
            this.btn_khoiPhuc.Text = "Khôi phục";
            this.btn_khoiPhuc.UseVisualStyleBackColor = false;
            this.btn_khoiPhuc.Click += new System.EventHandler(this.btn_khoiPhuc_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(411, 681);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "@Lê Lưu Hoàng Nhân - 2001190186";
            // 
            // cb_thue
            // 
            this.cb_thue.Enabled = false;
            this.cb_thue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_thue.FormattingEnabled = true;
            this.cb_thue.Location = new System.Drawing.Point(216, 268);
            this.cb_thue.Name = "cb_thue";
            this.cb_thue.Size = new System.Drawing.Size(284, 29);
            this.cb_thue.TabIndex = 35;
            // 
            // ChuDauTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 710);
            this.Controls.Add(this.cb_thue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_khoiPhuc);
            this.Controls.Add(this.btn_saoLuu);
            this.Controls.Add(this.btn_quayLai);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_tgianThanhLap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_urlImage);
            this.Controls.Add(this.btn_addImg);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txt_tenCDT_Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_xuatFile);
            this.Controls.Add(this.btn_nhapFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtg_duLieu);
            this.Controls.Add(this.btn_resetForm);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.ptb_logo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_duAnDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_ngayDKKD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenCDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_maCDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChuDauTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChuDauTu";
            this.Load += new System.EventHandler(this.ChuDauTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_duLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maCDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenCDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_ngayDKKD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_duAnDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_resetForm;
        private System.Windows.Forms.DataGridView dtg_duLieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_nhapFile;
        private System.Windows.Forms.Button btn_xuatFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tenCDT_Search;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_addImg;
        private System.Windows.Forms.Label txt_urlImage;
        private System.Windows.Forms.TextBox txt_tgianThanhLap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.Button btn_khoiPhuc;
        private System.Windows.Forms.Button btn_saoLuu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_thue;
    }
}