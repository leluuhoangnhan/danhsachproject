namespace DoAnQuanLyTrungTamDayHoc
{
    partial class frmThoiKhoaBieu
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
            this.dtgv_TKB = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TKB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_TKB
            // 
            this.dtgv_TKB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_TKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_TKB.Location = new System.Drawing.Point(52, 68);
            this.dtgv_TKB.Name = "dtgv_TKB";
            this.dtgv_TKB.ReadOnly = true;
            this.dtgv_TKB.Size = new System.Drawing.Size(601, 267);
            this.dtgv_TKB.TabIndex = 29;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Image = global::DoAnQuanLyTrungTamDayHoc.Properties.Resources.icon_quayLai;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.Location = new System.Drawing.Point(3, 3);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 31);
            this.btnQuayLai.TabIndex = 28;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(251, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thời Khóa Biểu";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtgv_TKB);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 359);
            this.panel1.TabIndex = 30;
            // 
            // frmThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 383);
            this.Controls.Add(this.panel1);
            this.Name = "frmThoiKhoaBieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThoiKhoaBieu";
            this.Load += new System.EventHandler(this.frmThoiKhoaBieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TKB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_TKB;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}