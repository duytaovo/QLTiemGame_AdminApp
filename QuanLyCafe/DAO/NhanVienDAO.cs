using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCafe.DAO
{

    public class NhanVienDAO
    {
        DataProvider db = null;
       

        public NhanVienDAO()
        {
            db = new DataProvider();
        }

        public bool Login (ref string err, string ten_dang_nhap, string mat_khau)
        {
            return db.MyExecuteNonQuery("proc_Login", CommandType.StoredProcedure, ref err,
               new SqlParameter("@ten_dang_nhap", ten_dang_nhap),
               new SqlParameter("@mat_khau", mat_khau)
               );
        }

       
        public DataTable layNVFromProc()
        {
            return db.ExecuteQuery("proc_XemDanhSachNhanVien", CommandType.StoredProcedure);
        }

        public DataSet NhanVientheoMaNV(string ma_nhan_vien)
        {
            string query = string.Format("SELECT * FROM XemThongTinNhanVien('{0}');", ma_nhan_vien);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public bool ThemNhanVien(ref string err, string ten_dang_nhap, string mat_khau, string ho_ten,  string gioi_tinh, string so_dien_thoai, string dia_chi, string vai_tro, string luong_thang)
        {
            return db.MyExecuteNonQuery("proc_ThemNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ten_dang_nhap", ten_dang_nhap),
                new SqlParameter("@mat_khau", mat_khau),
                new SqlParameter("@ho_ten", ho_ten),
          /*      new SqlParameter("@ngay_sinh", ngay_sinh),*/
                new SqlParameter("@gioi_tinh", gioi_tinh),
                new SqlParameter("@so_dien_thoai", so_dien_thoai),
                new SqlParameter("@dia_chi", dia_chi),
                new SqlParameter("@vai_tro", vai_tro),
                new SqlParameter("@luong_thang", luong_thang)
                );
        }


          public bool CapNhapNhanVien(ref string err, string ten_dang_nhap, string mat_khau, string ho_ten, DateTime ngay_sinh, string gioi_tinh, string so_dien_thoai, string dia_chi, string vai_tro, string luong_thang)
          {
              return db.MyExecuteNonQuery("proc_SuaNhanVien", CommandType.StoredProcedure, ref err,
                  new SqlParameter("@ten_dang_nhap", ten_dang_nhap),
                new SqlParameter("@mat_khau", mat_khau),
                new SqlParameter("@ho_ten", ho_ten),
                new SqlParameter("@ngay_sinh", ngay_sinh),
                new SqlParameter("@gioi_tinh", gioi_tinh),
                new SqlParameter("@so_dien_thoai", so_dien_thoai),
                new SqlParameter("@dia_chi", dia_chi),
                new SqlParameter("@vai_tro", vai_tro),
                new SqlParameter("@luong_thang", luong_thang)
                  );
          }
          public bool XoaNhanVien(ref string err, string Ma_NV)
          {
              return db.MyExecuteNonQuery("proc_XoaNhanVien", CommandType.StoredProcedure, ref err, new SqlParameter("@ma_nhan_vien", Ma_NV));
          }
  
    } 
}
