namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanhThu")]
    public partial class DoanhThu
    {
        public int id { get; set; }

        public int? ma_hoa_don { get; set; }

        [StringLength(50)]
        public string ten_thu_ngan { get; set; }

        public DateTime? ngay_thu { get; set; }

        public int? tong_tien_thu { get; set; }
    }
}
