namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuMuon")]
    public partial class PhieuMuon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuMuon()
        {
            ChiTietPhieuMuon = new HashSet<ChiTietPhieuMuon>();
            PhieuPhat = new HashSet<PhieuPhat>();
            PhieuTra = new HashSet<PhieuTra>();
        }

        [Key]
        [StringLength(10)]
        public string MaPM { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTra { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        public int SoLuong { get; set; }

        [Required]
        [StringLength(10)]
        public string MaThe { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuon { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual TheDocGia TheDocGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuPhat> PhieuPhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTra> PhieuTra { get; set; }
    }
}
