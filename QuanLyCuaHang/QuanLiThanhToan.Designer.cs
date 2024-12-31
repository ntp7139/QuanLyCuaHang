namespace QuanLyCuaHang
{
    partial class QuanLiThanhToan
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
            this.DtgV_QLTT = new System.Windows.Forms.DataGridView();
            this.lb_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgV_QLTT)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgV_QLTT
            // 
            this.DtgV_QLTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgV_QLTT.Location = new System.Drawing.Point(38, 106);
            this.DtgV_QLTT.Name = "DtgV_QLTT";
            this.DtgV_QLTT.RowHeadersWidth = 62;
            this.DtgV_QLTT.RowTemplate.Height = 25;
            this.DtgV_QLTT.Size = new System.Drawing.Size(631, 487);
            this.DtgV_QLTT.TabIndex = 11;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(56, 56);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(90, 20);
            this.lb_1.TabIndex = 10;
            this.lb_1.Text = "Thanh toán";
            // 
            // QuanLiThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 650);
            this.Controls.Add(this.DtgV_QLTT);
            this.Controls.Add(this.lb_1);
            this.Name = "QuanLiThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.QuanLiThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgV_QLTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgV_QLTT;
        private System.Windows.Forms.Label lb_1;
    }
}