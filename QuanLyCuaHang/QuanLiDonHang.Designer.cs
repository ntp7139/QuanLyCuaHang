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
            ((System.ComponentModel.ISupportInitialize)(this.DtgV_QLDH)).BeginInit();
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
            // QuanLiDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 650);
            this.Controls.Add(this.DtgV_QLDH);
            this.Controls.Add(this.lb_1);
            this.Name = "QuanLiDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.QuanLiDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgV_QLDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgV_QLDH;
        private System.Windows.Forms.Label lb_1;
    }
}