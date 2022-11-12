namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        public int id { get; set; }

        [StringLength(15)]
        public string ma_tai_khoan { get; set; }

        [StringLength(50)]
        public string ho_ten { get; set; }
    }
}
