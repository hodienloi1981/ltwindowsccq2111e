using System;
using System.Collections;
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
    public partial class frmBai01 : Form
    {
        List<String> listMonAn = new List<String>();
        double[] price = { 0, 25000, 30000, 28000, 35000 };
        double tongtien = 0;
        public frmBai01()
        {
            InitializeComponent();
        }
        private void TaoMonAn()
        {
            listMonAn.Add("Hãy chọn món");//0
            listMonAn.Add("Bún Bò");//1
            listMonAn.Add("Phở Bò");//2
            listMonAn.Add("Bánh Canh");//3
            listMonAn.Add("Cơm chiên");//4
        }
        private void frmBai01_Load(object sender, EventArgs e)
        {
            TaoMonAn();
            loadCBMonAn();
            btnXoa.Enabled = false;
        }
        private void loadCBMonAn()
        {
            cbMonAn.DataSource = listMonAn;
        }

        private void cbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vtchon = cbMonAn.SelectedIndex; //trả về vị trí chon
            txtGia.Text = price[vtchon].ToString();
            txtGia.ReadOnly = true;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cbMonAn.SelectedIndex!=0)
            {
                //Them vào listBox
                double tien = Convert.ToInt16(txtSoLuong.Text) * Convert.ToDouble(txtGia.Text);
                //string thongtinmon = cbMonAn.Text +" "+ txtSoLuong.Text + " " +txtGia.Text +" "+tien.ToString();
                //lbMonDuocChon.Items.Add(thongtinmon);
                tongtien += tien;
                lblTongTien.Text = "Tổng tiền: " + tongtien;
                //Them vao ListView
                ListViewItem item = new ListViewItem(cbMonAn.Text);
                item.SubItems.Add(txtSoLuong.Text);
                item.SubItems.Add(txtGia.Text);
                item.SubItems.Add(tien.ToString());
                lvMonAnDaChon.Items.Add(item);
            }    
        }

        private void lbMonDuocChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled =true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int vtchon = lbMonDuocChon.SelectedIndex;
            if(vtchon>=0)
            {
                lbMonDuocChon.Items.RemoveAt(lbMonDuocChon.SelectedIndex);
            }    
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lbMonDuocChon.Items.Clear();
        }
    }
}
