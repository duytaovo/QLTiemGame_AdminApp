namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang_May
    {
        public int id { get; set; }

        [StringLength(15)]
        public string ma_may { get; set; }

        [StringLength(15)]
        public string ma_khach_hang { get; set; }

        public DateTime? thoi_gian_mo_may { get; set; }
    }
}
