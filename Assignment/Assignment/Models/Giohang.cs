using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Giohang
    {
        public Giohang()
        {
            Chitietgiohang = new HashSet<Chitietgiohang>();
        }

        public int MaCart { get; set; }
        public string TenKh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public decimal? TongTien { get; set; }
        public DateTime? NgayTao { get; set; }

        public virtual ICollection<Chitietgiohang> Chitietgiohang { get; set; }
    }
}
