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
    public partial class From_chuaBaocao : Form
    {
        public From_chuaBaocao()
        {
            InitializeComponent();
        }

        private void From_chuaBaocao_Load(object sender, EventArgs e)
        {
            Baocaoxuat baocao = new Baocaoxuat();
            crystalReportViewer1.ReportSource = baocao;
        }
    }
}
