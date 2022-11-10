﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1.DAL.DomainClass;

#nullable disable

namespace _1.DAL.Context
{
    public partial class FpolyDBContext : DbContext
    {
        public FpolyDBContext()
        {
        }

        public FpolyDBContext(DbContextOptions<FpolyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
        public virtual DbSet<ChiTietSach> ChiTietSaches { get; set; }
        public virtual DbSet<ChiTietTheLoai> ChiTietTheLoais { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CongThucTinhDiem> CongThucTinhDiems { get; set; }
        public virtual DbSet<DiemTieuDung> DiemTieuDungs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LichSuDiemDung> LichSuDiemDungs { get; set; }
        public virtual DbSet<LichSuDiemTich> LichSuDiemTiches { get; set; }
        public virtual DbSet<LoaiBium> LoaiBia { get; set; }
        public virtual DbSet<NhaPhatHanh> NhaPhatHanhs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Nxb> Nxbs { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<TacGium> TacGia { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=IAMTHAIS\\SQLEXPRESS01;Initial Catalog=DuAn1_Nhom888_FPLHN;Persist Security Info=True;User ID=thaitdph26029;Password=tranduythai2003");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChiTietKhuyenMai>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSachNavigation)
                    .WithMany(p => p.ChiTietKhuyenMais)
                    .HasForeignKey(d => d.IdChiTietSach)
                    .HasConstraintName("FK__ChiTietKh__IdChi__43D61337");

                entity.HasOne(d => d.IdKhuyenMaiNavigation)
                    .WithMany(p => p.ChiTietKhuyenMais)
                    .HasForeignKey(d => d.IdKhuyenMai)
                    .HasConstraintName("FK__ChiTietKh__IdKhu__47A6A41B");
            });

            modelBuilder.Entity<ChiTietSach>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Anh).IsUnicode(false);

                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");

                entity.Property(e => e.KichThuoc).IsUnicode(false);

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MaVach).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdLoaiBiaNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.IdLoaiBia)
                    .HasConstraintName("FK__ChiTietSa__IdLoa__45BE5BA9");

                entity.HasOne(d => d.IdNhaPhatHanhNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.IdNhaPhatHanh)
                    .HasConstraintName("FK__ChiTietSa__IdNha__44CA3770");

                entity.HasOne(d => d.IdNxbNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.IdNxb)
                    .HasConstraintName("FK__ChiTietSa__IdNXB__40F9A68C");

                entity.HasOne(d => d.IdSachNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.IdSach)
                    .HasConstraintName("FK__ChiTietSa__IdSac__40058253");

                entity.HasOne(d => d.IdTacGiaNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.IdTacGia)
                    .HasConstraintName("FK__ChiTietSa__IdTac__41EDCAC5");
            });

            modelBuilder.Entity<ChiTietTheLoai>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSachNavigation)
                    .WithMany(p => p.ChiTietTheLoais)
                    .HasForeignKey(d => d.IdChiTietSach)
                    .HasConstraintName("FK__ChiTietTh__IdChi__42E1EEFE");

                entity.HasOne(d => d.IdTheLoaiNavigation)
                    .WithMany(p => p.ChiTietTheLoais)
                    .HasForeignKey(d => d.IdTheLoai)
                    .HasConstraintName("FK__ChiTietTh__IdThe__46B27FE2");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CongThucTinhDiem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DiemTieuDung>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.SoDiem).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MaHd).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IddiemDungNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IddiemDung)
                    .HasConstraintName("FK__HoaDon__IDDiemDu__4D5F7D71");

                entity.HasOne(d => d.IddiemTichNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IddiemTich)
                    .HasConstraintName("FK__HoaDon__IDDiemTi__4C6B5938");

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.Idkh)
                    .HasConstraintName("FK__HoaDon__IDKH__4E53A1AA");

                entity.HasOne(d => d.IdnvNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.Idnv)
                    .HasConstraintName("FK__HoaDon__IDNV__4F47C5E3");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSachNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdChiTietSach)
                    .HasConstraintName("FK__HoaDonChi__IdChi__51300E55");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoaDon)
                    .HasConstraintName("FK__HoaDonChi__IdHoa__5224328E");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LichSuDiemDung>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdCttinhNavigation)
                    .WithMany(p => p.LichSuDiemDungs)
                    .HasForeignKey(d => d.IdCttinh)
                    .HasConstraintName("FK__LichSuDie__IdCTT__4B7734FF");

                entity.HasOne(d => d.IddiemTieuDungNavigation)
                    .WithMany(p => p.LichSuDiemDungs)
                    .HasForeignKey(d => d.IddiemTieuDung)
                    .HasConstraintName("FK__LichSuDie__IDDie__4A8310C6");
            });

            modelBuilder.Entity<LichSuDiemTich>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdCttinhNavigation)
                    .WithMany(p => p.LichSuDiemTiches)
                    .HasForeignKey(d => d.IdCttinh)
                    .HasConstraintName("FK__LichSuDie__IdCTT__498EEC8D");

                entity.HasOne(d => d.IddiemTieuDungNavigation)
                    .WithMany(p => p.LichSuDiemTiches)
                    .HasForeignKey(d => d.IddiemTieuDung)
                    .HasConstraintName("FK__LichSuDie__IDDie__489AC854");
            });

            modelBuilder.Entity<LoaiBium>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NhaPhatHanh>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.GioiTinh).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdchucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdchucVu)
                    .HasConstraintName("FK__NhanVien__IDChuc__503BEA1C");
            });

            modelBuilder.Entity<Nxb>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TacGium>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
