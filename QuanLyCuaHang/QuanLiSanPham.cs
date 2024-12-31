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
            pn_xóa.Visible = true;
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
            
            tB_Gia_Them.Clear();
            tB_MaSanPham_Them.Clear();
            tB_Manguoiban_Them.Clear();
            Tb_tensanpham_Them.Clear();
            tB_Mota_Them.Clear();
            tB_Soluong_Them.Clear();
            tB_LinkAnh_Them.Clear();
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
           SanPham sanpham = new SanPham(Convert.ToInt32(tB_MaSanPham_Them.Text), Convert.ToInt32(tB_Manguoiban_Them.Text),Tb_tensanpham_Them.Text,tB_Mota_Them.Text,Convert.ToDecimal(tB_Gia_Them.Text),Convert.ToInt32(tB_Soluong_Them.Text),tB_LinkAnh_Them.Text);
                        
            sanpham.AddNewProduct();
            QuanLiSanPham_Load(sender, e);
        }

        private void btn_Thoat_Sua_Click(object sender, EventArgs e)
        {
            pn_Sua.Visible =false;
            btn_Sua.Enabled = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            tb_soluongton_sua.Visible = false;
            tb_gia_sua.Visible = false;
            tb_linkanh_sua.Visible = false;
            tb_Ma_nguoiban_sua.Visible = false;
            tb_mota_sua.Visible = false;
            tb_ten_sanphamsua.Visible = false;
            tb_soluongton_sua.Clear();
            tb_gia_sua.Clear();
            tb_linkanh_sua.Clear();
            tb_Ma_nguoiban_sua.Clear();
            tb_mota_sua.Clear();
            tb_ten_sanphamsua.Clear();

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
            SanPham sanpham = new SanPham(Convert.ToInt32(tb_Masanpham_sua.Text), Convert.ToInt32(tb_Ma_nguoiban_sua.Text), tb_ten_sanphamsua.Text, tb_mota_sua.Text, Convert.ToDecimal(tb_gia_sua.Text), Convert.ToInt32(tb_soluongton_sua.Text), tb_linkanh_sua.Text);
            sanpham.EditProduct();
            QuanLiSanPham_Load(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham();
            sanpham.DeleteProduct(tB_masanpham_xoa.Text);
            QuanLiSanPham_Load(sender, e);
        }

        private void btn_thoat_xoa_Click(object sender, EventArgs e)
        {
            pn_xóa.Visible = false;
            tB_masanpham_xoa.Clear();
        }
    }
}
