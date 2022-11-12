namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThucDon")]
    public partial class ThucDon
    {
        public int id { get; set; }

        [StringLength(15)]
        public string ma_thuc_don { get; set; }

        [StringLength(50)]
        public string ten_mon { get; set; }

        public int? gia { get; set; }

        public int? so_luong { get; set; }
    }
}
