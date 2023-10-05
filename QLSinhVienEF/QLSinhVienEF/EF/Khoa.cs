using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienEF.EF
{
    [Table("Khoas")]
    internal class Khoa
    {
        [Key]
        public int MaKhoa { get; set; }
        [Required]
        public string TenKhoa { get; set; }
        public string GhiChu { get; set; }

        public ICollection<SinhVien> Sinhviens { get; set; }
    }
}
