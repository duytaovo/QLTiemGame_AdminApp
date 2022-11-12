namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("May")]
    public partial class May
    {
        public int id { get; set; }

        [StringLength(15)]
        public string ma_may { get; set; }

        [StringLength(10)]
        public string loai_may { get; set; }

        public int? gia_tien_mot_gio { get; set; }

        [StringLength(10)]
        public string trang_thai { get; set; }
    }
}
