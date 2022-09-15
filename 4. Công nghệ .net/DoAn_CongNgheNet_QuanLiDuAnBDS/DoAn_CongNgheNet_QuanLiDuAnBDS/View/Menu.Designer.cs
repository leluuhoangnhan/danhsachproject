namespace DoAn_CongNgheNet_QuanLiDuAnBDS
{
    partial class Menu
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
            this.cb_menu = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU QUẢN LÝ BDS";
            // 
            // cb_menu
            // 
            this.cb_menu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_menu.FormattingEnabled = true;
            this.cb_menu.Items.AddRange(new object[] {
            "Chủ Đầu Tư",
            "Dự Án",
            "Khách Hàng",
            "Thuế",
            "Khu Đất",
            "Phân Quyền",
            "Khác"});
            this.cb_menu.Location = new System.Drawing.Point(77, 138);
            this.cb_menu.Name = "cb_menu";
            this.cb_menu.Size = new System.Drawing.Size(303, 31);
            this.cb_menu.TabIndex = 1;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(462, 315);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(112, 36);
            this.btn_thoat.TabIndex = 15;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dangXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangXuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dangXuat.Location = new System.Drawing.Point(334, 315);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Size = new System.Drawing.Size(112, 36);
            this.btn_dangXuat.TabIndex = 16;
            this.btn_dangXuat.Text = "Đăng xuất";
            this.btn_dangXuat.UseVisualStyleBackColor = false;
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Green;
            this.btn_ok.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ok.Location = new System.Drawing.Point(440, 134);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(116, 39);
            this.btn_ok.TabIndex = 17;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(12, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "@Lê Lưu Hoàng Nhân - 2001190186";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_dangXuat);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.cb_menu);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_menu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangXuat;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label4;
    }
}