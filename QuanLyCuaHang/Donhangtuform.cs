using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class Donhangtuform : Form
    {
        public Donhangtuform()
        {
            InitializeComponent();
        }

        private void lb__Click(object sender, EventArgs e)
        {

        }
        public void Load_1(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "Select * from ordersform ";
            DataTable dt = connection.ExcuteQuery(query);
            dtgv_ordersform.AutoGenerateColumns = true;
            dtgv_ordersform.RowHeadersVisible = false;
            dtgv_ordersform.DataSource = dt;
        }
    }
}
