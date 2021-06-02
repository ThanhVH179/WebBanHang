using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Chitietgiohang
    {
        public int MaDetail { get; set; }
        public int MaCart { get; set; }
        public int IdSp { get; set; }
        public int SoLuong { get; set; }
        public decimal? TongTien { get; set; }

        public virtual Giohang MaCartNavigation { get; set; }
    }
}
