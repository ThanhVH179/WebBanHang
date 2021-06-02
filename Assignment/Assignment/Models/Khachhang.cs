using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Khachhang
    {
        public int Id { get; set; }
        public string TenKh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgayDk { get; set; }
    }
}
