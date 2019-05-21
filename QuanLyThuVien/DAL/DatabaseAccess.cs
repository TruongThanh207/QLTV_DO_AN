using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class DatabaseAccess
    {
        public class DatabaseAcess
        {
            //tạo 1 thể hiện duy nhất: singleton patern
            private static DatabaseAcess instance;
            public static DatabaseAcess Instance
            {
                get
                {
                    if (instance == null)
                        instance = new DatabaseAcess();
                    return instance;
                }

                private set
                {
                    instance = value;
                }
            }

            string connection = @"Data Source=DESKTOP-E7FMC7V;Initial Catalog=QLTV;Integrated Security=True";
            SqlConnection sqlconnect = null;

            private DatabaseAcess() { }

            public void OpenConnection()
            {
                if (sqlconnect == null)
                    sqlconnect = new SqlConnection(connection);
                if (sqlconnect.State == System.Data.ConnectionState.Closed)
                    sqlconnect.Open();
            }

            public void CloseConnection()
            {
                if (sqlconnect != null && sqlconnect.State == System.Data.ConnectionState.Open)
                    sqlconnect.Close();
            }

            public DataTable ExcuteQuery(string query, object[] paramater = null)
            {
                OpenConnection();

                SqlCommand cmd = new SqlCommand(query, sqlconnect);

                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);

                CloseConnection();
                return data;
            }

            public int ExecuteNonQuery(string query, object[] paramater = null)
            {
                OpenConnection();
                int data = 0;
                SqlCommand cmd = new SqlCommand(query, sqlconnect);

                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();
                CloseConnection();
                return data;
            }

            public object ExecuteScalar(string query, object[] paramater = null)
            {
                OpenConnection();
                object data = 0;
                SqlCommand cmd = new SqlCommand(query, sqlconnect);

                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();
                CloseConnection();
                return data;
            }

        }
    }
}
