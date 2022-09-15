namespace TourDuLich
{
    partial class frmQuanLyTour
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiTour = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoaiTour = new System.Windows.Forms.TextBox();
            this.dtgv_loaiTour = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_xemChiTietTour = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLoaiTour_Tour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.dtgv_Tour = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_quayLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSuaTour = new System.Windows.Forms.Button();
            this.btnXoaTour = new System.Windows.Forms.Button();
            this.btnThemTour = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_resetForm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaiTour)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Tour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Loại Tour";
            // 
            // txtMaLoaiTour
            // 
            this.txtMaLoaiTour.Location = new System.Drawing.Point(82, 33);
            this.txtMaLoaiTour.Name = "txtMaLoaiTour";
            this.txtMaLoaiTour.ReadOnly = true;
            this.txtMaLoaiTour.Size = new System.Drawing.Size(100, 20);
            this.txtMaLoaiTour.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenLoaiTour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaLoaiTour);
            this.groupBox1.Location = new System.Drawing.Point(19, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại Tour";
            // 
            // txtTenLoaiTour
            // 
            this.txtTenLoaiTour.Location = new System.Drawing.Point(82, 83);
            this.txtTenLoaiTour.Name = "txtTenLoaiTour";
            this.txtTenLoaiTour.Size = new System.Drawing.Size(171, 20);
            this.txtTenLoaiTour.TabIndex = 0;
            // 
            // dtgv_loaiTour
            // 
            this.dtgv_loaiTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_loaiTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_loaiTour.Location = new System.Drawing.Point(399, 62);
            this.dtgv_loaiTour.Name = "dtgv_loaiTour";
            this.dtgv_loaiTour.Size = new System.Drawing.Size(432, 150);
            this.dtgv_loaiTour.TabIndex = 9;
            this.dtgv_loaiTour.SelectionChanged += new System.EventHandler(this.dtgv_loaiTour_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lbl_xemChiTietTour);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtChiPhi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTenTour);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaLoaiTour_Tour);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaTour);
            this.groupBox2.Location = new System.Drawing.Point(19, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 229);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tour";
            // 
            // lbl_xemChiTietTour
            // 
            this.lbl_xemChiTietTour.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_xemChiTietTour.AutoSize = true;
            this.lbl_xemChiTietTour.Location = new System.Drawing.Point(12, 204);
            this.lbl_xemChiTietTour.Name = "lbl_xemChiTietTour";
            this.lbl_xemChiTietTour.Size = new System.Drawing.Size(62, 13);
            this.lbl_xemChiTietTour.TabIndex = 0;
            this.lbl_xemChiTietTour.TabStop = true;
            this.lbl_xemChiTietTour.Text = "Xem chi tiết";
            this.lbl_xemChiTietTour.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_xemChiTietTour_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Chi Phí";
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(88, 146);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(174, 20);
            this.txtChiPhi.TabIndex = 2;
            this.txtChiPhi.Leave += new System.EventHandler(this.txtChiPhi_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên Tour";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(88, 103);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(174, 20);
            this.txtTenTour.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Loại Tour";
            // 
            // txtMaLoaiTour_Tour
            // 
            this.txtMaLoaiTour_Tour.Location = new System.Drawing.Point(88, 64);
            this.txtMaLoaiTour_Tour.Name = "txtMaLoaiTour_Tour";
            this.txtMaLoaiTour_Tour.Size = new System.Drawing.Size(174, 20);
            this.txtMaLoaiTour_Tour.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Tour";
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(88, 32);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.ReadOnly = true;
            this.txtMaTour.Size = new System.Drawing.Size(174, 20);
            this.txtMaTour.TabIndex = 8;
            // 
            // dtgv_Tour
            // 
            this.dtgv_Tour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Tour.Location = new System.Drawing.Point(399, 294);
            this.dtgv_Tour.Name = "dtgv_Tour";
            this.dtgv_Tour.Size = new System.Drawing.Size(432, 207);
            this.dtgv_Tour.TabIndex = 11;
            this.dtgv_Tour.SelectionChanged += new System.EventHandler(this.dtgv_Tour_SelectionChanged);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sua.BackColor = System.Drawing.Color.Chocolate;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(692, 227);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(97, 31);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(571, 227);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 31);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_them.BackColor = System.Drawing.Color.Green;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(446, 227);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 31);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_quayLai
            // 
            this.btn_quayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quayLai.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_quayLai.Image = global::TourDuLich.Properties.Resources.icon_quayLai;
            this.btn_quayLai.Location = new System.Drawing.Point(3, 3);
            this.btn_quayLai.Name = "btn_quayLai";
            this.btn_quayLai.Size = new System.Drawing.Size(81, 31);
            this.btn_quayLai.TabIndex = 0;
            this.btn_quayLai.Text = "Back";
            this.btn_quayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quayLai.UseVisualStyleBackColor = true;
            this.btn_quayLai.Click += new System.EventHandler(this.btn_quayLai_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_resetForm);
            this.panel1.Controls.Add(this.btn_quayLai);
            this.panel1.Controls.Add(this.btn_timKiem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSuaTour);
            this.panel1.Controls.Add(this.btnXoaTour);
            this.panel1.Controls.Add(this.btnThemTour);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtgv_loaiTour);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.dtgv_Tour);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 695);
            this.panel1.TabIndex = 2;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_timKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_timKiem.Location = new System.Drawing.Point(711, 511);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(97, 32);
            this.btn_timKiem.TabIndex = 7;
            this.btn_timKiem.Text = "Search";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(513, 517);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(179, 20);
            this.txtTimKiem.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tìm kiếm";
            // 
            // btnSuaTour
            // 
            this.btnSuaTour.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSuaTour.BackColor = System.Drawing.Color.Chocolate;
            this.btnSuaTour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaTour.Location = new System.Drawing.Point(694, 571);
            this.btnSuaTour.Name = "btnSuaTour";
            this.btnSuaTour.Size = new System.Drawing.Size(97, 31);
            this.btnSuaTour.TabIndex = 5;
            this.btnSuaTour.Text = "Sửa";
            this.btnSuaTour.UseVisualStyleBackColor = false;
            this.btnSuaTour.Click += new System.EventHandler(this.btnSuaTour_Click);
            // 
            // btnXoaTour
            // 
            this.btnXoaTour.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoaTour.BackColor = System.Drawing.Color.Red;
            this.btnXoaTour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaTour.Location = new System.Drawing.Point(573, 571);
            this.btnXoaTour.Name = "btnXoaTour";
            this.btnXoaTour.Size = new System.Drawing.Size(97, 31);
            this.btnXoaTour.TabIndex = 4;
            this.btnXoaTour.Text = "Xóa";
            this.btnXoaTour.UseVisualStyleBackColor = false;
            this.btnXoaTour.Click += new System.EventHandler(this.btnXoaTour_Click);
            // 
            // btnThemTour
            // 
            this.btnThemTour.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThemTour.BackColor = System.Drawing.Color.Green;
            this.btnThemTour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemTour.Location = new System.Drawing.Point(448, 571);
            this.btnThemTour.Name = "btnThemTour";
            this.btnThemTour.Size = new System.Drawing.Size(97, 31);
            this.btnThemTour.TabIndex = 3;
            this.btnThemTour.Text = "Thêm";
            this.btnThemTour.UseVisualStyleBackColor = false;
            this.btnThemTour.Click += new System.EventHandler(this.btnThemTour_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(744, 661);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(102, 31);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_resetForm
            // 
            this.btn_resetForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resetForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_resetForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_resetForm.Location = new System.Drawing.Point(606, 661);
            this.btn_resetForm.Name = "btn_resetForm";
            this.btn_resetForm.Size = new System.Drawing.Size(132, 31);
            this.btn_resetForm.TabIndex = 0;
            this.btn_resetForm.Text = "Reset Form";
            this.btn_resetForm.UseVisualStyleBackColor = false;
            this.btn_resetForm.Click += new System.EventHandler(this.btn_resetForm_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(312, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quản Lý Tour Du Lịch";
            // 
            // frmQuanLyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 723);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiTour";
            this.Load += new System.EventHandler(this.frmQuanLyTour_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaiTour)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Tour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiTour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoaiTour;
        private System.Windows.Forms.DataGridView dtgv_loaiTour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLoaiTour_Tour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.DataGridView dtgv_Tour;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.LinkLabel lbl_xemChiTietTour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_resetForm;
        private System.Windows.Forms.Button btnSuaTour;
        private System.Windows.Forms.Button btnXoaTour;
        private System.Windows.Forms.Button btnThemTour;
        private System.Windows.Forms.Label label8;
    }
}