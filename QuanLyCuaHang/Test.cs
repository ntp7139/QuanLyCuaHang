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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            DonHang order = new DonHang();
            order.Load("1");
            textBox1.Text = order.ngayDatHang.ToString();
        }
    }
}
