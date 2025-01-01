namespace QuanLyCuaHang
{
    partial class QuanLiDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DtgV_QLDH = new System.Windows.Forms.DataGridView();
            this.lb_1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.lb_donvivanchuyen = new System.Windows.Forms.ListBox();
            this.lB_hinhthucthanhtoan = new System.Windows.Forms.ListBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.tb_ngaydathang = new System.Windows.Forms.TextBox();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.tb_Soluong = new System.Windows.Forms.TextBox();
            this.tb_masanpham = new System.Windows.Forms.TextBox();
            this.tb_Makhachhang = new System.Windows.Forms.TextBox();
            this.tb_Madonhang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_xuathoadon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgV_QLDH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgV_QLDH
            // 
            this.DtgV_QLDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgV_QLDH.Location = new System.Drawing.Point(40, 97);
            this.DtgV_QLDH.Name = "DtgV_QLDH";
            this.DtgV_QLDH.RowHeadersWidth = 62;
            this.DtgV_QLDH.RowTemplate.Height = 25;
            this.DtgV_QLDH.Size = new System.Drawing.Size(654, 487);
            this.DtgV_QLDH.TabIndex = 9;
            this.DtgV_QLDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgV_QLDH_CellContentClick);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(58, 47);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(79, 20);
            this.lb_1.TabIndex = 8;
            this.lb_1.Text = "Đơn hàng";
            this.lb_1.Click += new System.EventHandler(this.lb_1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_xuathoadon);
            this.panel1.Controls.Add(this.btn_Xóa);
            this.panel1.Controls.Add(this.lb_donvivanchuyen);
            this.panel1.Controls.Add(this.lB_hinhthucthanhtoan);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.tb_ngaydathang);
            this.panel1.Controls.Add(this.tb_Gia);
            this.panel1.Controls.Add(this.tb_Soluong);
            this.panel1.Controls.Add(this.tb_masanpham);
            this.panel1.Controls.Add(this.tb_Makhachhang);
            this.panel1.Controls.Add(this.tb_Madonhang);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Location = new System.Drawing.Point(722, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 571);
            this.panel1.TabIndex = 10;
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.Location = new System.Drawing.Point(204, 453);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(82, 46);
            this.btn_Xóa.TabIndex = 19;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = true;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // lb_donvivanchuyen
            // 
            this.lb_donvivanchuyen.FormattingEnabled = true;
            this.lb_donvivanchuyen.ItemHeight = 20;
            this.lb_donvivanchuyen.Items.AddRange(new object[] {
            "FedEX",
            "VietNamPost",
            "DHL"});
            this.lb_donvivanchuyen.Location = new System.Drawing.Point(190, 266);
            this.lb_donvivanchuyen.Name = "lb_donvivanchuyen";
            this.lb_donvivanchuyen.Size = new System.Drawing.Size(124, 44);
            this.lb_donvivanchuyen.TabIndex = 18;
            // 
            // lB_hinhthucthanhtoan
            // 
            this.lB_hinhthucthanhtoan.FormattingEnabled = true;
            this.lB_hinhthucthanhtoan.ItemHeight = 20;
            this.lB_hinhthucthanhtoan.Items.AddRange(new object[] {
            "Credit Card",
            "Transfer Bank",
            "PayPal"});
            this.lB_hinhthucthanhtoan.Location = new System.Drawing.Point(186, 215);
            this.lB_hinhthucthanhtoan.Name = "lB_hinhthucthanhtoan";
            this.lB_hinhthucthanhtoan.Size = new System.Drawing.Size(129, 44);
            this.lB_hinhthucthanhtoan.TabIndex = 17;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(42, 453);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(82, 46);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tb_ngaydathang
            // 
            this.tb_ngaydathang.Enabled = false;
            this.tb_ngaydathang.Location = new System.Drawing.Point(131, 355);
            this.tb_ngaydathang.Name = "tb_ngaydathang";
            this.tb_ngaydathang.Size = new System.Drawing.Size(184, 26);
            this.tb_ngaydathang.TabIndex = 14;
            // 
            // tb_Gia
            // 
            this.tb_Gia.Location = new System.Drawing.Point(131, 317);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(184, 26);
            this.tb_Gia.TabIndex = 13;
            // 
            // tb_Soluong
            // 
            this.tb_Soluong.Location = new System.Drawing.Point(131, 183);
            this.tb_Soluong.Name = "tb_Soluong";
            this.tb_Soluong.Size = new System.Drawing.Size(184, 26);
            this.tb_Soluong.TabIndex = 12;
            this.tb_Soluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Update_gia);
            // 
            // tb_masanpham
            // 
            this.tb_masanpham.Location = new System.Drawing.Point(131, 141);
            this.tb_masanpham.Name = "tb_masanpham";
            this.tb_masanpham.Size = new System.Drawing.Size(184, 26);
            this.tb_masanpham.TabIndex = 11;
            // 
            // tb_Makhachhang
            // 
            this.tb_Makhachhang.Location = new System.Drawing.Point(131, 99);
            this.tb_Makhachhang.Name = "tb_Makhachhang";
            this.tb_Makhachhang.Size = new System.Drawing.Size(184, 26);
            this.tb_Makhachhang.TabIndex = 10;
            // 
            // tb_Madonhang
            // 
            this.tb_Madonhang.Enabled = false;
            this.tb_Madonhang.Location = new System.Drawing.Point(131, 54);
            this.tb_Madonhang.Name = "tb_Madonhang";
            this.tb_Madonhang.Size = new System.Drawing.Size(184, 26);
            this.tb_Madonhang.TabIndex = 9;
            this.tb_Madonhang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Upload);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày đặt hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đơn vị vận chuyển";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hình thức thanh toán";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đơn hàng";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Location = new System.Drawing.Point(105, 8);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(120, 20);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Thêm đơn hàng";
            // 
            // btn_xuathoadon
            // 
            this.btn_xuathoadon.Location = new System.Drawing.Point(71, 507);
            this.btn_xuathoadon.Name = "btn_xuathoadon";
            this.btn_xuathoadon.Size = new System.Drawing.Size(181, 50);
            this.btn_xuathoadon.TabIndex = 20;
            this.btn_xuathoadon.Text = "Xuất hóa đơn";
            this.btn_xuathoadon.UseVisualStyleBackColor = true;
            this.btn_xuathoadon.Click += new System.EventHandler(this.btn_xuathoadon_Click);
            // 
            // QuanLiDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DtgV_QLDH);
            this.Controls.Add(this.lb_1);
            this.Name = "QuanLiDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.QuanLiDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgV_QLDH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgV_QLDH;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lB_hinhthucthanhtoan;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tb_ngaydathang;
        private System.Windows.Forms.TextBox tb_Gia;
        private System.Windows.Forms.TextBox tb_Soluong;
        private System.Windows.Forms.TextBox tb_masanpham;
        private System.Windows.Forms.TextBox tb_Makhachhang;
        private System.Windows.Forms.TextBox tb_Madonhang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_donvivanchuyen;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_xuathoadon;
    }
}