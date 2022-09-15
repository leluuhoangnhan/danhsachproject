using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDocFileExcelDriveGoogle.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rjProgressBar1.Value < rjProgressBar1.Maximum)
            {
                rjProgressBar1.Value++;
                if (rjProgressBar1.Value == rjProgressBar1.Maximum)
                {
                    this.Visible = false;
                    SupportSalesBDS bds = new SupportSalesBDS();
                    bds.Visible = true;
                    MessageBox.Show("Chào mừng bạn đến với Công Ty VietinReal!");
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!label1.Text.ToString().Equals("Loading..."))
            {
                label1.Text = label1.Text + ".";
            }
            else
            {
                label1.Text = "Loading";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rjProgressBar1.Value = 0;
            timer1.Start();
            timer2.Start();
        }



        //start di chuyen form khong co vien
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        //end di chuyen form khong co vien

    }
}

