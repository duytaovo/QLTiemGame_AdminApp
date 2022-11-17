using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DB_layer;

namespace QuanLyCafe.Logic_Layer
{
    class LogicDichVu
    {
        DBMain db = null;

        public LogicDichVu()
        {
            db = new DBMain();
        }
        public DataTable XemDanhSachDichVu()
        {
            return db.ExcuteQueryDataSet("select * from XemDanhSachDichVu", CommandType.Text);
        }

        public DataTable XemThongTinDichVu(string ma_dich_vu = "", string loai_dich_vu = "", string ten_mon = "", string gia = "0", string status = "2")
        {
            //return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinUuDai('" + ma_uu_dai + "')", CommandType.Text);
            return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinDichVu( '" + ma_dich_vu + "','" + loai_dich_vu + "','" + ten_mon + "'," + gia + "," + status + ")", CommandType.Text);
        }

        public string XemThongTinDichVu1(string ma_dich_vu = "", string loai_dich_vu = "", string ten_mon = "", string gia = "0", string status = "2")
        {
            //return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinUuDai('" + ma_uu_dai + "')", CommandType.Text);
            return ("SELECT * FROM XemThongTinDichVu( '" + ma_dich_vu + "','" + loai_dich_vu + "','" + ten_mon + "'," + gia + "," + status + ")").ToString();
        }


        public bool SuaThongTinDichVu(int id, string ma_dich_vu, string loai_dich_vu, string ten_mon, int gia, int so_luong, ref string err)
        {
            string sqlString = null;

            sqlString = "EXEC proc_SuaThongTinDichVu " + id + ",'" + ma_dich_vu+ "','" + loai_dich_vu+ "','" + ten_mon+ "'," + gia + "," + so_luong + "";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool ThemDichVu(string ma_dich_vu, string loai_dich_vu, string ten_mon, int gia,int so_luong, ref string err)
        {
            string sqlString = null;

            sqlString = "EXEC proc_ThemDichVu '"  + ma_dich_vu + "','" + loai_dich_vu + "','" + ten_mon + "'," + gia +"," + so_luong + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaDichVu(int id, ref string err)
        {
            string sqlString = null;

            sqlString = "execute proc_XoaDichVu '" + id +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
