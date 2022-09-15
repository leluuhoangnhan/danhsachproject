namespace TourDuLich
{
    partial class frmCTTour
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
            this.btn_quayLai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_ngayKT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_ngayBD = new System.Windows.Forms.DateTimePicker();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.ptb_image = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.txtMaLoaiTour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBienSoXe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quayLai
            // 
            this.btn_quayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quayLai.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_quayLai.Image = global::TourDuLich.Properties.Resources.icon_quayLai;
            this.btn_quayLai.Location = new System.Drawing.Point(3, 3);
            this.btn_quayLai.Name = "btn_quayLai";
            this.btn_quayLai.Size = new System.Drawing.Size(81, 31);
            this.btn_quayLai.TabIndex = 113;
            this.btn_quayLai.Text = "Back";
            this.btn_quayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quayLai.UseVisualStyleBackColor = true;
            this.btn_quayLai.Click += new System.EventHandler(this.btn_quayLai_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(276, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 118;
            this.label2.Text = "Chi Tiết Tour";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtp_ngayKT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtp_ngayBD);
            this.panel1.Controls.Add(this.btn_quayLai);
            this.panel1.Controls.Add(this.txtMaTour);
            this.panel1.Controls.Add(this.ptb_image);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTenTour);
            this.panel1.Controls.Add(this.txtMaLoaiTour);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtChiPhi);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtBienSoXe);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 384);
            this.panel1.TabIndex = 126;
            // 
            // dtp_ngayKT
            // 
            this.dtp_ngayKT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ngayKT.Enabled = false;
            this.dtp_ngayKT.Location = new System.Drawing.Point(499, 326);
            this.dtp_ngayKT.Name = "dtp_ngayKT";
            this.dtp_ngayKT.Size = new System.Drawing.Size(174, 20);
            this.dtp_ngayKT.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Tour";
            // 
            // dtp_ngayBD
            // 
            this.dtp_ngayBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ngayBD.Enabled = false;
            this.dtp_ngayBD.Location = new System.Drawing.Point(499, 283);
            this.dtp_ngayBD.Name = "dtp_ngayBD";
            this.dtp_ngayBD.Size = new System.Drawing.Size(174, 20);
            this.dtp_ngayBD.TabIndex = 13;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTour.Location = new System.Drawing.Point(499, 82);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.ReadOnly = true;
            this.txtMaTour.Size = new System.Drawing.Size(174, 20);
            this.txtMaTour.TabIndex = 9;
            // 
            // ptb_image
            // 
            this.ptb_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_image.BackColor = System.Drawing.SystemColors.Control;
            this.ptb_image.Location = new System.Drawing.Point(14, 57);
            this.ptb_image.Name = "ptb_image";
            this.ptb_image.Size = new System.Drawing.Size(343, 310);
            this.ptb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_image.TabIndex = 14;
            this.ptb_image.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 196);
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
            this.label6.Location = new System.Drawing.Point(405, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày Kết Thúc";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTour.Location = new System.Drawing.Point(499, 153);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.ReadOnly = true;
            this.txtTenTour.Size = new System.Drawing.Size(174, 20);
            this.txtTenTour.TabIndex = 7;
            // 
            // txtMaLoaiTour
            // 
            this.txtMaLoaiTour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLoaiTour.Location = new System.Drawing.Point(499, 114);
            this.txtMaLoaiTour.Name = "txtMaLoaiTour";
            this.txtMaLoaiTour.ReadOnly = true;
            this.txtMaLoaiTour.Size = new System.Drawing.Size(174, 20);
            this.txtMaLoaiTour.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên Tour";
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChiPhi.Location = new System.Drawing.Point(499, 196);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.ReadOnly = true;
            this.txtChiPhi.Size = new System.Drawing.Size(174, 20);
            this.txtChiPhi.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày Bắt Đầu";
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBienSoXe.Location = new System.Drawing.Point(499, 244);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.ReadOnly = true;
            this.txtBienSoXe.Size = new System.Drawing.Size(174, 20);
            this.txtBienSoXe.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Biển Số Xe";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Loại Tour";
            // 
            // frmCTTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 405);
            this.Controls.Add(this.panel1);
            this.Name = "frmCTTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCTTour";
            this.Load += new System.EventHandler(this.frmCTTour_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptb_image;
        private System.Windows.Forms.DateTimePicker dtp_ngayKT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_ngayBD;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaLoaiTour;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.TextBox txtBienSoXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenTour;
    }
}