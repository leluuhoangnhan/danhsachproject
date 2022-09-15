namespace DecisionTreeSimulation
{
    partial class Main
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.addClause_Button = new System.Windows.Forms.Button();
            this.removeClause_Button = new System.Windows.Forms.Button();
            this.reset_Button = new System.Windows.Forms.Button();
            this.inputClause_TextBox = new System.Windows.Forms.TextBox();
            this.open_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_xoaColumn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_dongHo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.buildDecisionTree_Button = new System.Windows.Forms.Button();
            this.graph_Panel = new DecisionTreeSimulation.DoubleBufferedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(0, 68);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(401, 257);
            this.dataGrid.TabIndex = 0;
            // 
            // addClause_Button
            // 
            this.addClause_Button.BackColor = System.Drawing.Color.Lime;
            this.addClause_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClause_Button.Location = new System.Drawing.Point(330, 468);
            this.addClause_Button.Name = "addClause_Button";
            this.addClause_Button.Size = new System.Drawing.Size(71, 29);
            this.addClause_Button.TabIndex = 1;
            this.addClause_Button.Text = "Thêm";
            this.addClause_Button.UseVisualStyleBackColor = false;
            this.addClause_Button.Click += new System.EventHandler(this.addClause_Button_Click);
            // 
            // removeClause_Button
            // 
            this.removeClause_Button.BackColor = System.Drawing.Color.Red;
            this.removeClause_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeClause_Button.Location = new System.Drawing.Point(330, 416);
            this.removeClause_Button.Name = "removeClause_Button";
            this.removeClause_Button.Size = new System.Drawing.Size(71, 27);
            this.removeClause_Button.TabIndex = 2;
            this.removeClause_Button.Text = "Xóa";
            this.removeClause_Button.UseVisualStyleBackColor = false;
            this.removeClause_Button.Click += new System.EventHandler(this.removeClause_Button_Click);
            // 
            // reset_Button
            // 
            this.reset_Button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_Button.Location = new System.Drawing.Point(199, 341);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(104, 32);
            this.reset_Button.TabIndex = 3;
            this.reset_Button.Text = "Làm mới";
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // inputClause_TextBox
            // 
            this.inputClause_TextBox.Location = new System.Drawing.Point(172, 474);
            this.inputClause_TextBox.Name = "inputClause_TextBox";
            this.inputClause_TextBox.Size = new System.Drawing.Size(144, 20);
            this.inputClause_TextBox.TabIndex = 4;
            // 
            // open_Button
            // 
            this.open_Button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_Button.Location = new System.Drawing.Point(63, 341);
            this.open_Button.Name = "open_Button";
            this.open_Button.Size = new System.Drawing.Size(103, 32);
            this.open_Button.TabIndex = 7;
            this.open_Button.Text = "Nhập file.txt";
            this.open_Button.UseVisualStyleBackColor = true;
            this.open_Button.Click += new System.EventHandler(this.open_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập tên cột cần thêm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập vị trí cột cần xóa";
            // 
            // txt_xoaColumn
            // 
            this.txt_xoaColumn.Location = new System.Drawing.Point(172, 418);
            this.txt_xoaColumn.Name = "txt_xoaColumn";
            this.txt_xoaColumn.Size = new System.Drawing.Size(144, 20);
            this.txt_xoaColumn.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(479, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "CÂY QUYẾT ĐỊNH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(436, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thành viên thực hiện:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(482, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "1. 2001190186 - Lê Lưu Hoàng Nhân (Code)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(482, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "2. 2001190525 - Trần Văn Hiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(829, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "3. 2001190561 - Bùi Đức Huy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(829, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "4. 2001191901 - Trần Hiếu Nghĩa";
            // 
            // lbl_dongHo
            // 
            this.lbl_dongHo.AutoSize = true;
            this.lbl_dongHo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dongHo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_dongHo.Location = new System.Drawing.Point(11, 570);
            this.lbl_dongHo.Name = "lbl_dongHo";
            this.lbl_dongHo.Size = new System.Drawing.Size(105, 24);
            this.lbl_dongHo.TabIndex = 18;
            this.lbl_dongHo.Text = "Đồng hồ ...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Image = global::DecisionTreeSimulation.Properties.Resources.icon_dong_bo;
            this.btn_reset.Location = new System.Drawing.Point(1002, 559);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(144, 35);
            this.btn_reset.TabIndex = 19;
            this.btn_reset.Text = "Reset Form";
            this.btn_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Image = global::DecisionTreeSimulation.Properties.Resources.icon_x;
            this.btn_exit.Location = new System.Drawing.Point(1167, 559);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(103, 35);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // buildDecisionTree_Button
            // 
            this.buildDecisionTree_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buildDecisionTree_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildDecisionTree_Button.Image = global::DecisionTreeSimulation.Properties.Resources.icon_cong;
            this.buildDecisionTree_Button.Location = new System.Drawing.Point(135, 518);
            this.buildDecisionTree_Button.Name = "buildDecisionTree_Button";
            this.buildDecisionTree_Button.Size = new System.Drawing.Size(119, 31);
            this.buildDecisionTree_Button.TabIndex = 5;
            this.buildDecisionTree_Button.Text = "Tạo cây";
            this.buildDecisionTree_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buildDecisionTree_Button.UseVisualStyleBackColor = false;
            this.buildDecisionTree_Button.Click += new System.EventHandler(this.buildDecisionTree_Button_Click);
            // 
            // graph_Panel
            // 
            this.graph_Panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.graph_Panel.Location = new System.Drawing.Point(417, 68);
            this.graph_Panel.Name = "graph_Panel";
            this.graph_Panel.Size = new System.Drawing.Size(863, 370);
            this.graph_Panel.TabIndex = 6;
            this.graph_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.graph_Panel_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 603);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_dongHo);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_xoaColumn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open_Button);
            this.Controls.Add(this.graph_Panel);
            this.Controls.Add(this.buildDecisionTree_Button);
            this.Controls.Add(this.inputClause_TextBox);
            this.Controls.Add(this.reset_Button);
            this.Controls.Add(this.removeClause_Button);
            this.Controls.Add(this.addClause_Button);
            this.Controls.Add(this.dataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.Text = "Decision Tree Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button addClause_Button;
        private System.Windows.Forms.Button removeClause_Button;
        private System.Windows.Forms.Button reset_Button;
        private System.Windows.Forms.TextBox inputClause_TextBox;
        private System.Windows.Forms.Button buildDecisionTree_Button;
        private DoubleBufferedPanel graph_Panel;
        private System.Windows.Forms.Button open_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_xoaColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_dongHo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_reset;
    }
}

