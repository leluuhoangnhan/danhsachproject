namespace DoAn_CongNgheNet_QuanLiDuAnBDS
{
    partial class DangNhap
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
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dangKy = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(209, 114);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(182, 20);
            this.txt_ten.TabIndex = 1;
            this.txt_ten.Leave += new System.EventHandler(this.txt_ten_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(44, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đăng Nhập/ Đăng Ký";
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dangNhap.Location = new System.Drawing.Point(126, 227);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(89, 30);
            this.btn_dangNhap.TabIndex = 5;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(209, 165);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(182, 20);
            this.txt_pass.TabIndex = 7;
            this.txt_pass.UseSystemPasswordChar = true;
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu";
            // 
            // btn_dangKy
            // 
            this.btn_dangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangKy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dangKy.Location = new System.Drawing.Point(234, 227);
            this.btn_dangKy.Name = "btn_dangKy";
            this.btn_dangKy.Size = new System.Drawing.Size(89, 30);
            this.btn_dangKy.TabIndex = 9;
            this.btn_dangKy.Text = "Đăng ký";
            this.btn_dangKy.UseVisualStyleBackColor = true;
            this.btn_dangKy.Click += new System.EventHandler(this.btn_dangKy_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Image = global::DoAn_CongNgheNet_QuanLiDuAnBDS.Properties.Resources.icon_x;
            this.btn_thoat.Location = new System.Drawing.Point(349, 338);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(86, 34);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reset.Location = new System.Drawing.Point(176, 280);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(89, 30);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(12, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "@Lê Lưu Hoàng Nhân - 2001190186";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 384);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_dangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dangKy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label4;
    }
}