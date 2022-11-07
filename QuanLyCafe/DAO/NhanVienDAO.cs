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
        public DataTable layNVFromProc()
        {
            return db.ExecuteQuery("proc_XemDanhSachNhanVien", CommandType.StoredProcedure);
        }


        public bool ThemNhanVien(ref string err, string Ma_NV, string Ten_NV, string Cmnd, string DienThoai, DateTime Ngay_lamviec, float Luong)
        {
            return db.MyExecuteNonQuery("SpThemNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_NV", Ma_NV),
                new SqlParameter("@Ten_NV", Ten_NV),
                new SqlParameter("@Cmnd", Cmnd),
                new SqlParameter("@DienThoai", DienThoai),
                new SqlParameter("@Ngay_lamviec", Ngay_lamviec),
                new SqlParameter("@Luong", Luong)
                );
        }

        /*  public bool ThemNhanVien(ref string err, string Ma_NV, string Ten_NV, string Cmnd, string DienThoai, DateTime Ngay_lamviec, float Luong)
          {
              return db.MyExecuteNonQuery("SpThemNhanVien", CommandType.StoredProcedure, ref err,
                  new SqlParameter("@Ma_NV", Ma_NV),
                  new SqlParameter("@Ten_NV", Ten_NV),
                  new SqlParameter("@Cmnd", Cmnd),
                  new SqlParameter("@DienThoai", DienThoai),
                  new SqlParameter("@Ngay_lamviec", Ngay_lamviec),
                  new SqlParameter("@Luong", Luong)
                  );
          }
          public bool CapNhapNhanVien(ref string err, string Ma_NV, string Ten_NV, string Cmnd, string DienThoai, DateTime Ngay_lamviec, float Luong)
          {
              return db.MyExecuteNonQuery("SpCapNhatNhanVien", CommandType.StoredProcedure, ref err,
                  new SqlParameter("@Ma_NV", Ma_NV),
                  new SqlParameter("@Ten_NV", Ten_NV),
                  new SqlParameter("@Cmnd", Cmnd),
                  new SqlParameter("@DienThoai", DienThoai),
                  new SqlParameter("@Ngay_lamviec", Ngay_lamviec),
                  new SqlParameter("@Luong", Luong)
                  );
          }
          public bool XoaNhanVien(ref string err, string Ma_NV)
          {
              return db.MyExecuteNonQuery("SpXoaNhanVien", CommandType.StoredProcedure, ref err, new SqlParameter("@Ma_NV", Ma_NV));
          }
  */
    } 
}
