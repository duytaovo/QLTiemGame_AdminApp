using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTiemGame.DAO
{
    public class MayDAO
    {
        DataProvider db = null;
    public MayDAO()
    {
        db = new DataProvider();
    }

    public DataTable LayMay()
        {
            return db.ExcuteQueryDataTable("Select * from XemDanhSachMay;", CommandType.Text);
        }

        public DataSet MayTheoMaMay(string ma_may)
        {
            string query = string.Format("SELECT * FROM XemThongTinMay('{0}');", ma_may);
            return db.ExcuteQuerryDataSet(query, CommandType.Text,null);
        }

        public object LayTienMay(string ma_may)
        {
            string query = string.Format("SELECT dbo.TinhTienMay('{0}');", ma_may);
            return db.ExecuteScalar(query, null);
        }

        public object LayTienDichVu(string ma_may)
        {
            string query = string.Format("SELECT dbo.TinhTienDichVu('{0}');", ma_may);
            return db.ExecuteScalar(query, null);
        }

        public object LayTienTong(string ma_may, string ma_uu_dai)
        {
            string query = string.Format("SELECT dbo.TongTien('{0}', '{1}');", ma_may,ma_uu_dai);
            return db.ExecuteScalar(query, null);
        }

        public object LayTienMaGiamGia(string ma_uu_dai)
        {
            string query = string.Format("SELECT dbo.LayTienMaGiamGia('{0}');", ma_uu_dai);
            return db.ExecuteScalar(query, null);
        }


        public object LayTongTien(string ma_may, string ma_giam_giam)
        {
            string query1 = string.Format("proc_XuatHoaDonChiTiet2 @ma_may , @ma_uu_dai", new object[] { ma_may, ma_giam_giam});
            string query = string.Format("proc_XuatHoaDonChiTiet2", CommandType.StoredProcedure,
                new SqlParameter("@ma_may", ma_may),
              new SqlParameter("@ma_uu_dai", ma_giam_giam));
             return db.ExecuteScalar(query1, null);;
        }

        public bool CapNhapTrangThaiMay(ref string err, string ma_may, string trang_thai)
        {
            return db.MyExecuteNonQuery("proc_SuaTrangThaiMay", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ma_may", ma_may),
              new SqlParameter("@trang_thai", trang_thai));
        }
      /*  public bool MoMay(string ma_may, string trang_thai, ref string err)
        {
            string query = string.Format("Update May Set trang_thai=N'{1}'" ,
                                                                            trang_thai);
            //string sqlString = "Update SinhVien Set maSV=N'" + MaSV + "',maLop=N'" + MaLop + "',email=N'" + Email + "',matKhau=N'" + MatKhau + "',hoTen=N'" + HoTen + "',gioiTinh=N'" + GioiTinh + "',soDT=N'" + SoDT + "',diaChi=N'" + DiaChi + "',status=N'" + "0" + "Where maSV = '" + MaSV + "'";
            string query2 = string.Format("Update May Set trang_thai=N'{1}'" +
                "                                           WHERE ma_may = {0}", ma_may,trang_thai);
            return db.MyExecuteNonQuery(query2, CommandType.Text, ref err);
        }*/
    }
    
   
}
