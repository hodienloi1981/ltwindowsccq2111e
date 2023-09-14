using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.frm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Nhấn vào đóng");
        }



        private void Bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmBai1();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void Bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmBai2();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
