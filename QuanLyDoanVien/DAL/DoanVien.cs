namespace QuanLyDoanVien.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanVien")]
    public partial class DoanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoanVien()
        {
            DiemDanh = new HashSet<DiemDanh>();
            KhenThuong = new HashSet<KhenThuong>();
            XepLoai = new HashSet<XepLoai>();
        }

        [Key]
        [StringLength(10)]
        public string MaDoanVien { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDoanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [StringLength(100)]
        public string QueQuan { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayVaoDoan { get; set; }

        [StringLength(10)]
        public string MaChiDoan { get; set; }

        public virtual ChiDoan ChiDoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemDanh> DiemDanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhenThuong> KhenThuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XepLoai> XepLoai { get; set; }
    }
}
