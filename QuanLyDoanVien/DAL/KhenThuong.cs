namespace QuanLyDoanVien.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhenThuong")]
    public partial class KhenThuong
    {
        [Key]
        [StringLength(10)]
        public string MaKhenThuong { get; set; }

        [StringLength(10)]
        public string MaDoanVien { get; set; }

        [StringLength(50)]
        public string TenKhenThuong { get; set; }

        [StringLength(100)]
        public string ThanhTich { get; set; }

        public int? NamHoc { get; set; }

        public virtual DoanVien DoanVien { get; set; }
    }
}
