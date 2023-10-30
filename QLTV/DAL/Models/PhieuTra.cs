namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuTra")]
    public partial class PhieuTra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuTra()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
        }

        [Key]
        [StringLength(10)]
        public string MaPT { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTra { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(100)]
        public string TinhTrangSach { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}
