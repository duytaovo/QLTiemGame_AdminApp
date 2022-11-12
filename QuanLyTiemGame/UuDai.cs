namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UuDai")]
    public partial class UuDai
    {
        public int id { get; set; }

        [StringLength(15)]
        public string ma_uu_dai { get; set; }

        public int? giam_gia { get; set; }

        [StringLength(50)]
        public string qua_tang { get; set; }
    }
}
