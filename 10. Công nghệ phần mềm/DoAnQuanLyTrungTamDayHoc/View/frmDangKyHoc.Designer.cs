namespace DoAnQuanLyTrungTamDayHoc
{
    partial class frmDangKyHoc
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
            this.btnSearchHV = new System.Windows.Forms.Button();
            this.txtMSHV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMSHV = new System.Windows.Forms.ComboBox();
            this.dtgv_HV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTenHV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgv_Lop = new System.Windows.Forms.DataGridView();
            this.cbDangKy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSearchLop = new System.Windows.Forms.Button();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(310, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Ký Học";
            // 
            // btnSearchHV
            // 
            this.btnSearchHV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchHV.Location = new System.Drawing.Point(661, 221);
            this.btnSearchHV.Name = "btnSearchHV";
            this.btnSearchHV.Size = new System.Drawing.Size(75, 23);
            this.btnSearchHV.TabIndex = 3;
            this.btnSearchHV.Text = "Search";
            this.btnSearchHV.UseVisualStyleBackColor = true;
            this.btnSearchHV.Click += new System.EventHandler(this.btnSearchHV_Click);
            // 
            // txtMSHV
            // 
            this.txtMSHV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMSHV.Location = new System.Drawing.Point(526, 221);
            this.txtMSHV.Name = "txtMSHV";
            this.txtMSHV.Size = new System.Drawing.Size(117, 20);
            this.txtMSHV.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "MSHV:";
            // 
            // cbMSHV
            // 
            this.cbMSHV.FormattingEnabled = true;
            this.cbMSHV.Location = new System.Drawing.Point(85, 95);
            this.cbMSHV.Name = "cbMSHV";
            this.cbMSHV.Size = new System.Drawing.Size(238, 21);
            this.cbMSHV.TabIndex = 0;
            this.cbMSHV.SelectedIndexChanged += new System.EventHandler(this.cbMSHV_SelectedIndexChanged);
            // 
            // dtgv_HV
            // 
            this.dtgv_HV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_HV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HV.Location = new System.Drawing.Point(431, 72);
            this.dtgv_HV.Name = "dtgv_HV";
            this.dtgv_HV.Size = new System.Drawing.Size(313, 131);
            this.dtgv_HV.TabIndex = 10;
            this.dtgv_HV.SelectionChanged += new System.EventHandler(this.dtgv_HV_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "MSHV:";
            // 
            // txtHoTenHV
            // 
            this.txtHoTenHV.Enabled = false;
            this.txtHoTenHV.Location = new System.Drawing.Point(85, 143);
            this.txtHoTenHV.Name = "txtHoTenHV";
            this.txtHoTenHV.Size = new System.Drawing.Size(238, 20);
            this.txtHoTenHV.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Họ tên:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Danh Sách Lớp Đang Mở:";
            // 
            // dtgv_Lop
            // 
            this.dtgv_Lop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbDangKy});
            this.dtgv_Lop.Location = new System.Drawing.Point(23, 301);
            this.dtgv_Lop.Name = "dtgv_Lop";
            this.dtgv_Lop.ReadOnly = true;
            this.dtgv_Lop.Size = new System.Drawing.Size(356, 159);
            this.dtgv_Lop.TabIndex = 20;
            // 
            // cbDangKy
            // 
            this.cbDangKy.HeaderText = "Đăng_Ký";
            this.cbDangKy.Name = "cbDangKy";
            this.cbDangKy.ReadOnly = true;
            // 
            // btnSearchLop
            // 
            this.btnSearchLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchLop.Location = new System.Drawing.Point(552, 410);
            this.btnSearchLop.Name = "btnSearchLop";
            this.btnSearchLop.Size = new System.Drawing.Size(75, 23);
            this.btnSearchLop.TabIndex = 5;
            this.btnSearchLop.Text = "Search";
            this.btnSearchLop.UseVisualStyleBackColor = true;
            this.btnSearchLop.Click += new System.EventHandler(this.btnSearchLop_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLop.Location = new System.Drawing.Point(462, 371);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(249, 20);
            this.txtTenLop.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(566, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tên lớp:";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(628, 527);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Image = global::DoAnQuanLyTrungTamDayHoc.Properties.Resources.icon_luu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(213, 484);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 33);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Image = global::DoAnQuanLyTrungTamDayHoc.Properties.Resources.icon_quayLai;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.Location = new System.Drawing.Point(9, 11);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 31);
            this.btnQuayLai.TabIndex = 11;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(733, 527);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(58, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Image = global::DoAnQuanLyTrungTamDayHoc.Properties.Resources.icon_tru;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(126, 484);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 33);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.Image = global::DoAnQuanLyTrungTamDayHoc.Properties.Resources.icon_cong;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(42, 484);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 33);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHuy.Image = global::DoAnQuanLyTrungTamDayHoc.Properties.Resources.icon_x;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(290, 484);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(60, 33);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSearchHV);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.txtMSHV);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtgv_HV);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.cbMSHV);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtHoTenHV);
            this.panel1.Controls.Add(this.dtgv_Lop);
            this.panel1.Controls.Add(this.btnSearchLop);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTenLop);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 553);
            this.panel1.TabIndex = 22;
            // 
            // frmDangKyHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 577);
            this.Controls.Add(this.panel1);
            this.Name = "frmDangKyHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Đăng Ký Học";
            this.Load += new System.EventHandler(this.frmDangKyHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchHV;
        private System.Windows.Forms.TextBox txtMSHV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMSHV;
        private System.Windows.Forms.DataGridView dtgv_HV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTenHV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgv_Lop;
        private System.Windows.Forms.Button btnSearchLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbDangKy;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
    }
}