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
    public partial class QuanLiVanCHuyen : Form
    {
        public QuanLiVanCHuyen()
        {
            InitializeComponent();
        }

        private void QuanLiVanCHuyen_Load(object sender, EventArgs e)
        {

            Connection connection = new Connection();
            string query = "Select * from donvivanchuyen";
            DataTable data = new DataTable();
            DtgV_QLVC.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
            data = connection.ExcuteQuery(query);
            DtgV_QLVC.RowHeadersVisible = false;
            DtgV_QLVC.DataSource = data;
        }
    }
}
