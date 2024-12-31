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
   
    public partial class MainForm : Form
    {
        private NguoiBan seller = new NguoiBan();

        public MainForm(string Id)
        {
            seller.id =Convert.ToInt32(Id);
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //HIển thị bảng quản lí người dùng
            Connection connection = new Connection();
            string query = "Select * from nguoiban";
            DataTable data = new DataTable();
            data = connection.ExcuteQuery(query);
            DtgV_QLND.RowHeadersVisible = false;
            DtgV_QLND.DataSource = data;
            // HIển thị bảng quản lí sản phẩm.
            string query1 = $"Select * from sanpham where Manguoiban = '{seller.id}'";
            DataTable data1 = new DataTable();
            data1 = connection.ExcuteQuery(query1);
            Dtvg_QLSP.RowHeadersVisible = false;
            Dtvg_QLSP.DataSource = data1;
        }

        private void DtgV_QLND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
