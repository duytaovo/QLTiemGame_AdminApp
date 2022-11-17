using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DB_layer;

namespace QuanLyCafe.Logic_Layer
{
    class LogicChiTietHoaDon
    {
        DBMain db = null;

        public LogicChiTietHoaDon()
        {
            db = new DBMain();
        }


        public DataTable XemChiTietHoaDon(string MaHoaDon = "")
        {
            return db.ExcuteQueryDataSet("select * from XemChiTietHoaDon (" + MaHoaDon + ")", CommandType.Text);
        }

        public string XemChiTietHoaDon1(string MaHoaDon = "")
        {
            return "select * from XemChiTietHoaDon (" + MaHoaDon + ")".ToString();
        }

    }
}
