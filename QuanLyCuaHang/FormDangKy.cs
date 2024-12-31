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
        private NguoiBan seller = new NguoiBan();
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
            if(seller.Register(tb_name.Text,tb_TaiKhoan_DangKy.Text, tb_MatKhau_DangKy.Text, tb_NhapLaiMatKhau.Text, tb_Email_DangKy.Text))
            {
                MessageBox.Show("Bạn đã đnăg kí thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
