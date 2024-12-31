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
    public partial class QuanLiThanhToan : Form
    {
        public QuanLiThanhToan()
        {
            InitializeComponent();
        }

        private void QuanLiThanhToan_Load(object sender, EventArgs e)
        {

            Connection connection = new Connection();
            string query = "Select * from hinhthucthanhtoan";
            DataTable data = new DataTable();
            data = connection.ExcuteQuery(query);
            DtgV_QLTT.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
            DtgV_QLTT.RowHeadersVisible = false;
            DtgV_QLTT.DataSource = data;
        }
    }
}
