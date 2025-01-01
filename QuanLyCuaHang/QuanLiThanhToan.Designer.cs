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
            this.btn_Delete_QLND = new System.Windows.Forms.Button();
            this.btn_Edit_QLND = new System.Windows.Forms.Button();
            this.btn_Add_QLND = new System.Windows.Forms.Button();
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
            // btn_Delete_QLND
            // 
            this.btn_Delete_QLND.Enabled = false;
            this.btn_Delete_QLND.Location = new System.Drawing.Point(512, 47);
            this.btn_Delete_QLND.Name = "btn_Delete_QLND";
            this.btn_Delete_QLND.Size = new System.Drawing.Size(88, 29);
            this.btn_Delete_QLND.TabIndex = 14;
            this.btn_Delete_QLND.Text = "Xóa";
            this.btn_Delete_QLND.UseVisualStyleBackColor = true;
            // 
            // btn_Edit_QLND
            // 
            this.btn_Edit_QLND.Enabled = false;
            this.btn_Edit_QLND.Location = new System.Drawing.Point(382, 47);
            this.btn_Edit_QLND.Name = "btn_Edit_QLND";
            this.btn_Edit_QLND.Size = new System.Drawing.Size(88, 29);
            this.btn_Edit_QLND.TabIndex = 13;
            this.btn_Edit_QLND.Text = "Sửa";
            this.btn_Edit_QLND.UseVisualStyleBackColor = true;
            // 
            // btn_Add_QLND
            // 
            this.btn_Add_QLND.Enabled = false;
            this.btn_Add_QLND.Location = new System.Drawing.Point(254, 47);
            this.btn_Add_QLND.Name = "btn_Add_QLND";
            this.btn_Add_QLND.Size = new System.Drawing.Size(88, 29);
            this.btn_Add_QLND.TabIndex = 12;
            this.btn_Add_QLND.Text = "Thêm";
            this.btn_Add_QLND.UseVisualStyleBackColor = true;
            // 
            // QuanLiThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 650);
            this.Controls.Add(this.btn_Delete_QLND);
            this.Controls.Add(this.btn_Edit_QLND);
            this.Controls.Add(this.btn_Add_QLND);
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
        private System.Windows.Forms.Button btn_Delete_QLND;
        private System.Windows.Forms.Button btn_Edit_QLND;
        private System.Windows.Forms.Button btn_Add_QLND;
    }
}