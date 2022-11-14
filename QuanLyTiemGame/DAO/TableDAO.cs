using QuanLyTiemGame.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemGame.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 100;
        public static int TableHeight = 100;


        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> listTable = new List<Table>();

            DataTable data = DataProvider.Instance.ExcuteQueryDataTable("Select * from XemDanhSachMay;", CommandType.Text); ;

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }

            return listTable;
        }
      
        public Table LoadTableLis1(string ma_may)
        {
            Table listTable = new Table();
            string query = string.Format("SELECT * FROM XemThongTinMay('{0}');", ma_may);
            DataTable data = DataProvider.Instance.ExcuteQueryDataTable(query, CommandType.Text); 

           foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable = table;
            }

            return listTable;
        }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idtable1 , @idtable2", new object[] { id1, id2 });
        }

        public bool InsertTable(string name, string status)
        {
            string query = string.Format("Insert TableFood (name, status) Values (N'{0}', N'{1}')", name, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTable(int id, string name)
        {
            string query = string.Format("Update TableFood set Name = N'{0}' where id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Deletetable(int idFood)
        {
            string query = string.Format("Delete TableFood where id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }   
}
