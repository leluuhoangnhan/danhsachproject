namespace DemoDocFileExcelDriveGoogle.View
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.rjProgressBar1 = new DemoDocFileExcelDriveGoogle.Model.RJControls.RJProgressBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading...";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // rjProgressBar1
            // 
            this.rjProgressBar1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rjProgressBar1.ChannelHeight = 10;
            this.rjProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rjProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjProgressBar1.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.rjProgressBar1.ForeColor = System.Drawing.Color.White;
            this.rjProgressBar1.Location = new System.Drawing.Point(0, 589);
            this.rjProgressBar1.Name = "rjProgressBar1";
            this.rjProgressBar1.ShowMaximun = false;
            this.rjProgressBar1.ShowValue = DemoDocFileExcelDriveGoogle.Model.RJControls.TextPosition.None;
            this.rjProgressBar1.Size = new System.Drawing.Size(1000, 11);
            this.rjProgressBar1.SliderColor = System.Drawing.Color.Green;
            this.rjProgressBar1.SliderHeight = 10;
            this.rjProgressBar1.SymbolAfter = "";
            this.rjProgressBar1.SymbolBefore = "";
            this.rjProgressBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DemoDocFileExcelDriveGoogle.Properties.Resources.background_dong2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjProgressBar1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Model.RJControls.RJProgressBar rjProgressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}

