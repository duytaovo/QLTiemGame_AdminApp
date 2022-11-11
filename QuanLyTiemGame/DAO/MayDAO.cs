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
