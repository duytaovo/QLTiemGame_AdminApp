namespace QuanLyTiemGame
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ma_hoa_don { get; set; }

        [StringLength(15)]
        public string ma_thuc_don { get; set; }

        [StringLength(15)]
        public string ma_uu_dai { get; set; }

        public int? so_luong { get; set; }
    }
}
