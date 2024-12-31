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

        private void btn_Add_QLND_Click(object sender, EventArgs e)
        {
            DateTime ngayHienTai = DateTime.Now;
            DateTime chiNgay = ngayHienTai.Date; // Lấy phần ngày, giờ sẽ là 00:00:00
            string ngayDinhDang = chiNgay.ToString("yyyy-MM-dd");
            pn_Chucnang.Visible = true;
            btn_Chucnang.Text = "Thêm";
            tb_ngaythamgia.Text = ngayDinhDang;

        }

        private void btn_Chucnang_Click(object sender, EventArgs e)
        {
            if(btn_Chucnang.Text == "Thêm")
            {
                Connection connection = new Connection();
                if (!connection.Check_ID_Sellers(tb_Manguoiban.Text))
                {
                    string query = $"insert into nguoiban values('{tb_Manguoiban.Text}','{tb_Tennguoiban.Text}'," +
                        $"'{tb_matkhau.Text}','{tb_email.Text}','{tb_sodienthoai.Text}','{tb_diachi.Text}','{tb_ngaythamgia.Text}','User')";

                    connection.ExcuteNonQuery(query);
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLiNguoiDung_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("ID đã tồn tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            } else if(btn_Chucnang.Text == "Sửa")
            {

            } else if(btn_Chucnang.Text == "Xóa")
            {

            }
        }

        private void btn_Edit_QLND_Click(object sender, EventArgs e)
        {
            pn_Chucnang.Visible = true;
            btn_Chucnang.Text = "Sửa";
           
            
        }

        private void btn_Delete_QLND_Click(object sender, EventArgs e)
        {
            pn_Chucnang.Visible = true;
            btn_Chucnang.Text = "Xóa";
        }

        private void btn_Thoat_Sua_Click(object sender, EventArgs e)
        {
            pn_Chucnang.Visible = false;
            tb_diachi.Clear();
            tb_email.Clear();
            tb_Manguoiban.Clear();
            tb_matkhau.Clear();
            tb_ngaythamgia.Clear();
            tb_sodienthoai.Clear();
            tb_Tennguoiban.Clear();
        }
        private void keydown_event(object sender, KeyEventArgs e)
        {
            if (btn_Chucnang.Text == "Sửa" || btn_Chucnang.Text == "Xóa")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Connection connection = new Connection();
                    if (connection.Check_ID_Sellers(tb_Manguoiban.Text))
                    {
                        string query = $"Select * from nguoiban where manguoiban = '{tb_Manguoiban.Text}'";
                        DataTable dt = connection.ExcuteQuery(query);
                        DataRow dr = dt.Rows[0];
                        tb_Tennguoiban.Text = dr["Tennguoiban"].ToString();
                        tb_matkhau.Text = dr["matkhau"].ToString() ;
                        tb_email.Text = dr["email"].ToString();
                        tb_ngaythamgia.Text = dr["Ngaythamgia"].ToString() ;
                        tb_sodienthoai.Text = dr["sodienthoai"].ToString() ;
                        tb_diachi.Text = dr["diachi"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("ID không đã tồn tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
