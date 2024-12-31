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
namespace QuanLyCuaHang
{
    internal class Connection 
    {
        //Connection tới  server 
        private string connection =  "server=127.0.0.1;port = 3306;uid=root;pwd=phatbaoan112;database=facebooksalesmanagement";
        //Kết nối tới MySQL sever
        public MySqlConnection MySqlConnection(string connect)
        {
            MySqlConnection conn = new MySqlConnection(connect);
            return conn;
        }
        // Thực hiện truy vấn tra về select
        public DataTable ExcuteQuery(string query)
        {
            DataTable dt = new DataTable();
            MySqlConnection Connect = MySqlConnection(connection);
            try
            {
                Connect.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query,Connect))
                { 
                    adapter.Fill(dt);

                }
                Connect.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        // Thực hiện các câu lệnh non-Query (Insert, Update, Delete)
        public void ExcuteNonQuery(string nonquery)
        {
            MySqlConnection Connect = MySqlConnection(connection);
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
        // Thực hiện truy vấn xem có cột hay không
        public bool Check_Query(string query) 
        {
            bool check =false;
            MySqlConnection Connect = MySqlConnection(connection);
            try
            {
                Connect.Open();
                MySqlCommand command = new MySqlCommand(query, Connect);
                using (MySqlDataReader read = command.ExecuteReader())
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
        // Thực hiện trả về duy nhất 1 giá trị ( Count, Max)
        public int ExcuteScalar(string query)
        {
            int result = 0;
            MySqlConnection Connect = MySqlConnection(connection);
            try
            {
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
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
            
            string query  = $"select * from nguoiban where manguoiban = '{ID}'";
            bool Check = Check_Query(query);
            return Check;

        }
        public bool Check_Sellers(string ID,string matkhau)
        {

            string query = $"select * from nguoiban where manguoiban = '{ID}' and matkhau ='{matkhau}'";
            bool Check = Check_Query(query);
            return Check;

        }
        

    }
}
