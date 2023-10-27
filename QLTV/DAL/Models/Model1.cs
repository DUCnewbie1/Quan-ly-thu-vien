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
                .HasMany(e => e.TheDocGias)
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
                .HasMany(e => e.PhieuMuons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuTras)
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
                .HasMany(e => e.Saches)
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
                .HasMany(e => e.Saches)
                .WithMany(e => e.PhieuMuons)
                .Map(m => m.ToTable("ChiTietPhieuMuon").MapLeftKey("MaPM").MapRightKey("MaSach"));

            modelBuilder.Entity<PhieuMuon>()
                .HasMany(e => e.PhieuTras)
                .WithMany(e => e.PhieuMuons)
                .Map(m => m.ToTable("ChiTietPhieuTra").MapLeftKey("MaPM").MapRightKey("MaPT"));

            modelBuilder.Entity<PhieuPhat>()
                .Property(e => e.MaPhat)
                .IsFixedLength();

            modelBuilder.Entity<PhieuPhat>()
                .HasMany(e => e.PhieuTras)
                .WithMany(e => e.PhieuPhats)
                .Map(m => m.ToTable("ChiTietPhieuPhat").MapLeftKey("MaPhat").MapRightKey("MaPT"));

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

            modelBuilder.Entity<TacGia>()
                .Property(e => e.MaTacGia)
                .IsFixedLength();

            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.Saches)
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
                .HasMany(e => e.PhieuMuons)
                .WithRequired(e => e.TheDocGia)
                .WillCascadeOnDelete(false);
        }
    }
}
