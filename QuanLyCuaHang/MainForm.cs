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
            
            InitializeComponent();
            Phan_Quyen();
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
                btn_QuanLiNguoiDung.Visible = false;
                btn_QuanliCuahang.Visible = true;

            }
            else {

                btn_QuanLiNguoiDung.Visible = true;
                btn_QuanliCuahang.Visible = false;
            }
                    
        }

        private void btn_QuanLiNguoiDung_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiNguoiDung form = new QuanLiNguoiDung();
            form.ShowDialog();
            this.Show();
        }
        private void QuanLiSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiSanPham form = new QuanLiSanPham(seller.id);
            form.ShowDialog();
            this.Show();
        }

        private void quảnLíĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiDonHang form = new QuanLiDonHang();
            form.ShowDialog();
            this.Show();
        }

        private void quảnLíThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiThanhToan   form = new QuanLiThanhToan();
            form.ShowDialog();
            this.Show();
        }

        private void quảnLíVậnChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiVanCHuyen form = new QuanLiVanCHuyen();
            form.ShowDialog();
            this.Show();
        }

        private void quảnLíBáoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiBaocaodoanhThu form = new QuanLiBaocaodoanhThu();
            form.ShowDialog();
            this.Show();
        }

        private void quảnLíPhảnHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiPhanHoi form = new QuanLiPhanHoi();
            form.ShowDialog();
            this.Show();
        }

        private void quảnLíĐơnHàngTừFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donhangtuform form = new Donhangtuform();
            form.ShowDialog();
            this.Show();    
        }
    }
}
