using QuanLyCafe.DB_layer;
using System;
using System.Data;

namespace QuanLyCafe.Logic_Layer
{
    class LogicUuDai
    {
        DBMain db = null;

        public LogicUuDai()
        {
            db = new DBMain();
        }


        public DataTable XemDanhSachUuDai()
        {
            return db.ExcuteQueryDataSet("select * from XemDanhSachUuDai", CommandType.Text);
        }

        public bool ThemUuDai(string ma_uu_dai, string giam_gia, string id_dich_vu, string ngay_bat_dau, string ngay_ket_thuc, ref string err)
        {
            string sqlString = null;
            int id_dich_vu_para = 0;
            int giam_gia_para = 0;
            if (String.Compare(giam_gia, "0", true) == 0)
            {
                giam_gia = "null";
                id_dich_vu_para = Convert.ToInt32(id_dich_vu);
                sqlString = "EXEC proc_ThemUuDai '" + ma_uu_dai + "', " + giam_gia + "," + id_dich_vu_para + ", '" + ngay_bat_dau + "', '" + ngay_ket_thuc + "'";
            }
            if (String.Compare(id_dich_vu, "0", true) == 0)
            {
                id_dich_vu = "null";
                giam_gia_para = Convert.ToInt32(giam_gia);
                sqlString = "EXEC proc_ThemUuDai '" + ma_uu_dai + "', " + giam_gia_para + "," + id_dich_vu + ", '" + ngay_bat_dau + "', '" + ngay_ket_thuc + "'";
            }

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool SuaThongTinUuDai(string ma_uu_dai, int giam_gia, int id_dich_vu, string ngay_bat_dau, string ngay_ket_thuc, ref string err)
        {
            string sqlString = null;
            string giam_gia_para = "";
            string id_dich_vu_para = "";
            if (giam_gia == 0)
            {
                giam_gia_para = "null";
            }
            else
            {
                giam_gia_para = giam_gia.ToString();
            }
            if (id_dich_vu == 0)
            {
                id_dich_vu_para = "null";
            }
            else
            {
                id_dich_vu_para = id_dich_vu.ToString();
            }
            sqlString = "EXEC proc_SuaThongTinUuDai '" + ma_uu_dai + "', " + giam_gia_para + ", " + id_dich_vu_para + ", '" + ngay_bat_dau + "', '" + ngay_ket_thuc + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        public bool XoaUuDai(string ma_uu_dai, ref string err)
        {
            string sqlString = null;

            sqlString = "EXEC proc_XoaUuDai '" + ma_uu_dai + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable XemThongTinUuDai(string ma_uu_dai = "", string giam_gia = "0", string id_qua = "0", string start_day = "", string end_day = "", string ngay_cuThe = "", string status = "2")
        {
            //return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinUuDai('" + ma_uu_dai + "')", CommandType.Text);
            return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinUuDai( '" + ma_uu_dai + "'," + giam_gia + "," + id_qua + ",'" + start_day + "','" + end_day + "','" + ngay_cuThe + "'," + status + ")", CommandType.Text);
        }
        public string XemThongTinUuDai1(string ma_uu_dai = "", int giam_gia = 0, int id_qua = 0, string start_day = "", string end_day = "", string ngay_cuThe = "", string status = "2")
        {
            //return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinUuDai('" + ma_uu_dai + "')", CommandType.Text);
            return ("SELECT * FROM XemThongTinUuDai( '" + ma_uu_dai + "'," + giam_gia + "," + id_qua + ",'" + start_day + "','" + end_day + "','" + ngay_cuThe + "'," + status + ")").ToString();
        }
    }
}
