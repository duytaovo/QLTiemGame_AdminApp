using System;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyTiemGame.DAO
{
    public class MemberDAO
    {

        DataProvider db = null;
        public MemberDAO()
        {
            db = new DataProvider();
        }
        public DataTable LayKhachHang()
        {
            return db.ExcuteQueryDataTable("Select * from XemDanhSachKhachHang;", CommandType.Text);
        }
        public DataTable LayMay()
        {
            return db.ExcuteQueryDataTable("Select * from XemDanhSachMay;", CommandType.Text);
        }

        public DataSet ThongTinKhachHangTheoTenDangNhap(string ten_dang_nhap)
        {
            string query = string.Format("SELECT * FROM XemThongTinKhachHang('{0}');", ten_dang_nhap);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }

        public bool CapNhapTienKhachHang(ref string err, string ten_dang_nhap, int so_tien_nap)
        {
            return db.MyExecuteNonQuery("proc_NapTienKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ten_dang_nhap", ten_dang_nhap),
              new SqlParameter("@so_tien_nap", so_tien_nap));
        }


        public bool ThemKhachHang(ref string err, string ten_dang_nhap, string mat_khau)
        {
            return db.MyExecuteNonQuery("proc_ThemKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ten_dang_nhap", ten_dang_nhap),
                new SqlParameter("@mat_khau", mat_khau)
                );
        }


        public bool CapNhapKhachHang(ref string err, string ten_dang_nhap, string mat_khau)
        {
            return db.MyExecuteNonQuery("proc_ThayDoiMatKhauKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ten_dang_nhap", ten_dang_nhap),
              new SqlParameter("@mat_khau", mat_khau)
                );
        }
        public bool XoaKhachHang(ref string err, string ten_dang_nhap)
        {
            return db.MyExecuteNonQuery("proc_XoaKhachHang", CommandType.StoredProcedure, ref err, new SqlParameter("@ten_dang_nhap", ten_dang_nhap));
        }
    }
}
