using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Assignment.Models
{
    public partial class QLCuaHangContext : DbContext
    {
        //public QLCuaHangContext()
        //{
        //}

        public QLCuaHangContext(DbContextOptions<QLCuaHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chitietgiohang> Chitietgiohang { get; set; }
        public virtual DbSet<Giohang> Giohang { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Loai> Loai { get; set; }
        public virtual DbSet<Quanly> Quanly { get; set; }
        public virtual DbSet<Sanpham> Sanpham { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-ROIV26B;Database=QLCuaHang;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Chitietgiohang>(entity =>
            {
                entity.HasKey(e => e.MaDetail)
                    .HasName("PK__CHITIETG__42B481D8A04A4DDB");

                entity.ToTable("CHITIETGIOHANG");

                entity.Property(e => e.MaDetail).HasColumnName("maDetail");

                entity.Property(e => e.IdSp).HasColumnName("IdSP");

                entity.Property(e => e.MaCart).HasColumnName("maCart");

                entity.Property(e => e.SoLuong).HasColumnName("soLuong");

                entity.Property(e => e.TongTien)
                    .HasColumnName("tongTien")
                    .HasColumnType("money")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.MaCartNavigation)
                    .WithMany(p => p.Chitietgiohang)
                    .HasForeignKey(d => d.MaCart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_detail_cart");
            });

            modelBuilder.Entity<Giohang>(entity =>
            {
                entity.HasKey(e => e.MaCart)
                    .HasName("PK__GIOHANG__3A06ACA753A22E68");

                entity.ToTable("GIOHANG");

                entity.Property(e => e.MaCart).HasColumnName("maCart");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasColumnName("diaChi")
                    .HasMaxLength(100);

                entity.Property(e => e.NgayTao)
                    .HasColumnName("ngayTao")
                    .HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasColumnName("sdt")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasColumnName("tenKH")
                    .HasMaxLength(100);

                entity.Property(e => e.TongTien)
                    .HasColumnName("tongTien")
                    .HasColumnType("money")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.ToTable("KHACHHANG");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NgayDk)
                    .HasColumnName("NgayDK")
                    .HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasColumnName("SDT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasColumnName("TenKH")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Loai>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LOAI__E5A6B228A91E5789");

                entity.ToTable("LOAI");

                entity.Property(e => e.MaLoai)
                    .HasColumnName("maLoai")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasColumnName("tenLoai")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Quanly>(entity =>
            {
                entity.ToTable("QUANLY");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HoTen)
                    .HasColumnName("hoTen")
                    .HasMaxLength(100);

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SANPHAM__7A227A7AC9B4F10D");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.MaSp)
                    .HasColumnName("maSP")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Gia)
                    .HasColumnName("gia")
                    .HasColumnType("money");

                entity.Property(e => e.GiamGia).HasColumnName("giamGia");

                entity.Property(e => e.Hinh)
                    .IsRequired()
                    .HasColumnName("hinh")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MaLoai)
                    .IsRequired()
                    .HasColumnName("maLoai")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayNhap)
                    .HasColumnName("ngayNhap")
                    .HasColumnType("date");

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasColumnName("tenSP")
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.Sanpham)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_cate");
            });
        }
    }
}
