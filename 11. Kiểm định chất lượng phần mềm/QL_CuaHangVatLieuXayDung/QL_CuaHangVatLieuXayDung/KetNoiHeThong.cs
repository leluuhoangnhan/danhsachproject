using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangVatLieuXayDung
{
    public partial class KetNoiHeThong : Form
    {
        XuLyDuLieu db = new XuLyDuLieu();
        AppSetting appset = new AppSetting();
        string connectionString;
        public KetNoiHeThong()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (txtUID.Text == "")
                connectionString = string.Format("server = {0}; database = {1}; Integrated Security = True;", txtSVName.Text, txtDBName.Text);
            else
                connectionString = string.Format("server = {0}; database = {1}; Integrated Security = False;uid = {2}; pwd {3}", txtSVName.Text, txtDBName.Text,txtUID.Text,txtPassword.Text);

            if (db.testConnection(connectionString))
                MessageBox.Show("Connect Success");
            else
                MessageBox.Show("Connect Fail");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (connectionString != "")
            {
                appset.setConnectionString("QL_CuaHangVLXDConnectionString", connectionString);
                MessageBox.Show("Save Success");
            }          
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Visible = true;
            }
            else
                groupBox1.Visible = false;
        }

        
    }
}
