using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DAO
{
    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set{DataProvider.instance = value; }
        }
        private string connectionSTR = @"Data Source=PCMINH;Initial Catalog=QuanLyCuaHangTienLoi;Persist Security Info=True;";
        public void setAdmin(bool admin)
        {
            if (admin)
            {
                this.connectionSTR += "User ID=minhle;Password=101797";
            }
            else
            {
                this.connectionSTR += "User ID=minhle;Password=101797";
            }
        }
        public DataTable ExecuteQuery(string query,object[] parameters=null)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionSTR))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    if (parameters != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                    sqlDataAdapter.Fill(data);
                    conn.Close();
                }
                return data;
            }
            catch(Exception e)
            {
                Console.WriteLine("Lỗi");
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public bool ExecuteNonQuery(string query, object[] parameters = null)
        {
          try
            {
                using (SqlConnection conn = new SqlConnection(connectionSTR))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    if (parameters != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;
            SqlConnection conn = new SqlConnection(connectionSTR);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }
    }
}
