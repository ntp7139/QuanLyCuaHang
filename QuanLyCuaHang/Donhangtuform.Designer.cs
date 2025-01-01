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
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ordersform)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ordersform
            // 
            this.dtgv_ordersform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ordersform.Location = new System.Drawing.Point(58, 105);
            this.dtgv_ordersform.Name = "dtgv_ordersform";
            this.dtgv_ordersform.RowHeadersWidth = 62;
            this.dtgv_ordersform.RowTemplate.Height = 25;
            this.dtgv_ordersform.Size = new System.Drawing.Size(654, 487);
            this.dtgv_ordersform.TabIndex = 11;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(76, 55);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(79, 20);
            this.lb_1.TabIndex = 10;
            this.lb_1.Text = "Đơn hàng";
            // 
            // btn_Xuathoadon
            // 
            this.btn_Xuathoadon.Location = new System.Drawing.Point(796, 322);
            this.btn_Xuathoadon.Name = "btn_Xuathoadon";
            this.btn_Xuathoadon.Size = new System.Drawing.Size(211, 89);
            this.btn_Xuathoadon.TabIndex = 12;
            this.btn_Xuathoadon.Text = "Xuất hóa đơn";
            this.btn_Xuathoadon.UseVisualStyleBackColor = true;
            this.btn_Xuathoadon.Click += new System.EventHandler(this.btn_Xuathoadon_Click);
            // 
            // lb_
            // 
            this.lb_.AutoSize = true;
            this.lb_.Location = new System.Drawing.Point(751, 179);
            this.lb_.Name = "lb_";
            this.lb_.Size = new System.Drawing.Size(102, 20);
            this.lb_.TabIndex = 13;
            this.lb_.Text = "Mã đơn hàng";
            this.lb_.Click += new System.EventHandler(this.lb__Click);
            // 
            // tb_Madonhang
            // 
            this.tb_Madonhang.Location = new System.Drawing.Point(915, 173);
            this.tb_Madonhang.Name = "tb_Madonhang";
            this.tb_Madonhang.Size = new System.Drawing.Size(182, 26);
            this.tb_Madonhang.TabIndex = 14;
            // 
            // btn_Laythongitn
            // 
            this.btn_Laythongitn.Location = new System.Drawing.Point(796, 454);
            this.btn_Laythongitn.Name = "btn_Laythongitn";
            this.btn_Laythongitn.Size = new System.Drawing.Size(211, 102);
            this.btn_Laythongitn.TabIndex = 15;
            this.btn_Laythongitn.Text = "Lấy thông tin đơn";
            this.btn_Laythongitn.UseVisualStyleBackColor = true;
            this.btn_Laythongitn.Click += new System.EventHandler(this.btn_Laythongitn_Click);
            // 
            // Donhangtuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 646);
            this.Controls.Add(this.btn_Laythongitn);
            this.Controls.Add(this.tb_Madonhang);
            this.Controls.Add(this.lb_);
            this.Controls.Add(this.btn_Xuathoadon);
            this.Controls.Add(this.dtgv_ordersform);
            this.Controls.Add(this.lb_1);
            this.Name = "Donhangtuform";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ordersform)).EndInit();
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
    }
}