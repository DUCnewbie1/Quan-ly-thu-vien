namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuMuon")]
    public partial class ChiTietPhieuMuon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSach { get; set; }

        public bool? TrangThaiSach { get; set; }

        public virtual PhieuMuon PhieuMuon { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
