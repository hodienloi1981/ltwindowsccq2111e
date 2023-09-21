using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3.frm
{
    public partial class frmSinhVien : Form
    {
        private string nutnhan = null;
        private int index = -1;
        public frmSinhVien()
        {
            InitializeComponent();
        }
        public void loadKhoa()
        {
            string[] arrKhoa = { "CNTT", "QTKD", "Kế Toán" };
            cbKhoa.DataSource = arrKhoa;
        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            loadKhoa();
            AnHienControl(false);
            btnSua.Enabled = false;
        }
        private void AnHienControl(bool ok=true)
        {
            txtMaSV.Enabled = ok;
            txtHoTen.Enabled = ok;
            cbKhoa.Enabled = ok;
            txtDiem.Enabled = ok;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AnHienControl(true);
            nutnhan = "Add";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int diem;
                if (txtMaSV.Text == "")
                {
                    throw new Exception("Mã sinh viên không được để trống");
                }
                if (txtHoTen.Text == "")
                {
                    throw new Exception("Tên không được để trống");
                }
                if (!int.TryParse(txtDiem.Text, out diem))
                {
                    throw new Exception("Giá trị điểm không hợp lệ");
                }
                string masv = txtMaSV.Text.Trim();
                string hoten = txtHoTen.Text.Trim();
                string khoa = cbKhoa.Text.Trim();
                //Đẩy lên lưới
                bool check = true;
                if (dgvSinhVien.Rows.Count > 1 && nutnhan=="Add")
                {
                    for (int i = 0; i < dgvSinhVien.Rows.Count - 1; i++)
                    {
                        if (dgvSinhVien.Rows[i].Cells["MaSV"].Value.ToString() == txtMaSV.Text.Trim())
                        {
                            check = false;
                            break;
                        }
                    }
                }
                if (check == true)
                {
                    if (nutnhan == "Add")
                    {
                        index = dgvSinhVien.Rows.Add();//0,1,2,3,4,5,6,7
                    }
                    dgvSinhVien.Rows[index].Cells["MaSV"].Value = masv;
                    dgvSinhVien.Rows[index].Cells["HoTen"].Value = hoten;
                    dgvSinhVien.Rows[index].Cells["Khoa"].Value = khoa;
                    dgvSinhVien.Rows[index].Cells["DiemTB"].Value = diem.ToString();
                }
                else
                {
                    throw new Exception("Không thể thêm do tồn tại mã sinh viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nutnhan = "Edit";
            AnHienControl(true);
            txtMaSV.Enabled = false;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.RowIndex < dgvSinhVien.Rows.Count-1)
            {
                txtMaSV.Text = dgvSinhVien.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvSinhVien.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                txtDiem.Text = dgvSinhVien.Rows[e.RowIndex].Cells["DiemTB"].Value.ToString();
                cbKhoa.Text = dgvSinhVien.Rows[e.RowIndex].Cells["Khoa"].Value.ToString();
                btnSua.Enabled = true;
                index = e.RowIndex;
                AnHienControl(false);
            }    
           
        }
    }
}
