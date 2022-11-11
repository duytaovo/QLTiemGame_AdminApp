using System;

using System.Data;
using System.Data.SqlClient;

namespace QuanLyTiemGame.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        string connectionSTR = "Data Source = DESKTOP-12J6D6C;" + "Initial Catalog = QLTiemGame;" + "Integrated Security=True";
        SqlConnection cnn = null;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = null;
        DataTable dataDisplayView = null;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        public DataProvider() { 
 
            cnn = new SqlConnection(connectionSTR);
            cmd = cnn.CreateCommand();
         
        }

        /*  string connectionSTR = "Data Source=.;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";*/
       
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public DataTable ExecuteQuery(string query, CommandType ct, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
           
                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

       

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;

            }
            finally
            {
                cnn.Close();
            }
            return f;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

        public DataSet ExcuteQuerryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {

            //Nếu Connection đang mở=>Đóng
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            //Mở Connection
            cnn.Open();
            cmd.CommandType = ct;
            cmd.CommandText = strSQL;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public DataTable ExcuteQueryDataTable(string strSQL, CommandType ct)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            dataDisplayView = new DataTable();
            adp.Fill(dataDisplayView);
            return dataDisplayView;
        }
    }
}
