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
    public partial class QuanLiPhanHoi : Form
    {
        public QuanLiPhanHoi()
        {
            InitializeComponent();
        }

        private void QuanLiPhanHoi_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "Select * from tinnhan";
            DataTable dt = connection.ExcuteQuery(query);
            DtgV_QLPH.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DtgV_QLPH.RowHeadersVisible = false;
            DtgV_QLPH.DataSource = dt;
        }
    }
}
