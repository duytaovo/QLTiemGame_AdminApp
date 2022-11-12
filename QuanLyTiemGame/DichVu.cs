namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        public int id { get; set; }

        [StringLength(15)]
        public string ma_dich_vu { get; set; }

        [StringLength(50)]
        public string loai_dich_vu { get; set; }

        [StringLength(50)]
        public string ten_mon { get; set; }

        public int? gia { get; set; }

        public int? so_luong { get; set; }
    }
}
