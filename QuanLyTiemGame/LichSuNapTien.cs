namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuNapTien")]
    public partial class LichSuNapTien
    {
        public int id { get; set; }

        [StringLength(15)]
        public string ma_khach_hang { get; set; }

        public DateTime? ngay_nap { get; set; }

        public int? so_tien_nap { get; set; }
    }
}
