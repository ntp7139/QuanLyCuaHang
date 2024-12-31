namespace QuanLyCuaHang
{
    using MySql.Data;
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;

   
    public partial class FormDangNhap : Form
    {
        private NguoiBan Seller = new NguoiBan();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            
            if (Seller.SignIn(tB_TaiKhoan.Text, tB_MatKhau.Text))
            {
                this.Hide();
                MainForm mainForm = new MainForm(tB_TaiKhoan.Text);
                mainForm.ShowDialog();
                this.Show();
            }
     
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKy form = new FormDangKy();
            form.ShowDialog();
            this.Show();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
