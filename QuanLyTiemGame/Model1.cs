using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyTiemGame
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<DoanhThu> DoanhThus { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhachHang_May> KhachHang_May { get; set; }
        public virtual DbSet<LichSuNapTien> LichSuNapTiens { get; set; }
        public virtual DbSet<May> Mays { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThucDon> ThucDons { get; set; }
        public virtual DbSet<UuDai> UuDais { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.ma_tai_khoan)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.ma_dich_vu)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.loai_dich_vu)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.ma_khach_hang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_May>()
                .Property(e => e.ma_may)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_May>()
                .Property(e => e.ma_khach_hang)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuNapTien>()
                .Property(e => e.ma_khach_hang)
                .IsUnicode(false);

            modelBuilder.Entity<May>()
                .Property(e => e.ma_may)
                .IsUnicode(false);

            modelBuilder.Entity<May>()
                .Property(e => e.loai_may)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ma_nhan_vien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.so_dien_thoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.ma_tai_khoan)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.ten_dang_nhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.mat_khau)
                .IsUnicode(false);

            modelBuilder.Entity<ThucDon>()
                .Property(e => e.ma_thuc_don)
                .IsUnicode(false);

            modelBuilder.Entity<UuDai>()
                .Property(e => e.ma_uu_dai)
                .IsUnicode(false);

            modelBuilder.Entity<UuDai>()
                .Property(e => e.qua_tang)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.ma_thuc_don)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.ma_uu_dai)
                .IsUnicode(false);
        }
    }
}
