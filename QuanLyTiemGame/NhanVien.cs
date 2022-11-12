namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        public int id { get; set; }

        [StringLength(15)]
        public string ma_nhan_vien { get; set; }

        [StringLength(50)]
        public string ho_ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_sinh { get; set; }

        [StringLength(10)]
        public string gioi_tinh { get; set; }

        [StringLength(15)]
        public string so_dien_thoai { get; set; }

        [StringLength(100)]
        public string dia_chi { get; set; }

        [StringLength(20)]
        public string vai_tro { get; set; }

        public int? luong_thang { get; set; }
    }
}
