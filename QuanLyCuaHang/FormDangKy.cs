using MySql.Data.MySqlClient;
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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

      

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            if (connection.Check_ID_Sellers(tb_TaiKhoan_DangKy.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại!","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Stop);
            }
            else
            {
                if(tb_MatKhau_DangKy.Text != tb_NhapLaiMatKhau.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }
                else
                {

                }
            }
        }
    }
}
