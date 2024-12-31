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
            seller.Load_Seller();
            Phan_Quyen();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
           
        }

        private void DtgV_QLND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Phan_Quyen()
        {
            if (seller.QuyenTruyCap == "User")
            {
                

            }
            else {
                
            }
                    
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lb_1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_QLND_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_QLND_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_QLND_Click(object sender, EventArgs e)
        {

        }

        private void btn_QuanLiNguoiDung_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiNguoiDung form = new QuanLiNguoiDung();
            form.ShowDialog();
            this.Show();
        }
    }
}
