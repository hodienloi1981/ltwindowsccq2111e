using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienEF.EF
{
    [Table("SinhViens")]
    internal class SinhVien
    {
        [Key]
        public string MaSV { get; set; }
        
        [Required]
        public string HoTen { get; set; }
        
        public double DiemTB { get; set; }
        public int MaKhoa { get; set; }

        public Khoa Khoas { get; set; }
    }
}
