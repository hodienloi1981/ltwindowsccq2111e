using QLSinhVienEF.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSinhVienEF.EF;
using System.Data.Entity;

namespace QLSinhVienEF.frm
{
    public partial class frmKhoa : Form
    {
        QLSinhVienDBContext db = new QLSinhVienDBContext();
        private string AddOrEdit = null;
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            ShowAndHidden(false);
            loadKhoa();
        }

        private void loadKhoa()
        {
            //SELECT MaKhoa,TenKhoa,GhiChu FROM Khoas
            dgvKhoa.DataSource = db.Khoas.Select(p=>new {p.MaKhoa,p.TenKhoa,p.GhiChu}).ToList();
        }

        private void ShowAndHidden(bool show)
        {
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = show;
            txtGhiChu.Enabled = show;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowAndHidden(true);
            AddOrEdit = "Add";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Edit";
            if(txtMaKhoa.Text.Length>0)
            {
                ShowAndHidden(true);
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenKhoa.Text.Length==0)
                {
                    throw new Exception("Tên khoa không được để trống");
                }
                if(AddOrEdit=="Add")
                {
                    //Luu vào CSDL
                    Khoa k = new Khoa();
                    k.TenKhoa = txtTenKhoa.Text.Trim();
                    k.GhiChu = txtGhiChu.Text.Trim();
                    db.Khoas.Add(k);
                    
                }    
                if(AddOrEdit == "Edit")
                {
                    //Update
                    int makhoa = Convert.ToInt16(txtMaKhoa.Text);
                    //Select * from KHOA WHERE MaKhoa = '1';
                    //Khoa k = db.Khoas.Where(p => p.MaKhoa == makhoa).FirstOrDefault();
                    Khoa k = db.Khoas.Find(makhoa);
                    k.TenKhoa = txtTenKhoa.Text.Trim();
                    k.GhiChu = txtGhiChu.Text.Trim();
                    db.Entry(k).State =EntityState.Modified;
                    
                }    
                db.SaveChanges();
                loadKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thông báo",
                    ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex<dgvKhoa.Rows.Count) {
                int index = e.RowIndex;
                txtMaKhoa.Text = dgvKhoa.Rows[index].Cells["MaKhoa"].Value.ToString();
                txtTenKhoa.Text = dgvKhoa.Rows[index].Cells["TenKhoa"].Value.ToString();
                txtGhiChu.Text = dgvKhoa.Rows[index].Cells["GhiChu"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaKhoa.Text.Length>0)
            {
                int makhoa = Convert.ToInt16(txtMaKhoa.Text);
                Khoa k = db.Khoas.Find(makhoa);
                //DELETE Khoa WHERE Makhoa='1'
                if(k != null)
                {
                    db.Khoas.Remove(k);
                    db.SaveChanges();
                    loadKhoa();
                }
                
            }    
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
