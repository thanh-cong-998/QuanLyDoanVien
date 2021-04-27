using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyDoanVien.DAL
{
    public partial class QuanLyDoanVienDbContext : DbContext
    {
        public QuanLyDoanVienDbContext()
            : base("name=QuanLyDoanVienDbContext")
        {
        }

        public virtual DbSet<ChiDoan> ChiDoan { get; set; }
        public virtual DbSet<DiemDanh> DiemDanh { get; set; }
        public virtual DbSet<DoanVien> DoanVien { get; set; }
        public virtual DbSet<HoatDong> HoatDong { get; set; }
        public virtual DbSet<KhenThuong> KhenThuong { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<XepLoai> XepLoai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiDoan>()
                .Property(e => e.MaChiDoan)
                .IsUnicode(false);

            modelBuilder.Entity<DiemDanh>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<DiemDanh>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);

            modelBuilder.Entity<DiemDanh>()
                .Property(e => e.MaHoatDong)
                .IsUnicode(false);

            modelBuilder.Entity<DoanVien>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);

            modelBuilder.Entity<DoanVien>()
                .Property(e => e.MaChiDoan)
                .IsUnicode(false);

            modelBuilder.Entity<HoatDong>()
                .Property(e => e.MaHoatDong)
                .IsUnicode(false);

            modelBuilder.Entity<KhenThuong>()
                .Property(e => e.MaKhenThuong)
                .IsUnicode(false);

            modelBuilder.Entity<KhenThuong>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<XepLoai>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<XepLoai>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);

            modelBuilder.Entity<XepLoai>()
                .Property(e => e.MaHoatDong)
                .IsUnicode(false);
        }
    }
}
