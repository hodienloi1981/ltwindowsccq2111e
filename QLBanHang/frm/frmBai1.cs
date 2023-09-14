using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.frm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
          
            try
            {
                double a,b;
                if(!double.TryParse(txtSoA.Text.Trim(),out a))
                {
                    txtSoA.Focus();
                    throw new Exception("A không phải là số");
                }

                if (!double.TryParse(txtSoB.Text.Trim(), out b))
                {
                    txtSoB.Focus();
                    throw new Exception("B không phải là số");
                }
                double t = a + b;
                lblKetQua.Text = "Kết quả =" + t;
            }
            catch (Exception msg)
            {
                lblKetQua.Text = msg.Message;
            }
        }
    }
}
