namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            PhieuMuon = new HashSet<PhieuMuon>();
        }

        [Key]
        [StringLength(10)]
        public string MaSach { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSach { get; set; }

        [Required]
        [StringLength(50)]
        public string TheLoai { get; set; }

        public int? NamXB { get; set; }

        public double GiaSach { get; set; }

        public int SoLuong { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNXB { get; set; }

        [Required]
        [StringLength(10)]
        public string MaTacGia { get; set; }

        public virtual NhaXuatBan NhaXuatBan { get; set; }

        public virtual TacGia TacGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuon { get; set; }
    }
}
