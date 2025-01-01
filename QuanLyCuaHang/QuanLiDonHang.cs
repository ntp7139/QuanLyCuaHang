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
            string query = "SELECT * from donhang";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
                if(tb_Madonhang.Enabled == false)
            {
                tb_Madonhang.Enabled = true;
            }
            else
            {
                Connection connection = new Connection();
                string query = $"Delete from donhang Where madonhang = '{tb_Madonhang.Text}'";
                connection.ExcuteNonQuery(query);
                tb_Madonhang.Clear();
                MessageBox.Show("Đã xóa đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Madonhang.Enabled = false;
                QuanLiDonHang_Load(sender, e);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(tb_Makhachhang.Text  != "" && tb_ngaydathang.Text != "" && tb_Soluong.Text != "" && tb_masanpham.Text != "" && tb_Gia.Text != "" && lB_hinhthucthanhtoan.SelectedItem != null && lb_donvivanchuyen.SelectedItem != null)
            {
                string thanhtoan = "PayPal", vanchuyen = "Credit Card";
                thanhtoan = lB_hinhthucthanhtoan.SelectedItem.ToString();
                vanchuyen = lb_donvivanchuyen.SelectedItem.ToString();
                Decimal Gia = Convert.ToDecimal(tb_Gia.Text);
                DonHang donHang = new DonHang(tb_Makhachhang.Text,tb_masanpham.Text,Convert.ToInt32(tb_Soluong.Text),Gia,thanhtoan,vanchuyen);
                donHang.Add();
                QuanLiDonHang_Load(sender, e);
                MessageBox.Show("Thêm đơn hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Makhachhang.Clear();
                tb_masanpham.Clear();
                tb_Soluong.Clear();
                
            } else
            {
                MessageBox.Show("Hãy nhập đủ thông tin đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update_gia(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Connection connection = new Connection();
                    string query = $"Select * from sanpham where masanpham = '{tb_masanpham.Text}' ";
                    DataTable dt = connection.ExcuteQuery(query);
                    DataRow dr = dt.Rows[0];
                    string gia = dr["Gia"].ToString();
                    Decimal Gia_sanpham = Convert.ToDecimal(gia);
                    int So_luong = Convert.ToInt32(tb_Soluong.Text);
                    Decimal GiaCa = Gia_sanpham * So_luong;
                    tb_Gia.Text = GiaCa.ToString();
                    DateTime ngayHienTai = DateTime.Now;
                    DateTime chiNgay = ngayHienTai.Date; // Lấy phần ngày, giờ sẽ là 00:00:00
                    string ngayDinhDang = chiNgay.ToString("yyyy-MM-dd");
                    tb_ngaydathang.Text = ngayDinhDang;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Upload(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DonHang don = new DonHang();
                don.Load(tb_Madonhang.Text);
                tb_Makhachhang.Text = don.id_khachhang.ToString();
                tb_masanpham.Text = don.id_masanpham.ToString();
                tb_Soluong.Text = don.so_luong.ToString();
                lB_hinhthucthanhtoan.SelectedItem = don.Hinhthucthanhtoan;
                lb_donvivanchuyen.SelectedItem = don.Donvivanchuyen;
                tb_Gia.Text = don.Gia.ToString();
                tb_ngaydathang.Text = don.ngayDatHang.ToString();
               
            }
        }

        private void btn_xuathoadon_Click(object sender, EventArgs e)
        {
            if (tb_Madonhang.Enabled == false)
            {
                tb_Madonhang.Enabled = true;
            }
            else
            {

            }
        }
    }
}
