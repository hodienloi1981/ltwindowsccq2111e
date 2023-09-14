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
    public partial class frmBai2 : Form
    {
        private string thongtin = null;
        private int stt = 1;
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (mtxtMaSV.Text.Length < 10)
                {
                    mtxtMaSV.Focus();
                    throw new Exception("Mã sinh viên không hợp lệ");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    txtHoTen.Focus();
                    throw new Exception("Họ tên không được để trống");
                }
                if (mtxtNgaySinh.Text.Length < 10)
                {
                    mtxtNgaySinh.Focus();
                    throw new Exception("Ngày sinh không hợp lệ");
                }
                string ma = mtxtMaSV.Text;
                string ht = txtHoTen.Text.Trim();
                string ns = mtxtNgaySinh.Text;
                thongtin +=stt+". "+ ma + " " + ht + " " + ns +"\t\n";
                txtThongTin.Text= thongtin;
                stt++;
                mtxtMaSV.Text = null;
                txtHoTen.Text = null;
                mtxtNgaySinh.Text = null;

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }

        }
    }
}
