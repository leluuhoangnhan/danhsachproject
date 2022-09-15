namespace TourDuLich
{
    partial class frmThemSuaTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemSuaTour));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_urlImage = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.lbl_chonAnh = new System.Windows.Forms.LinkLabel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.ptb_image = new System.Windows.Forms.PictureBox();
            this.cb_BienSoXe = new System.Windows.Forms.ComboBox();
            this.cb_tenLoaiTour = new System.Windows.Forms.ComboBox();
            this.dtp_ngayKT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_ngayBD = new System.Windows.Forms.DateTimePicker();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cb_BienSoXe);
            this.panel1.Controls.Add(this.txt_urlImage);
            this.panel1.Controls.Add(this.cb_tenLoaiTour);
            this.panel1.Controls.Add(this.dtp_ngayKT);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_chonAnh);
            this.panel1.Controls.Add(this.dtp_ngayBD);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.txtMaTour);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ptb_image);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtChiPhi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenTour);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 482);
            this.panel1.TabIndex = 122;
            // 
            // txt_urlImage
            // 
            this.txt_urlImage.AutoSize = true;
            this.txt_urlImage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_urlImage.ForeColor = System.Drawing.Color.Crimson;
            this.txt_urlImage.Location = new System.Drawing.Point(37, 395);
            this.txt_urlImage.Name = "txt_urlImage";
            this.txt_urlImage.Size = new System.Drawing.Size(98, 17);
            this.txt_urlImage.TabIndex = 129;
            this.txt_urlImage.Text = "Text Url Image";
            this.txt_urlImage.Visible = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Sua.Image = global::TourDuLich.Properties.Resources.icon_dong_bo;
            this.btn_Sua.Location = new System.Drawing.Point(266, 431);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(97, 31);
            this.btn_Sua.TabIndex = 128;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // lbl_chonAnh
            // 
            this.lbl_chonAnh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_chonAnh.AutoSize = true;
            this.lbl_chonAnh.Location = new System.Drawing.Point(155, 367);
            this.lbl_chonAnh.Name = "lbl_chonAnh";
            this.lbl_chonAnh.Size = new System.Drawing.Size(53, 13);
            this.lbl_chonAnh.TabIndex = 127;
            this.lbl_chonAnh.TabStop = true;
            this.lbl_chonAnh.Text = "Chọn ảnh";
            this.lbl_chonAnh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_chonAnh_LinkClicked);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnHuy.Image = global::TourDuLich.Properties.Resources.icon_x;
            this.btnHuy.Location = new System.Drawing.Point(390, 431);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(97, 31);
            this.btnHuy.TabIndex = 126;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_them.Image = global::TourDuLich.Properties.Resources.icon_cong;
            this.btn_them.Location = new System.Drawing.Point(248, 431);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 31);
            this.btn_them.TabIndex = 125;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // ptb_image
            // 
            this.ptb_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_image.Image = ((System.Drawing.Image)(resources.GetObject("ptb_image.Image")));
            this.ptb_image.Location = new System.Drawing.Point(34, 88);
            this.ptb_image.Name = "ptb_image";
            this.ptb_image.Size = new System.Drawing.Size(296, 276);
            this.ptb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_image.TabIndex = 124;
            this.ptb_image.TabStop = false;
            // 
            // cb_BienSoXe
            // 
            this.cb_BienSoXe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_BienSoXe.FormattingEnabled = true;
            this.cb_BienSoXe.Location = new System.Drawing.Point(481, 243);
            this.cb_BienSoXe.Name = "cb_BienSoXe";
            this.cb_BienSoXe.Size = new System.Drawing.Size(208, 21);
            this.cb_BienSoXe.TabIndex = 14;
            // 
            // cb_tenLoaiTour
            // 
            this.cb_tenLoaiTour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_tenLoaiTour.FormattingEnabled = true;
            this.cb_tenLoaiTour.Location = new System.Drawing.Point(481, 121);
            this.cb_tenLoaiTour.Name = "cb_tenLoaiTour";
            this.cb_tenLoaiTour.Size = new System.Drawing.Size(208, 21);
            this.cb_tenLoaiTour.TabIndex = 13;
            // 
            // dtp_ngayKT
            // 
            this.dtp_ngayKT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ngayKT.Location = new System.Drawing.Point(481, 333);
            this.dtp_ngayKT.Name = "dtp_ngayKT";
            this.dtp_ngayKT.Size = new System.Drawing.Size(208, 20);
            this.dtp_ngayKT.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Tour";
            // 
            // dtp_ngayBD
            // 
            this.dtp_ngayBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ngayBD.Location = new System.Drawing.Point(481, 290);
            this.dtp_ngayBD.Name = "dtp_ngayBD";
            this.dtp_ngayBD.Size = new System.Drawing.Size(208, 20);
            this.dtp_ngayBD.TabIndex = 9;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTour.Location = new System.Drawing.Point(481, 89);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(208, 20);
            this.txtMaTour.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Chi Phí";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày Kết Thúc";
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChiPhi.Location = new System.Drawing.Point(481, 203);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(208, 20);
            this.txtChiPhi.TabIndex = 7;
            this.txtChiPhi.Leave += new System.EventHandler(this.txtChiPhi_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Loại Tour";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Biển Số Xe";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày Bắt Đầu";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên Tour";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTour.Location = new System.Drawing.Point(481, 160);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(208, 20);
            this.txtTenTour.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 31);
            this.label1.TabIndex = 122;
            this.label1.Text = "Thêm Mới | Cập Nhật Tour Du Lịch";
            // 
            // frmThemSuaTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.Controls.Add(this.panel1);
            this.Name = "frmThemSuaTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemTour";
            this.Load += new System.EventHandler(this.frmThemTour_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_urlImage;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.LinkLabel lbl_chonAnh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.PictureBox ptb_image;
        private System.Windows.Forms.ComboBox cb_BienSoXe;
        private System.Windows.Forms.ComboBox cb_tenLoaiTour;
        private System.Windows.Forms.DateTimePicker dtp_ngayKT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_ngayBD;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label label1;
    }
}