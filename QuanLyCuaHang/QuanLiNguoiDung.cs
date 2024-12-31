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
    public partial class QuanLiNguoiDung : Form
    {
        public QuanLiNguoiDung()
        {
            InitializeComponent();
        }

        private void QuanLiNguoiDung_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "Select * from nguoiban";
            DataTable data = new DataTable();
            data = connection.ExcuteQuery(query);
            DtgV_QLND.RowHeadersVisible = false;
            DtgV_QLND.DataSource = data;

        }
    }
}
