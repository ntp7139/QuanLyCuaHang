namespace QuanLyCuaHang
{
    partial class QuanLiPhanHoi
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
            this.DtgV_QLPH = new System.Windows.Forms.DataGridView();
            this.lb_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgV_QLPH)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgV_QLPH
            // 
            this.DtgV_QLPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgV_QLPH.Location = new System.Drawing.Point(62, 97);
            this.DtgV_QLPH.Name = "DtgV_QLPH";
            this.DtgV_QLPH.RowHeadersWidth = 62;
            this.DtgV_QLPH.RowTemplate.Height = 25;
            this.DtgV_QLPH.Size = new System.Drawing.Size(654, 487);
            this.DtgV_QLPH.TabIndex = 11;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(80, 47);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(71, 20);
            this.lb_1.TabIndex = 10;
            this.lb_1.Text = "Phản hồi";
            // 
            // QuanLiPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 650);
            this.Controls.Add(this.DtgV_QLPH);
            this.Controls.Add(this.lb_1);
            this.Name = "QuanLiPhanHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.QuanLiPhanHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgV_QLPH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgV_QLPH;
        private System.Windows.Forms.Label lb_1;
    }
}