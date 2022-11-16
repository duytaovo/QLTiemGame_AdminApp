using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DB_layer
{
    internal class DBMain
    {
        string strConnectionString = @"Data Source=.;Initial Catalog=QuanLyTiemGame_version2;Integrated Security=True";
        //dt ket noi db
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter dataView = null;
        DataTable dataDisplayView = null;

        public DBMain()
        {
            conn = new SqlConnection(strConnectionString);
            comm = conn.CreateCommand();
        }

        public DataTable ExcuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            dataView = new SqlDataAdapter(comm);

            dataDisplayView = new DataTable();

            dataView.Fill(dataDisplayView);
            return dataDisplayView;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool flag = false;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                flag = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return flag;

        }
    }
}
