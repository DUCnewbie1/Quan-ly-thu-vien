using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChiTietPhieuMuon> ChiTietPhieuMuon { get; set; }
        public virtual DbSet<DocGia> DocGia { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBan { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuon { get; set; }
        public virtual DbSet<PhieuPhat> PhieuPhat { get; set; }
        public virtual DbSet<PhieuTra> PhieuTra { get; set; }
        public virtual DbSet<Sach> Sach { get; set; }
        public virtual DbSet<TacGia> TacGia { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<TheDocGia> TheDocGia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuMuon>()
                .Property(e => e.MaPM)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietPhieuMuon>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<DocGia>()
                .Property(e => e.MaDocGia)
                .IsFixedLength();

            modelBuilder.Entity<DocGia>()
                .Property(e => e.Sdt)
                .IsFixedLength();

            modelBuilder.Entity<DocGia>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<DocGia>()
                .HasMany(e => e.TheDocGia)
                .WithRequired(e => e.DocGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Sdt)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuMuon)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuTra)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaXuatBan>()
                .Property(e => e.MaNXB)
                .IsFixedLength();

            modelBuilder.Entity<NhaXuatBan>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<NhaXuatBan>()
                .Property(e => e.Sdt)
                .IsFixedLength();

            modelBuilder.Entity<NhaXuatBan>()
                .HasMany(e => e.Sach)
                .WithRequired(e => e.NhaXuatBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.MaPM)
                .IsFixedLength();

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.MaThe)
                .IsFixedLength();

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<PhieuMuon>()
                .HasMany(e => e.ChiTietPhieuMuon)
                .WithRequired(e => e.PhieuMuon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuMuon>()
                .HasMany(e => e.PhieuPhat)
                .WithMany(e => e.PhieuMuon)
                .Map(m => m.ToTable("ChiTietPhieuPhat").MapLeftKey("MaPM").MapRightKey("MaPhat"));

            modelBuilder.Entity<PhieuMuon>()
                .HasMany(e => e.PhieuTra)
                .WithMany(e => e.PhieuMuon)
                .Map(m => m.ToTable("ChiTietPhieuTra").MapLeftKey("MaPM").MapRightKey("MaPT"));

            modelBuilder.Entity<PhieuPhat>()
                .Property(e => e.MaPhat)
                .IsFixedLength();

            modelBuilder.Entity<PhieuTra>()
                .Property(e => e.MaPT)
                .IsFixedLength();

            modelBuilder.Entity<PhieuTra>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaNXB)
                .IsFixedLength();

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaTacGia)
                .IsFixedLength();

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.ChiTietPhieuMuon)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.MaTacGia)
                .IsFixedLength();

            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.Sach)
                .WithRequired(e => e.TacGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.LoaiTK)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<TheDocGia>()
                .Property(e => e.MaThe)
                .IsFixedLength();

            modelBuilder.Entity<TheDocGia>()
                .Property(e => e.MaDocGia)
                .IsFixedLength();

            modelBuilder.Entity<TheDocGia>()
                .HasMany(e => e.PhieuMuon)
                .WithRequired(e => e.TheDocGia)
                .WillCascadeOnDelete(false);
        }
    }
}
