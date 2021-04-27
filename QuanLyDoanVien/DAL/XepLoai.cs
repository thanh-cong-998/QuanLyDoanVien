namespace QuanLyDoanVien.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XepLoai")]
    public partial class XepLoai
    {
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(10)]
        public string MaDoanVien { get; set; }

        [StringLength(10)]
        public string MaHoatDong { get; set; }

        public int? NamHoc { get; set; }

        [StringLength(1000)]
        public string NhanXet { get; set; }

        [StringLength(10)]
        public string XepLoaiDoanVien { get; set; }

        public virtual DoanVien DoanVien { get; set; }

        public virtual HoatDong HoatDong { get; set; }
    }
}
