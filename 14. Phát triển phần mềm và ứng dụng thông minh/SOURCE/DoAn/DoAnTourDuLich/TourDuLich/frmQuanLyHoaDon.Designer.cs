namespace TourDuLich
{
    partial class frmQuanLyHoaDon
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
            this.label10 = new System.Windows.Forms.Label();
            this.dtgv_hoadon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChitiet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSLN = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblCTTour = new System.Windows.Forms.LinkLabel();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblCTHoadon = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSuaTour = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemTour = new System.Windows.Forms.Button();
            this.btn_quayLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(107, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(769, 40);
            this.label10.TabIndex = 32;
            this.label10.Text = "Quản Lý Hóa Đơn";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgv_hoadon
            // 
            this.dtgv_hoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hoadon.Location = new System.Drawing.Point(386, 57);
            this.dtgv_hoadon.Name = "dtgv_hoadon";
            this.dtgv_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_hoadon.Size = new System.Drawing.Size(429, 307);
            this.dtgv_hoadon.TabIndex = 22;
            this.dtgv_hoadon.SelectionChanged += new System.EventHandler(this.dtgv_hoadon_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChitiet);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.lblCTTour);
            this.groupBox1.Controls.Add(this.cboNV);
            this.groupBox1.Controls.Add(this.cboKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.lblCTHoadon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Location = new System.Drawing.Point(8, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 513);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnChitiet
            // 
            this.btnChitiet.Location = new System.Drawing.Point(124, 196);
            this.btnChitiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(87, 23);
            this.btnChitiet.TabIndex = 42;
            this.btnChitiet.Text = "Xem chi tiết";
            this.btnChitiet.UseVisualStyleBackColor = true;
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtSLN);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.txtTenTour);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboTour);
            this.panel2.Location = new System.Drawing.Point(9, 227);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 211);
            this.panel2.TabIndex = 41;
            this.panel2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "SL Người";
            // 
            // txtSLN
            // 
            this.txtSLN.Location = new System.Drawing.Point(67, 17);
            this.txtSLN.Name = "txtSLN";
            this.txtSLN.Size = new System.Drawing.Size(188, 20);
            this.txtSLN.TabIndex = 15;
            this.txtSLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLN_KeyPress);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbChon});
            this.dataGridView2.Location = new System.Drawing.Point(3, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(331, 73);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // cbChon
            // 
            this.cbChon.HeaderText = "Chọn_Ghế";
            this.cbChon.Name = "cbChon";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(67, 96);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.ReadOnly = true;
            this.txtTenTour.Size = new System.Drawing.Size(188, 20);
            this.txtTenTour.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tên Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Tour";
            // 
            // cboTour
            // 
            this.cboTour.FormattingEnabled = true;
            this.cboTour.Location = new System.Drawing.Point(67, 61);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(188, 21);
            this.cboTour.TabIndex = 7;
            this.cboTour.SelectedIndexChanged += new System.EventHandler(this.cboTour_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(124, 473);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(72, 34);
            this.btnOk.TabIndex = 40;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblCTTour
            // 
            this.lblCTTour.AutoSize = true;
            this.lblCTTour.Location = new System.Drawing.Point(7, 473);
            this.lblCTTour.Name = "lblCTTour";
            this.lblCTTour.Size = new System.Drawing.Size(68, 13);
            this.lblCTTour.TabIndex = 13;
            this.lblCTTour.TabStop = true;
            this.lblCTTour.Text = "Chi Tiết Tour";
            this.lblCTTour.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCTTour_LinkClicked);
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(77, 111);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(187, 21);
            this.cboNV.TabIndex = 12;
            // 
            // cboKH
            // 
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(77, 70);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(187, 21);
            this.cboKH.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên NV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên KH";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "MM-dd-yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(79, 160);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(210, 20);
            this.dtpNgayLap.TabIndex = 6;
            // 
            // lblCTHoadon
            // 
            this.lblCTHoadon.AutoSize = true;
            this.lblCTHoadon.Location = new System.Drawing.Point(5, 204);
            this.lblCTHoadon.Name = "lblCTHoadon";
            this.lblCTHoadon.Size = new System.Drawing.Size(89, 13);
            this.lblCTHoadon.TabIndex = 3;
            this.lblCTHoadon.TabStop = true;
            this.lblCTHoadon.Text = "Chi Tiết Hóa Đơn";
            this.lblCTHoadon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCTHoadon_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thành Tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(103, 443);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(147, 20);
            this.txtTongTien.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Lặp HD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HD";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(76, 30);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(113, 20);
            this.txtMaHD.TabIndex = 1;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_timKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_timKiem.Location = new System.Drawing.Point(749, 371);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(97, 32);
            this.btn_timKiem.TabIndex = 37;
            this.btn_timKiem.Text = "Search";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(489, 380);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(257, 20);
            this.txtTimKiem.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tìm kiếm";
            // 
            // btnSuaTour
            // 
            this.btnSuaTour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaTour.BackColor = System.Drawing.Color.Chocolate;
            this.btnSuaTour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaTour.Location = new System.Drawing.Point(624, 431);
            this.btnSuaTour.Name = "btnSuaTour";
            this.btnSuaTour.Size = new System.Drawing.Size(97, 31);
            this.btnSuaTour.TabIndex = 35;
            this.btnSuaTour.Text = "Sửa";
            this.btnSuaTour.UseVisualStyleBackColor = false;
            this.btnSuaTour.Click += new System.EventHandler(this.btnSuaTour_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(521, 431);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 31);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemTour
            // 
            this.btnThemTour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemTour.BackColor = System.Drawing.Color.Green;
            this.btnThemTour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemTour.Location = new System.Drawing.Point(418, 431);
            this.btnThemTour.Name = "btnThemTour";
            this.btnThemTour.Size = new System.Drawing.Size(97, 31);
            this.btnThemTour.TabIndex = 33;
            this.btnThemTour.Text = "Thêm";
            this.btnThemTour.UseVisualStyleBackColor = false;
            this.btnThemTour.Click += new System.EventHandler(this.btnThemTour_Click);
            // 
            // btn_quayLai
            // 
            this.btn_quayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quayLai.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_quayLai.Image = global::TourDuLich.Properties.Resources.icon_quayLai;
            this.btn_quayLai.Location = new System.Drawing.Point(8, 6);
            this.btn_quayLai.Name = "btn_quayLai";
            this.btn_quayLai.Size = new System.Drawing.Size(81, 31);
            this.btn_quayLai.TabIndex = 39;
            this.btn_quayLai.Text = "Back";
            this.btn_quayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quayLai.UseVisualStyleBackColor = true;
            this.btn_quayLai.Click += new System.EventHandler(this.btn_quayLai_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_quayLai);
            this.panel1.Controls.Add(this.dtgv_hoadon);
            this.panel1.Controls.Add(this.btn_timKiem);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnThemTour);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSuaTour);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 577);
            this.panel1.TabIndex = 40;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.BackColor = System.Drawing.Color.Green;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(727, 431);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 31);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgv_hoadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.LinkLabel lblCTHoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lblCTTour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSLN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbChon;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSuaTour;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemTour;
        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnChitiet;
    }
}