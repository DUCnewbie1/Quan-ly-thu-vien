namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuPhat")]
    public partial class PhieuPhat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuPhat()
        {
            PhieuMuon = new HashSet<PhieuMuon>();
        }

        [Key]
        [StringLength(10)]
        public string MaPhat { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayPhat { get; set; }

        [Required]
        [StringLength(250)]
        public string NoiDungPhat { get; set; }

        public double PhiPhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuon { get; set; }
    }
}
