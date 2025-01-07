using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.Field;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyCuaHang
{
    internal class Connection
    {
        // Connection tới SQL Server
        private string connection = "Server=DESKTOP-HH7KDOL\\SQLEXPRESS; Database=PTTKHT; Trusted_Connection=True;";

        // Kết nối tới SQL Server
        public SqlConnection SqlConnection(string connect)
        {
            SqlConnection conn = new SqlConnection(connect);
            return conn;
        }

        // Thực hiện truy vấn trả về select
        public DataTable ExcuteQuery(string query)
        {
            DataTable dt = new DataTable();
            SqlConnection Connect = SqlConnection(connection);
            try
            {
                Connect.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connect))
                {
                    adapter.Fill(dt);
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        // Thực hiện các câu lệnh non-Query (Insert, Update, Delete)
        public void ExcuteNonQuery(string nonquery)
        {
            SqlConnection Connect = SqlConnection(connection);
            try
            {
                Connect.Open();
                using (SqlCommand command = new SqlCommand(nonquery, Connect))
                {
                    command.ExecuteNonQuery();
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Thực hiện truy vấn xem có cột hay không
        public bool Check_Query(string query)
        {
            bool check = false;
            SqlConnection Connect = SqlConnection(connection);
            try
            {
                Connect.Open();
                SqlCommand command = new SqlCommand(query, Connect);
                using (SqlDataReader read = command.ExecuteReader())
                {
                    if (read.HasRows)
                    {
                        check = true;
                    }
                    else check = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return check;
        }

        // Thực hiện trả về duy nhất 1 giá trị (Count, Max)
        public int ExcuteScalar(string query)
        {
            int result = 0;
            SqlConnection Connect = SqlConnection(connection);
            try
            {
                Connect.Open();
                SqlCommand cmd = new SqlCommand(query, Connect);
                if (!(cmd.ExecuteScalar() == null))
                {
                    object count_row = cmd.ExecuteScalar();
                    result = Convert.ToInt32(count_row);
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public bool Check_ID_Sellers(string ID)
        {
            string query = $"SELECT * FROM nguoiban WHERE manguoiban = '{ID}'";
            bool Check = Check_Query(query);
            return Check;
        }

        public bool Check_Sellers(string ID, string matkhau)
        {
            string query = $"SELECT * FROM nguoiban WHERE manguoiban = '{ID}' AND matkhau = '{matkhau}'";
            bool Check = Check_Query(query);
            return Check;
        }

        public bool Check_ID_SanPham(string ID)
        {
            string query = $"SELECT * FROM sanpham WHERE masanpham = '{ID}'";
            bool Check = Check_Query(query);
            return Check;
        }


    }
}
