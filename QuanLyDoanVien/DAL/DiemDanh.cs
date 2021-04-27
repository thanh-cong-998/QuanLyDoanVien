namespace QuanLyDoanVien.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemDanh")]
    public partial class DiemDanh
    {
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(10)]
        public string MaDoanVien { get; set; }

        [StringLength(10)]
        public string MaHoatDong { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public virtual DoanVien DoanVien { get; set; }

        public virtual HoatDong HoatDong { get; set; }
    }
}
