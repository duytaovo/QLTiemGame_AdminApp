using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemGame.DTO
{
    public class Table
    {
        private int iD;
        private string mamay;
        private string status;
        private string loaimay;
        private int giatien;

        public int ID { get => iD; set => iD = value; }
        public string MaMay { get => mamay; set => mamay = value; }
        public string LoaiMay { get => loaimay; set => loaimay = value; }
        public int GiaTien { get => giatien; set => giatien = value; }
        public string Status { get => status; set => status = value; }
        public Table()
        {

        }
        public Table( int id, string ma_may, string loai_may, int gia_tien, string trang_thai)
        {
            this.ID = id;
            this.MaMay = ma_may;
            this.LoaiMay = loai_may;
            this.GiaTien = gia_tien;
            this.Status = trang_thai;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MaMay = row["ma_may"].ToString();
            this.LoaiMay = row["loai_may"].ToString();
            this.GiaTien = (int)row["gia_tien_mot_gio"];
            this.Status = row["trang_thai"].ToString();
        }
     
    }
}
