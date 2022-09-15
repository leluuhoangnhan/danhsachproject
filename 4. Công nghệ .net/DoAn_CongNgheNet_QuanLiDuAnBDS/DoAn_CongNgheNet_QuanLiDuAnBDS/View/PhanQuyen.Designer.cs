namespace DoAn_CongNgheNet_QuanLiDuAnBDS
{
    partial class PhanQuyen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoa_tk = new System.Windows.Forms.Button();
            this.btn_them_tk = new System.Windows.Forms.Button();
            this.cb_nhomND_tk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_taiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtg_duLieu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoaNhom = new System.Windows.Forms.Button();
            this.btn_taoNhom = new System.Windows.Forms.Button();
            this.txt_tenNhom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_bangDuLieu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_xoaQuyen = new System.Windows.Forms.Button();
            this.btn_taoQuyen = new System.Windows.Forms.Button();
            this.cb_quyen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_nhomND_phanQuyen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_resetForm = new System.Windows.Forms.Button();
            this.btn_saoLuu = new System.Windows.Forms.Button();
            this.btn_khoiPhuc = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_duLieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.btn_quayLai.TabIndex = 66;
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
            this.label1.Location = new System.Drawing.Point(432, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 40);
            this.label1.TabIndex = 67;
            this.label1.Text = "Phân Quyền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoa_tk);
            this.groupBox1.Controls.Add(this.btn_them_tk);
            this.groupBox1.Controls.Add(this.cb_nhomND_tk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_matKhau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_taiKhoan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 260);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo tài khoản";
            // 
            // btn_xoa_tk
            // 
            this.btn_xoa_tk.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_xoa_tk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa_tk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa_tk.Location = new System.Drawing.Point(303, 206);
            this.btn_xoa_tk.Name = "btn_xoa_tk";
            this.btn_xoa_tk.Size = new System.Drawing.Size(97, 31);
            this.btn_xoa_tk.TabIndex = 103;
            this.btn_xoa_tk.Text = "Xóa";
            this.btn_xoa_tk.UseVisualStyleBackColor = false;
            this.btn_xoa_tk.Click += new System.EventHandler(this.btn_xoa_tk_Click);
            // 
            // btn_them_tk
            // 
            this.btn_them_tk.BackColor = System.Drawing.Color.Green;
            this.btn_them_tk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_tk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them_tk.Location = new System.Drawing.Point(181, 206);
            this.btn_them_tk.Name = "btn_them_tk";
            this.btn_them_tk.Size = new System.Drawing.Size(97, 31);
            this.btn_them_tk.TabIndex = 102;
            this.btn_them_tk.Text = "Thêm";
            this.btn_them_tk.UseVisualStyleBackColor = false;
            this.btn_them_tk.Click += new System.EventHandler(this.btn_them_tk_Click);
            // 
            // cb_nhomND_tk
            // 
            this.cb_nhomND_tk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nhomND_tk.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_nhomND_tk.FormattingEnabled = true;
            this.cb_nhomND_tk.Location = new System.Drawing.Point(178, 147);
            this.cb_nhomND_tk.Name = "cb_nhomND_tk";
            this.cb_nhomND_tk.Size = new System.Drawing.Size(254, 29);
            this.cb_nhomND_tk.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Nhóm người dùng:";
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_matKhau.Location = new System.Drawing.Point(181, 94);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(251, 26);
            this.txt_matKhau.TabIndex = 71;
            this.txt_matKhau.Leave += new System.EventHandler(this.txt_matKhau_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Mật khẩu:";
            // 
            // txt_taiKhoan
            // 
            this.txt_taiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taiKhoan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_taiKhoan.Location = new System.Drawing.Point(181, 39);
            this.txt_taiKhoan.Name = "txt_taiKhoan";
            this.txt_taiKhoan.Size = new System.Drawing.Size(251, 26);
            this.txt_taiKhoan.TabIndex = 69;
            this.txt_taiKhoan.Leave += new System.EventHandler(this.txt_taiKhoan_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tài khoản:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(670, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 24);
            this.label9.TabIndex = 100;
            this.label9.Text = "Danh sách tài khoản:";
            // 
            // dtg_duLieu
            // 
            this.dtg_duLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_duLieu.Location = new System.Drawing.Point(531, 122);
            this.dtg_duLieu.Name = "dtg_duLieu";
            this.dtg_duLieu.ReadOnly = true;
            this.dtg_duLieu.Size = new System.Drawing.Size(455, 221);
            this.dtg_duLieu.TabIndex = 101;
            this.dtg_duLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_duLieu_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoaNhom);
            this.groupBox2.Controls.Add(this.btn_taoNhom);
            this.groupBox2.Controls.Add(this.txt_tenNhom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(26, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 165);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết lập nhóm";
            // 
            // btn_xoaNhom
            // 
            this.btn_xoaNhom.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_xoaNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaNhom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoaNhom.Location = new System.Drawing.Point(303, 114);
            this.btn_xoaNhom.Name = "btn_xoaNhom";
            this.btn_xoaNhom.Size = new System.Drawing.Size(97, 31);
            this.btn_xoaNhom.TabIndex = 104;
            this.btn_xoaNhom.Text = "Xóa";
            this.btn_xoaNhom.UseVisualStyleBackColor = false;
            this.btn_xoaNhom.Click += new System.EventHandler(this.btn_xoaNhom_Click);
            // 
            // btn_taoNhom
            // 
            this.btn_taoNhom.BackColor = System.Drawing.Color.Green;
            this.btn_taoNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taoNhom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_taoNhom.Location = new System.Drawing.Point(181, 114);
            this.btn_taoNhom.Name = "btn_taoNhom";
            this.btn_taoNhom.Size = new System.Drawing.Size(97, 31);
            this.btn_taoNhom.TabIndex = 103;
            this.btn_taoNhom.Text = "Tạo mới";
            this.btn_taoNhom.UseVisualStyleBackColor = false;
            this.btn_taoNhom.Click += new System.EventHandler(this.btn_taoNhom_Click);
            // 
            // txt_tenNhom
            // 
            this.txt_tenNhom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenNhom.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_tenNhom.Location = new System.Drawing.Point(178, 52);
            this.txt_tenNhom.Name = "txt_tenNhom";
            this.txt_tenNhom.Size = new System.Drawing.Size(254, 26);
            this.txt_tenNhom.TabIndex = 70;
            this.txt_tenNhom.Leave += new System.EventHandler(this.txt_tenNhom_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(22, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 69;
            this.label5.Text = "Tên nhóm:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_bangDuLieu);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btn_xoaQuyen);
            this.groupBox3.Controls.Add(this.btn_taoQuyen);
            this.groupBox3.Controls.Add(this.cb_quyen);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cb_nhomND_phanQuyen);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(531, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 232);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phân quyền";
            // 
            // cb_bangDuLieu
            // 
            this.cb_bangDuLieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bangDuLieu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_bangDuLieu.FormattingEnabled = true;
            this.cb_bangDuLieu.Location = new System.Drawing.Point(181, 75);
            this.cb_bangDuLieu.Name = "cb_bangDuLieu";
            this.cb_bangDuLieu.Size = new System.Drawing.Size(254, 29);
            this.cb_bangDuLieu.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(33, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 106;
            this.label8.Text = "Bảng dữ liệu:";
            // 
            // btn_xoaQuyen
            // 
            this.btn_xoaQuyen.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_xoaQuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaQuyen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoaQuyen.Location = new System.Drawing.Point(321, 178);
            this.btn_xoaQuyen.Name = "btn_xoaQuyen";
            this.btn_xoaQuyen.Size = new System.Drawing.Size(97, 31);
            this.btn_xoaQuyen.TabIndex = 105;
            this.btn_xoaQuyen.Text = "Xóa";
            this.btn_xoaQuyen.UseVisualStyleBackColor = false;
            this.btn_xoaQuyen.Click += new System.EventHandler(this.btn_xoaQuyen_Click);
            // 
            // btn_taoQuyen
            // 
            this.btn_taoQuyen.BackColor = System.Drawing.Color.Green;
            this.btn_taoQuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taoQuyen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_taoQuyen.Location = new System.Drawing.Point(201, 178);
            this.btn_taoQuyen.Name = "btn_taoQuyen";
            this.btn_taoQuyen.Size = new System.Drawing.Size(97, 31);
            this.btn_taoQuyen.TabIndex = 104;
            this.btn_taoQuyen.Text = "Tạo";
            this.btn_taoQuyen.UseVisualStyleBackColor = false;
            this.btn_taoQuyen.Click += new System.EventHandler(this.btn_taoQuyen_Click);
            // 
            // cb_quyen
            // 
            this.cb_quyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_quyen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_quyen.FormattingEnabled = true;
            this.cb_quyen.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "DELETE",
            "UPDATE",
            "ALL"});
            this.cb_quyen.Location = new System.Drawing.Point(181, 122);
            this.cb_quyen.Name = "cb_quyen";
            this.cb_quyen.Size = new System.Drawing.Size(254, 29);
            this.cb_quyen.TabIndex = 100;
            this.cb_quyen.Leave += new System.EventHandler(this.cb_quyen_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(33, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 99;
            this.label7.Text = "Quyền thực thi:";
            // 
            // cb_nhomND_phanQuyen
            // 
            this.cb_nhomND_phanQuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nhomND_phanQuyen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_nhomND_phanQuyen.FormattingEnabled = true;
            this.cb_nhomND_phanQuyen.Location = new System.Drawing.Point(181, 27);
            this.cb_nhomND_phanQuyen.Name = "cb_nhomND_phanQuyen";
            this.cb_nhomND_phanQuyen.Size = new System.Drawing.Size(254, 29);
            this.cb_nhomND_phanQuyen.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(33, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 73;
            this.label6.Text = "Nhóm người dùng:";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(905, 629);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(102, 31);
            this.btn_thoat.TabIndex = 110;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_resetForm
            // 
            this.btn_resetForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_resetForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_resetForm.Location = new System.Drawing.Point(756, 629);
            this.btn_resetForm.Name = "btn_resetForm";
            this.btn_resetForm.Size = new System.Drawing.Size(132, 31);
            this.btn_resetForm.TabIndex = 111;
            this.btn_resetForm.Text = "Reset Form";
            this.btn_resetForm.UseVisualStyleBackColor = false;
            this.btn_resetForm.Click += new System.EventHandler(this.btn_resetForm_Click);
            // 
            // btn_saoLuu
            // 
            this.btn_saoLuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_saoLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saoLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saoLuu.Location = new System.Drawing.Point(147, 566);
            this.btn_saoLuu.Name = "btn_saoLuu";
            this.btn_saoLuu.Size = new System.Drawing.Size(97, 31);
            this.btn_saoLuu.TabIndex = 112;
            this.btn_saoLuu.Text = "Sao lưu";
            this.btn_saoLuu.UseVisualStyleBackColor = false;
            this.btn_saoLuu.Click += new System.EventHandler(this.btn_saoLuu_Click);
            // 
            // btn_khoiPhuc
            // 
            this.btn_khoiPhuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_khoiPhuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khoiPhuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_khoiPhuc.Location = new System.Drawing.Point(275, 566);
            this.btn_khoiPhuc.Name = "btn_khoiPhuc";
            this.btn_khoiPhuc.Size = new System.Drawing.Size(106, 31);
            this.btn_khoiPhuc.TabIndex = 113;
            this.btn_khoiPhuc.Text = "Khôi phục";
            this.btn_khoiPhuc.UseVisualStyleBackColor = false;
            this.btn_khoiPhuc.Click += new System.EventHandler(this.btn_khoiPhuc_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(12, 643);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 17);
            this.label10.TabIndex = 114;
            this.label10.Text = "@Lê Lưu Hoàng Nhân - 2001190186";
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 672);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_khoiPhuc);
            this.Controls.Add(this.btn_saoLuu);
            this.Controls.Add(this.btn_resetForm);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtg_duLieu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quayLai);
            this.Name = "PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_duLieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_taiKhoan;
        private System.Windows.Forms.ComboBox cb_nhomND_tk;
        private System.Windows.Forms.Button btn_them_tk;
        private System.Windows.Forms.Button btn_xoa_tk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtg_duLieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xoaNhom;
        private System.Windows.Forms.Button btn_taoNhom;
        private System.Windows.Forms.TextBox txt_tenNhom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_xoaQuyen;
        private System.Windows.Forms.Button btn_taoQuyen;
        private System.Windows.Forms.ComboBox cb_quyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_nhomND_phanQuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_resetForm;
        private System.Windows.Forms.Button btn_saoLuu;
        private System.Windows.Forms.Button btn_khoiPhuc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cb_bangDuLieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}