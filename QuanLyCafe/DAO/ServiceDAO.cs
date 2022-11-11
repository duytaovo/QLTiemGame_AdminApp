using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCafe.DAO
{
    public class ServiceDAO
    {
        DataProvider db = null;
        public ServiceDAO()
        {
            db = new DataProvider();
        }

        public DataTable LayDichVu()
        {
            return db.ExcuteQueryDataTable("Select * from XemDanhSachDichVu;", CommandType.Text);
        }
    }

}
