using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienEF.EF
{
    internal class QLSinhVienDBContext:DbContext
    {
        public QLSinhVienDBContext() : base("name=strKetNoi") { }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
    }
}
