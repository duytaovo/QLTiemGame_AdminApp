namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        public int id { get; set; }

        [StringLength(15)]
        public string ma_tai_khoan { get; set; }

        [StringLength(20)]
        public string ten_dang_nhap { get; set; }

        [StringLength(20)]
        public string mat_khau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_tao_tai_khoan { get; set; }

        public int? STATUS { get; set; }
    }
}
