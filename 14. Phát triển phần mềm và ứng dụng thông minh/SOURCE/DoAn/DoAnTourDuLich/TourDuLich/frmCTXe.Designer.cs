namespace TourDuLich
{
    partial class frmCTXe
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
            this.cboMaGhe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTinhTrangGhe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_quayLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMaGhe
            // 
            this.cboMaGhe.FormattingEnabled = true;
            this.cboMaGhe.Location = new System.Drawing.Point(164, 235);
            this.cboMaGhe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaGhe.Name = "cboMaGhe";
            this.cboMaGhe.Size = new System.Drawing.Size(259, 28);
            this.cboMaGhe.TabIndex = 2;
            this.cboMaGhe.SelectedIndexChanged += new System.EventHandler(this.cboMaGhe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình Trạng Ghế";
            // 
            // txtTinhTrangGhe
            // 
            this.txtTinhTrangGhe.Location = new System.Drawing.Point(164, 311);
            this.txtTinhTrangGhe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTinhTrangGhe.Name = "txtTinhTrangGhe";
            this.txtTinhTrangGhe.Size = new System.Drawing.Size(259, 26);
            this.txtTinhTrangGhe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Ghế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tình Trạng Xe";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(164, 163);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(259, 26);
            this.txtTinhTrang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(164, 103);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(259, 26);
            this.txtMaNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(177, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 33);
            this.label3.TabIndex = 23;
            this.label3.Text = "Chi Tiết Xe";
            // 
            // btn_quayLai
            // 
            this.btn_quayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quayLai.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_quayLai.Image = global::TourDuLich.Properties.Resources.icon_quayLai;
            this.btn_quayLai.Location = new System.Drawing.Point(0, 5);
            this.btn_quayLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_quayLai.Name = "btn_quayLai";
            this.btn_quayLai.Size = new System.Drawing.Size(122, 48);
            this.btn_quayLai.TabIndex = 25;
            this.btn_quayLai.Text = "Back";
            this.btn_quayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quayLai.UseVisualStyleBackColor = true;
            this.btn_quayLai.Click += new System.EventHandler(this.btn_quayLai_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cboMaGhe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTinhTrangGhe);
            this.panel1.Controls.Add(this.txtTinhTrang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(54, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 432);
            this.panel1.TabIndex = 26;
            // 
            // frmCTXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_quayLai);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCTXe";
            this.Text = "Chi tiết xe";
            this.Load += new System.EventHandler(this.frmCTXe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTinhTrangGhe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaGhe;
        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.Panel panel1;
    }
}