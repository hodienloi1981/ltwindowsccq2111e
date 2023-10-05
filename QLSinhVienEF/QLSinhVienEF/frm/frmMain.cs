using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSinhVienEF.frm;

namespace QLSinhVienEF.frm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            Form frm = new frmSinhVien();
            frm.ShowDialog();
        }

        private void btnQLKhoa_Click(object sender, EventArgs e)
        {
            Form frm = new frmKhoa();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
