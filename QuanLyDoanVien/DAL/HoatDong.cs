namespace QuanLyDoanVien.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoatDong")]
    public partial class HoatDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoatDong()
        {
            DiemDanh = new HashSet<DiemDanh>();
            XepLoai = new HashSet<XepLoai>();
        }

        [Key]
        [StringLength(10)]
        public string MaHoatDong { get; set; }

        [StringLength(100)]
        public string TenHoatDong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianToChuc { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemDanh> DiemDanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XepLoai> XepLoai { get; set; }
    }
}
