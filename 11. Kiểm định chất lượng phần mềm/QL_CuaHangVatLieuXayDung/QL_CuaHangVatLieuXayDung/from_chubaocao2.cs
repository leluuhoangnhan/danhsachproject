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
    public partial class from_chubaocao2 : Form
    {
        public from_chubaocao2()
        {
            InitializeComponent();
        }

        private void from_chubaocao2_Load(object sender, EventArgs e)
        {
            Baocaonhap baocao = new Baocaonhap();
            crystalReportViewer1.ReportSource = baocao;
        }
    }
}
