using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Loai
    {
        public Loai()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
