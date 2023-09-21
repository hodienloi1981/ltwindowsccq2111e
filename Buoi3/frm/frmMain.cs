using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3.frm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbtnThucThi_Click(object sender, EventArgs e)
        {
            string url = tstxtUrl.Text;
            webBrowser1.Navigate(url);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslblThoiGian.Text ="Hôm nay là: "+ DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
