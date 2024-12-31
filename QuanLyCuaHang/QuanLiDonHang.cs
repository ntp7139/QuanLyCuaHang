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
    public partial class QuanLiDonHang : Form
    {
        public QuanLiDonHang()
        {
            InitializeComponent();
        }

        private void QuanLiDonHang_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "SELECT A.MaDonHang,A.MaKhachHang,B.MaSanPham,B.SoLuong,A.NgayDatHang,A.TrangThai,B.Gia,B.Hinhthucthanhtoan,B.Donvivanchuyen \r\nFROM donhang as A join chitietdonhang as B\r\non A.MaDonHang = B.MaDonHang;";
            DataTable dt = connection.ExcuteQuery(query);
            DtgV_QLDH.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DtgV_QLDH.RowHeadersVisible = false;
            DtgV_QLDH.DataSource = dt;  
        }

        private void DtgV_QLDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lb_1_Click(object sender, EventArgs e)
        {

        }
    }
}
