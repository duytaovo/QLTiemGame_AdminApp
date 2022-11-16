using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DB_layer;

namespace QuanLyCafe.Logic_Layer
{
    class LogicHoaDon
    {
        DBMain db = null;

        public LogicHoaDon()
        {
            db = new DBMain();
        }
        public DataTable XemDanhSachHoaDon()
        {
            return db.ExcuteQueryDataSet("select * from XemDanhSachHoaDon", CommandType.Text);
        }

        public DataTable XemChiTietHoaDon(string ma_hoa_don)
        {
            //return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinUuDai('" + ma_uu_dai + "')", CommandType.Text);
            return db.ExcuteQueryDataSet("SELECT * FROM XemChiTietHoaDon('" + ma_hoa_don + "')", CommandType.Text);
        }

        public bool ThemHoaDon(int id_may, string ten_thu_ngan, DateTime ngay_thu, int tong_tien_thu, ref string err)
        {
            string sqlString = null;

            sqlString = "EXEC proc_ThemHoaDon'" + id_may + "','" + ten_thu_ngan + "," + ngay_thu + "," + tong_tien_thu + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
