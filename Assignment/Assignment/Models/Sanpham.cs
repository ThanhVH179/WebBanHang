using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public partial class Sanpham
    {
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public string MaLoai { get; set; }
        public decimal Gia { get; set; }
        public string Hinh { get; set; }
        public int GiamGia { get; set; }
        public DateTime NgayNhap { get; set; }

        public virtual Loai MaLoaiNavigation { get; set; }
        [NotMapped]
        [DisplayName("Chọn hình")]
        public IFormFile ImageFile { get; set; }
    }
}
