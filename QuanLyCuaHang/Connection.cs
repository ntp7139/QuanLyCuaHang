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
        private string connection = "server=phatchison-phatbaoan112-1d4a.d.aivencloud.com;port = 28938;uid=avnadmin;pwd=AVNS_UF7t0kMFhSmIyxPG8M5;database=pttkht";
        //Kết nối tới MySQL sever;

        // Kết nối tới SQL Server
        // Tạo kết nối MySQL
        public MySqlConnection SqlConnection(string connect)
        {
            MySqlConnection conn = new MySqlConnection(connect);
            return conn;
        }

        // Thực hiện truy vấn trả về dữ liệu (SELECT)
        public DataTable ExcuteQuery(string query)
        {
            DataTable dt = new DataTable();
            MySqlConnection Connect = SqlConnection(connection);
            try
            {
                Connect.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, Connect))
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

        // Thực hiện các câu lệnh non-query (Insert, Update, Delete)
        public void ExcuteNonQuery(string nonquery)
        {
            MySqlConnection Connect = SqlConnection(connection);
            try
            {
                Connect.Open();
                using (MySqlCommand command = new MySqlCommand(nonquery, Connect))
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

        // Thực hiện truy vấn để kiểm tra có cột hay không
        public bool Check_Query(string query)
        {
            bool check = false;
            MySqlConnection Connect = SqlConnection(connection);
            try
            {
                Connect.Open();
                MySqlCommand command = new MySqlCommand(query, Connect);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
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
            MySqlConnection Connect = SqlConnection(connection);
            try
            {
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                object count_row = cmd.ExecuteScalar();
                if (count_row != null)
                {
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

        // Kiểm tra ID của người bán
        public bool Check_ID_Sellers(string ID)
        {
            string query = $"SELECT * FROM nguoiban WHERE manguoiban = '{ID}'";
            bool Check = Check_Query(query);
            return Check;
        }

        // Kiểm tra người bán với mật khẩu
        public bool Check_Sellers(string ID, string matkhau)
        {
            string query = $"SELECT * FROM nguoiban WHERE manguoiban = '{ID}' AND matkhau = '{matkhau}'";
            bool Check = Check_Query(query);
            return Check;
        }

        // Kiểm tra ID sản phẩm
        public bool Check_ID_SanPham(string ID)
        {
            string query = $"SELECT * FROM sanpham WHERE masanpham = '{ID}'";
            bool Check = Check_Query(query);
            return Check;
        }


    }
}
