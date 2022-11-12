namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        public int id { get; set; }

        [StringLength(15)]
        public string ma_khach_hang { get; set; }

        public int? so_phut_con_lai { get; set; }
    }
}
