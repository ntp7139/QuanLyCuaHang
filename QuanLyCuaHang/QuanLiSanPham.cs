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
    public partial class QuanLiSanPham : Form
    {
        private NguoiBan seller = new NguoiBan();
        public QuanLiSanPham(int id)
        {
            seller.id = id;
            seller.Load_Seller();
            InitializeComponent();
        }

        private void QuanLiSanPham_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = $"Select * from sanpham where manguoiban = '{seller.id}'";
            DataTable dataTable = new DataTable();
            dataTable = connection.ExcuteQuery(query);
            DtgV_QLSP.RowHeadersVisible = false;
            DtgV_QLSP.AutoGenerateColumns = true;
            DtgV_QLSP.DataSource = dataTable;  

        }

        private void btn_Add_QLND_Click(object sender, EventArgs e)
        {
            pn_Them.Visible = true;
        }

        private void btn_Edit_QLND_Click(object sender, EventArgs e)
        {
            pn_Sua.Visible = true;
        }

        private void btn_Delete_QLND_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Them_Click(object sender, EventArgs e)
        {
            pn_Them.Visible=false;
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Connection connection=new Connection();
            if (!connection.Check_ID_SanPham(tB_MaSanPham_Them.Text))
            {
                string query = $"insert into sanpham values('{tB_MaSanPham_Them.Text}','{tB_Manguoiban_Them.Text}','{Tb_tensanpham_Them.Text}'" +
                    $",'{tB_Mota_Them.Text}','{tB_Gia_Them.Text}','{tB_Soluong_Them.Text}','{tB_LinkAnh_Them.Text}')";
                connection.ExcuteNonQuery(query);
            }
            else
            {
                MessageBox.Show("Đã tồn tại mã sản phẩm!","Thông báo!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            QuanLiSanPham_Load(sender, e);
        }

        private void btn_Thoat_Sua_Click(object sender, EventArgs e)
        {
            pn_Sua.Visible =false;
        }
        private void text_Sua(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Connection connection = new Connection();
                if (connection.Check_ID_SanPham(tb_Masanpham_sua.Text))
                {
                    string query = $"select * from sanpham where masanpham = '{tb_Masanpham_sua.Text}'";
                    DataTable dt = connection.ExcuteQuery(query);
                    DataRow dr = dt.Rows[0];

                    btn_Sua.Enabled = true;    
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    tb_soluongton_sua.Visible = true;
                    tb_gia_sua.Visible = true;
                    tb_linkanh_sua.Visible = true;
                    tb_Ma_nguoiban_sua.Visible = true;
                    tb_mota_sua.Visible = true;
                    tb_ten_sanphamsua.Visible = true;
                    tb_Ma_nguoiban_sua.Text = dr["Manguoiban"].ToString();
                    tb_ten_sanphamsua.Text = dr["Tensanpham"].ToString();
                    tb_mota_sua.Text = dr["Mota"].ToString();
                    tb_gia_sua.Text = dr["Gia"].ToString() ;
                    tb_soluongton_sua.Text = dr["Soluongton"].ToString();
                    tb_linkanh_sua.Text = dr["HinhAnh"].ToString();


                }
                else
                {
                    MessageBox.Show("Không tồn tại mã sản phẩm!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = $"Update sanpham" +
                           $"set tensanpham ='{tb_ten_sanphamsua.Text}', mota = '{tb_mota_sua.Text}',gia='{tb_gia_sua}','";
        }
    }
}
