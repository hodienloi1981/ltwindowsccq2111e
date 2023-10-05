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
    public partial class frmSinhVien : Form
    {
        QLSinhVienDBContext db = new QLSinhVienDBContext();
        private string AddOrEdit = null;
        public frmSinhVien()
        {
            InitializeComponent();
        }


        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            loadKhoa();
            loadSinhVien();
        }

        private void loadSinhVien()
        {

            dgvSinhVien.DataSource = db.SinhViens
                .Join(db.Khoas,s=>s.MaKhoa,k => k.MaKhoa, (s, k) => new {s.MaSV,s.HoTen,s.DiemTB,k.TenKhoa})
                .ToList();
            lblTongSV.Text ="Tổng sinh viên:"+ db.SinhViens.Count();
        }

        private void loadKhoa()
        {
            
            cbKhoa.DataSource = db.Khoas.ToList();
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.DisplayMember = "TenKhoa";
        }

        private void bthThem_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Add";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Edit";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double diembt;
                if(mtxtMaSV.Text.Length!=10)
                {
                    throw new Exception("Mã SV khong hop le");
                }
                if (txtHoTen.Text.Length <2)
                {
                    throw new Exception("Họ tên khong hop le");
                }
                if(!double.TryParse(txtDiemTB.Text.Trim(), out diembt))
                {
                    throw new Exception("Diểm khong hop le");
                }    
                //Lấy thông
                string masv = mtxtMaSV.Text.Trim();
                string hoten = txtHoTen.Text.Trim();
                double diemtb = Convert.ToDouble( txtDiemTB.Text.Trim());
                int makhoa = Convert.ToInt16(cbKhoa.SelectedValue);
                //Thêm vao DL
                if(AddOrEdit=="Add")
                {
                    SinhVien sv = new SinhVien();
                    sv.MaSV = masv;
                    sv.HoTen = hoten;
                    sv.DiemTB = diembt;
                    sv.MaKhoa = makhoa;
                    db.SinhViens.Add(sv);
                    db.SaveChanges();
                    loadSinhVien();
                    MessageBox.Show("Thêm Thành công");
                }
                if(AddOrEdit=="Edit")
                {
                    SinhVien sv = db.SinhViens.Find(masv);
                    sv.HoTen = hoten;
                    sv.DiemTB = diembt;
                    sv.MaKhoa = makhoa;
                    db.Entry(sv).State =EntityState.Modified;
                    db.SaveChanges();
                    loadSinhVien();
                    MessageBox.Show("Cập nhật Thành công");
                }
                
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

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
            {
                int index = e.RowIndex;
                mtxtMaSV.Text = dgvSinhVien.Rows[index].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvSinhVien.Rows[index].Cells["HoTen"].Value.ToString();
                txtDiemTB.Text = dgvSinhVien.Rows[index].Cells["DiemTB"].Value.ToString();
                cbKhoa.Text = dgvSinhVien.Rows[index].Cells["TenKhoa"].Value.ToString();
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
