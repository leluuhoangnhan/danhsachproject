namespace DoAn_CongNgheNet_QuanLiDuAnBDS
{
    partial class Thue
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
            this.txt_maSoThue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenThue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_loaiThue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtg_duLieu = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.btn_nhapFile = new System.Windows.Forms.Button();
            this.btn_xuatFile = new System.Windows.Forms.Button();
            this.btn_resetForm = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_saoLuu = new System.Windows.Forms.Button();
            this.btn_khoiPhuc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_duLieu)).BeginInit();
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
            this.btn_quayLai.TabIndex = 65;
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
            this.label1.Location = new System.Drawing.Point(488, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 40);
            this.label1.TabIndex = 66;
            this.label1.Text = "Thuế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã số thuế:";
            // 
            // txt_maSoThue
            // 
            this.txt_maSoThue.Enabled = false;
            this.txt_maSoThue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSoThue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_maSoThue.Location = new System.Drawing.Point(222, 85);
            this.txt_maSoThue.Name = "txt_maSoThue";
            this.txt_maSoThue.Size = new System.Drawing.Size(284, 29);
            this.txt_maSoThue.TabIndex = 68;
            this.txt_maSoThue.Leave += new System.EventHandler(this.txt_maSoThue_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(38, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "Tên thuế:";
            // 
            // txt_tenThue
            // 
            this.txt_tenThue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenThue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_tenThue.Location = new System.Drawing.Point(222, 157);
            this.txt_tenThue.Name = "txt_tenThue";
            this.txt_tenThue.ReadOnly = true;
            this.txt_tenThue.Size = new System.Drawing.Size(284, 29);
            this.txt_tenThue.TabIndex = 70;
            this.txt_tenThue.Leave += new System.EventHandler(this.txt_tenThue_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(38, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "Loại thuế:";
            // 
            // txt_loaiThue
            // 
            this.txt_loaiThue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loaiThue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_loaiThue.Location = new System.Drawing.Point(222, 229);
            this.txt_loaiThue.Name = "txt_loaiThue";
            this.txt_loaiThue.ReadOnly = true;
            this.txt_loaiThue.Size = new System.Drawing.Size(284, 29);
            this.txt_loaiThue.TabIndex = 72;
            this.txt_loaiThue.Leave += new System.EventHandler(this.txt_loaiThue_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(734, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 99;
            this.label9.Text = "Bảng dữ liệu:";
            // 
            // dtg_duLieu
            // 
            this.dtg_duLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_duLieu.Location = new System.Drawing.Point(558, 131);
            this.dtg_duLieu.Name = "dtg_duLieu";
            this.dtg_duLieu.ReadOnly = true;
            this.dtg_duLieu.Size = new System.Drawing.Size(452, 217);
            this.dtg_duLieu.TabIndex = 100;
            this.dtg_duLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_duLieu_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Green;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(42, 305);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 31);
            this.btn_them.TabIndex = 101;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(167, 305);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 31);
            this.btn_xoa.TabIndex = 102;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Chocolate;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(288, 305);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(97, 31);
            this.btn_sua.TabIndex = 103;
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
            this.btn_luu.Location = new System.Drawing.Point(409, 305);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(97, 31);
            this.btn_luu.TabIndex = 104;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_timKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_timKiem.Location = new System.Drawing.Point(42, 367);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(97, 32);
            this.btn_timKiem.TabIndex = 105;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // btn_nhapFile
            // 
            this.btn_nhapFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapFile.Location = new System.Drawing.Point(670, 367);
            this.btn_nhapFile.Name = "btn_nhapFile";
            this.btn_nhapFile.Size = new System.Drawing.Size(112, 32);
            this.btn_nhapFile.TabIndex = 106;
            this.btn_nhapFile.Text = "Nhập file.txt";
            this.btn_nhapFile.UseVisualStyleBackColor = true;
            this.btn_nhapFile.Click += new System.EventHandler(this.btn_nhapFile_Click);
            // 
            // btn_xuatFile
            // 
            this.btn_xuatFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatFile.Location = new System.Drawing.Point(816, 368);
            this.btn_xuatFile.Name = "btn_xuatFile";
            this.btn_xuatFile.Size = new System.Drawing.Size(112, 32);
            this.btn_xuatFile.TabIndex = 107;
            this.btn_xuatFile.Text = "Xuất file.txt";
            this.btn_xuatFile.UseVisualStyleBackColor = true;
            this.btn_xuatFile.Click += new System.EventHandler(this.btn_xuatFile_Click);
            // 
            // btn_resetForm
            // 
            this.btn_resetForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_resetForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_resetForm.Location = new System.Drawing.Point(765, 443);
            this.btn_resetForm.Name = "btn_resetForm";
            this.btn_resetForm.Size = new System.Drawing.Size(132, 31);
            this.btn_resetForm.TabIndex = 108;
            this.btn_resetForm.Text = "Reset Form";
            this.btn_resetForm.UseVisualStyleBackColor = false;
            this.btn_resetForm.Click += new System.EventHandler(this.btn_resetForm_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(923, 443);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(102, 31);
            this.btn_thoat.TabIndex = 109;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_saoLuu
            // 
            this.btn_saoLuu.BackColor = System.Drawing.Color.Yellow;
            this.btn_saoLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saoLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saoLuu.Location = new System.Drawing.Point(167, 367);
            this.btn_saoLuu.Name = "btn_saoLuu";
            this.btn_saoLuu.Size = new System.Drawing.Size(97, 31);
            this.btn_saoLuu.TabIndex = 110;
            this.btn_saoLuu.Text = "Sao lưu";
            this.btn_saoLuu.UseVisualStyleBackColor = false;
            this.btn_saoLuu.Click += new System.EventHandler(this.btn_saoLuu_Click);
            // 
            // btn_khoiPhuc
            // 
            this.btn_khoiPhuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_khoiPhuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khoiPhuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_khoiPhuc.Location = new System.Drawing.Point(288, 367);
            this.btn_khoiPhuc.Name = "btn_khoiPhuc";
            this.btn_khoiPhuc.Size = new System.Drawing.Size(106, 31);
            this.btn_khoiPhuc.TabIndex = 111;
            this.btn_khoiPhuc.Text = "Khôi phục";
            this.btn_khoiPhuc.UseVisualStyleBackColor = false;
            this.btn_khoiPhuc.Click += new System.EventHandler(this.btn_khoiPhuc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(12, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 17);
            this.label5.TabIndex = 112;
            this.label5.Text = "@Lê Lưu Hoàng Nhân - 2001190186";
            // 
            // Thue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 486);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_khoiPhuc);
            this.Controls.Add(this.btn_saoLuu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_resetForm);
            this.Controls.Add(this.btn_xuatFile);
            this.Controls.Add(this.btn_nhapFile);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtg_duLieu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_loaiThue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenThue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_maSoThue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quayLai);
            this.Name = "Thue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thue";
            this.Load += new System.EventHandler(this.Thue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_duLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maSoThue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_loaiThue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtg_duLieu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.Button btn_nhapFile;
        private System.Windows.Forms.Button btn_xuatFile;
        private System.Windows.Forms.Button btn_resetForm;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_saoLuu;
        private System.Windows.Forms.Button btn_khoiPhuc;
        private System.Windows.Forms.Label label5;
    }
}