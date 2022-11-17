using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DB_layer;

namespace QuanLyCafe.Logic_Layer
{
    class LogicMay
    {
        DBMain db = null;

        public LogicMay()
        {
            db = new DBMain();
        }


        public DataTable XemDanhSachMay()
        {
            return db.ExcuteQueryDataSet("select * from XemDanhSachMay", CommandType.Text);
        }

        public bool ThemMay(string loai_may, ref string err)
        {
            string sqlString = null;

            sqlString = "EXEC proc_ThemMay '" + loai_may + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool SuaThongtinMay(string ma_may, string loai_may, int gia_tien, ref string err)
        {
            string sqlString = null;

            sqlString = "EXEC proc_SuaThongtinMay '" + ma_may + "','" + loai_may + "'," + gia_tien+ "";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        public bool XoaMay(string ma_may, ref string err)
        {
            string sqlString = null;

            sqlString = "EXEC proc_XoaMay '" + ma_may + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable XemThongTinMay(string ma_may ="", string loai_may="", string gia = "0", string trang_thai= "")
        {
            //return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinUuDai('" + ma_uu_dai + "')", CommandType.Text);
            return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinMay( '" + ma_may + "','" + loai_may + "'," + gia + ",'" + trang_thai + "')", CommandType.Text);
        }
    }
}
