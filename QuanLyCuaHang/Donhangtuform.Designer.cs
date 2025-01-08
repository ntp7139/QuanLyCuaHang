namespace QuanLyCuaHang
{
    partial class Donhangtuform
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
            this.dtgv_ordersform = new System.Windows.Forms.DataGridView();
            this.lb_1 = new System.Windows.Forms.Label();
            this.btn_Xuathoadon = new System.Windows.Forms.Button();
            this.lb_ = new System.Windows.Forms.Label();
            this.tb_Madonhang = new System.Windows.Forms.TextBox();
            this.btn_Laythongitn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ordersform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ordersform
            // 
            this.dtgv_ordersform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ordersform.Location = new System.Drawing.Point(36, 138);
            this.dtgv_ordersform.Name = "dtgv_ordersform";
            this.dtgv_ordersform.RowHeadersWidth = 62;
            this.dtgv_ordersform.RowTemplate.Height = 25;
            this.dtgv_ordersform.Size = new System.Drawing.Size(654, 487);
            this.dtgv_ordersform.TabIndex = 11;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(54, 48);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(127, 29);
            this.lb_1.TabIndex = 10;
            this.lb_1.Text = "Đơn hàng";
            // 
            // btn_Xuathoadon
            // 
            this.btn_Xuathoadon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Xuathoadon.Location = new System.Drawing.Point(796, 324);
            this.btn_Xuathoadon.Name = "btn_Xuathoadon";
            this.btn_Xuathoadon.Size = new System.Drawing.Size(211, 89);
            this.btn_Xuathoadon.TabIndex = 12;
            this.btn_Xuathoadon.Text = "Xuất hóa đơn";
            this.btn_Xuathoadon.UseVisualStyleBackColor = false;
            this.btn_Xuathoadon.Click += new System.EventHandler(this.btn_Xuathoadon_Click);
            // 
            // lb_
            // 
            this.lb_.AutoSize = true;
            this.lb_.Location = new System.Drawing.Point(719, 230);
            this.lb_.Name = "lb_";
            this.lb_.Size = new System.Drawing.Size(102, 20);
            this.lb_.TabIndex = 13;
            this.lb_.Text = "Mã đơn hàng";
            this.lb_.Click += new System.EventHandler(this.lb__Click);
            // 
            // tb_Madonhang
            // 
            this.tb_Madonhang.Location = new System.Drawing.Point(883, 224);
            this.tb_Madonhang.Name = "tb_Madonhang";
            this.tb_Madonhang.Size = new System.Drawing.Size(182, 26);
            this.tb_Madonhang.TabIndex = 14;
            // 
            // btn_Laythongitn
            // 
            this.btn_Laythongitn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Laythongitn.Location = new System.Drawing.Point(248, 14);
            this.btn_Laythongitn.Name = "btn_Laythongitn";
            this.btn_Laythongitn.Size = new System.Drawing.Size(211, 102);
            this.btn_Laythongitn.TabIndex = 15;
            this.btn_Laythongitn.Text = "Lấy thông tin đơn";
            this.btn_Laythongitn.UseVisualStyleBackColor = false;
            this.btn_Laythongitn.Click += new System.EventHandler(this.btn_Laythongitn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.xanhlam;
            this.pictureBox1.Location = new System.Drawing.Point(705, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 250);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.xanhlam;
            this.pictureBox2.Location = new System.Drawing.Point(39, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(479, 130);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Donhangtuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.ảnh_nền;
            this.ClientSize = new System.Drawing.Size(1109, 646);
            this.Controls.Add(this.btn_Laythongitn);
            this.Controls.Add(this.tb_Madonhang);
            this.Controls.Add(this.lb_);
            this.Controls.Add(this.btn_Xuathoadon);
            this.Controls.Add(this.dtgv_ordersform);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Donhangtuform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ordersform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ordersform;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Button btn_Xuathoadon;
        private System.Windows.Forms.Label lb_;
        private System.Windows.Forms.TextBox tb_Madonhang;
        private System.Windows.Forms.Button btn_Laythongitn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}