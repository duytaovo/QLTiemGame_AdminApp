using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DB_layer;

namespace QuanLyCafe.Logic_Layer
{
    class LogicNhanVien
    {
        DBMain db = null;

        public LogicNhanVien()
        {
            db = new DBMain();
        }


        public DataTable XemDanhSachNhanVien()
        {
            return db.ExcuteQueryDataSet("select * from XemDanhSachNhanVien", CommandType.Text);
        }

        public bool ThemNhanVien(string ten_dang_nhap, string mat_khau, string ho_ten, string ngay_sinh, string gioi_tinh, string so_dien_thoai, string dia_chi, string vai_tro, ref string err)
        {
            string sqlString = null;

            sqlString = "execute proc_ThemNhanVien '" + ten_dang_nhap + "', '" + mat_khau+ "', '" + ho_ten+ "', '" + ngay_sinh+ "', '" + gioi_tinh + "', '" + so_dien_thoai + "', '" +dia_chi + "', '" +vai_tro +  "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool SuaNhanVien(string ten_dang_nhap, string mat_khau, string ho_ten, string ngay_sinh, string gioi_tinh, string so_dien_thoai, string dia_chi, string vai_tro, ref string err)
        {
            string sqlString = null;

            sqlString = "EXEC proc_SuaNhanVien '" + ten_dang_nhap + "', '" + mat_khau + "', '" + ho_ten + "', '" + ngay_sinh + "', '" + gioi_tinh + "', '" + so_dien_thoai + "', '" + dia_chi + "', '" + vai_tro + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        public bool XoaNhanVien(string ten_dang_nhap, ref string err)
        {
            string sqlString = null;

            sqlString = "EXEC proc_XoaNhanVien '" + ten_dang_nhap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
         
        public DataTable XemThongTinNhanVien(string ma_nhan_vien ="", string ho_ten = "", string gioi_tinh ="", string ngay_sinh ="", string dia_chi ="", string vai_tro ="", string status= "2", string ten_dang_nhap ="", string ngay_tao ="")
        {
            //return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinUuDai('" + ma_uu_dai + "')", CommandType.Text);
            return db.ExcuteQueryDataSet("SELECT * FROM XemThongTinNhanVien( '" + ma_nhan_vien + "','" + ho_ten + "','" + gioi_tinh+ "','" + ngay_sinh + "','" + dia_chi + "','" + vai_tro + "'," + status + ",'" + ten_dang_nhap + "','" +ngay_tao + "')", CommandType.Text);
        }
    }
}
