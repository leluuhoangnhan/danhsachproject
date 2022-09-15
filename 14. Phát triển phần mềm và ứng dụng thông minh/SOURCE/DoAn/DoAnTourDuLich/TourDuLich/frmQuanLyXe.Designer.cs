namespace TourDuLich
{
    partial class frmQuanLyXe
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
            this.dtgv_xe = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaLoaiXe_Xe = new System.Windows.Forms.TextBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.dtgv_loaixe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoGhe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiXe = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSuaXe = new System.Windows.Forms.Button();
            this.btnXoaXe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_resetForm = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btnThemXe = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_quayLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_xe)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaixe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_xe
            // 
            this.dtgv_xe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgv_xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_xe.Location = new System.Drawing.Point(489, 411);
            this.dtgv_xe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgv_xe.Name = "dtgv_xe";
            this.dtgv_xe.Size = new System.Drawing.Size(610, 318);
            this.dtgv_xe.TabIndex = 22;
            this.dtgv_xe.SelectionChanged += new System.EventHandler(this.dtgv_xe_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cboMaNV);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTinhTrang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMaLoaiXe_Xe);
            this.groupBox2.Controls.Add(this.txtBienSo);
            this.groupBox2.Location = new System.Drawing.Point(18, 411);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(429, 318);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xe";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(128, 98);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(258, 28);
            this.cboMaNV.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(18, 266);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Xem chi tiết";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tình Trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(132, 158);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(259, 26);
            this.txtTinhTrang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Biển Số Xe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Loại Xe";
            // 
            // txtMaLoaiXe_Xe
            // 
            this.txtMaLoaiXe_Xe.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaLoaiXe_Xe.Location = new System.Drawing.Point(134, 225);
            this.txtMaLoaiXe_Xe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLoaiXe_Xe.Name = "txtMaLoaiXe_Xe";
            this.txtMaLoaiXe_Xe.Size = new System.Drawing.Size(148, 26);
            this.txtMaLoaiXe_Xe.TabIndex = 1;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(132, 49);
            this.txtBienSo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(259, 26);
            this.txtBienSo.TabIndex = 1;
            // 
            // dtgv_loaixe
            // 
            this.dtgv_loaixe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgv_loaixe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_loaixe.Location = new System.Drawing.Point(489, 77);
            this.dtgv_loaixe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgv_loaixe.Name = "dtgv_loaixe";
            this.dtgv_loaixe.Size = new System.Drawing.Size(628, 231);
            this.dtgv_loaixe.TabIndex = 13;
            this.dtgv_loaixe.SelectionChanged += new System.EventHandler(this.dtgv_loaixe_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtChiPhi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoGhe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenLoai);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaLoaiXe);
            this.groupBox1.Location = new System.Drawing.Point(18, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(406, 292);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chi Phí";
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(128, 238);
            this.txtChiPhi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(254, 26);
            this.txtChiPhi.TabIndex = 1;
            this.txtChiPhi.Leave += new System.EventHandler(this.txtChiPhi_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Ghế";
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.Location = new System.Drawing.Point(123, 177);
            this.txtSoGhe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.Size = new System.Drawing.Size(254, 26);
            this.txtSoGhe.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại ";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(128, 109);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(254, 26);
            this.txtTenLoai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Xe";
            // 
            // txtMaLoaiXe
            // 
            this.txtMaLoaiXe.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaLoaiXe.Location = new System.Drawing.Point(123, 51);
            this.txtMaLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLoaiXe.Name = "txtMaLoaiXe";
            this.txtMaLoaiXe.Size = new System.Drawing.Size(148, 26);
            this.txtMaLoaiXe.TabIndex = 1;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Green;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(4, 5);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(146, 48);
            this.btn_them.TabIndex = 23;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(154, 5);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(146, 48);
            this.btn_xoa.TabIndex = 24;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Chocolate;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(314, 5);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(146, 48);
            this.btn_sua.TabIndex = 25;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_timKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_timKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_timKiem.Location = new System.Drawing.Point(936, 749);
            this.btn_timKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(146, 49);
            this.btn_timKiem.TabIndex = 30;
            this.btn_timKiem.Text = "Search";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Location = new System.Drawing.Point(639, 758);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(266, 26);
            this.txtTimKiem.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(504, 760);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 27);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tìm kiếm";
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.BackColor = System.Drawing.Color.Chocolate;
            this.btnSuaXe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaXe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaXe.Location = new System.Drawing.Point(315, 6);
            this.btnSuaXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Size = new System.Drawing.Size(146, 48);
            this.btnSuaXe.TabIndex = 28;
            this.btnSuaXe.Text = "Sửa";
            this.btnSuaXe.UseVisualStyleBackColor = false;
            this.btnSuaXe.Click += new System.EventHandler(this.btnSuaXe_Click);
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.BackColor = System.Drawing.Color.Red;
            this.btnXoaXe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaXe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaXe.Location = new System.Drawing.Point(160, 6);
            this.btnXoaXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(146, 48);
            this.btnXoaXe.TabIndex = 27;
            this.btnXoaXe.Text = "Xóa";
            this.btnXoaXe.UseVisualStyleBackColor = false;
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_resetForm);
            this.panel2.Controls.Add(this.btn_thoat);
            this.panel2.Location = new System.Drawing.Point(802, 1077);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 55);
            this.panel2.TabIndex = 32;
            // 
            // btn_resetForm
            // 
            this.btn_resetForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resetForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_resetForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_resetForm.Location = new System.Drawing.Point(18, 3);
            this.btn_resetForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_resetForm.Name = "btn_resetForm";
            this.btn_resetForm.Size = new System.Drawing.Size(198, 48);
            this.btn_resetForm.TabIndex = 0;
            this.btn_resetForm.Text = "Reset Form";
            this.btn_resetForm.UseVisualStyleBackColor = false;
            this.btn_resetForm.Click += new System.EventHandler(this.btn_resetForm_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(228, 5);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(153, 48);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Controls.Add(this.btn_huy);
            this.panel4.Controls.Add(this.btnThemXe);
            this.panel4.Controls.Add(this.btnXoaXe);
            this.panel4.Controls.Add(this.btnSuaXe);
            this.panel4.Location = new System.Drawing.Point(324, 829);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(812, 60);
            this.panel4.TabIndex = 33;
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnLuu.Image = global::TourDuLich.Properties.Resources.icon_luu;
            this.btnLuu.Location = new System.Drawing.Point(484, 6);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(153, 48);
            this.btnLuu.TabIndex = 134;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Enabled = false;
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_huy.Image = global::TourDuLich.Properties.Resources.icon_x;
            this.btn_huy.Location = new System.Drawing.Point(654, 6);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(153, 48);
            this.btn_huy.TabIndex = 134;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.BackColor = System.Drawing.Color.Green;
            this.btnThemXe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemXe.Location = new System.Drawing.Point(8, 6);
            this.btnThemXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(146, 48);
            this.btnThemXe.TabIndex = 26;
            this.btnThemXe.Text = "Thêm";
            this.btnThemXe.UseVisualStyleBackColor = false;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(466, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 41);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quản Lý Xe";
            // 
            // btn_quayLai
            // 
            this.btn_quayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quayLai.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_quayLai.Image = global::TourDuLich.Properties.Resources.icon_quayLai;
            this.btn_quayLai.Location = new System.Drawing.Point(18, 0);
            this.btn_quayLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_quayLai.Name = "btn_quayLai";
            this.btn_quayLai.Size = new System.Drawing.Size(122, 48);
            this.btn_quayLai.TabIndex = 0;
            this.btn_quayLai.Text = "Back";
            this.btn_quayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quayLai.UseVisualStyleBackColor = true;
            this.btn_quayLai.Click += new System.EventHandler(this.btn_quayLai_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Location = new System.Drawing.Point(561, 317);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 63);
            this.panel1.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btn_quayLai);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.dtgv_loaixe);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.dtgv_xe);
            this.panel3.Controls.Add(this.btn_timKiem);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Location = new System.Drawing.Point(18, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1167, 936);
            this.panel3.TabIndex = 35;
            // 
            // frmQuanLyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1206, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyXe";
            this.Text = "Quản lý xe";
            this.Load += new System.EventHandler(this.frmQuanLyXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_xe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaixe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_xe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.DataGridView dtgv_loaixe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoGhe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiXe;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSuaXe;
        private System.Windows.Forms.Button btnXoaXe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_resetForm;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaLoaiXe_Xe;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Button btnThemXe;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}