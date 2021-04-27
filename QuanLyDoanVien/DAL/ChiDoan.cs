namespace QuanLyDoanVien.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiDoan")]
    public partial class ChiDoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiDoan()
        {
            DoanVien = new HashSet<DoanVien>();
        }

        [Key]
        [StringLength(10)]
        public string MaChiDoan { get; set; }

        [StringLength(50)]
        public string TenChiDoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoanVien> DoanVien { get; set; }
    }
}
