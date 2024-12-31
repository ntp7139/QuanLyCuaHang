
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;
using System;


namespace QuanLyCuaHang
{
    partial class FormDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            this.pn_DangKy = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.tb_MatKhau_DangKy = new System.Windows.Forms.TextBox();
            this.lbConfirmPasswordl = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.tb_Email_DangKy = new System.Windows.Forms.TextBox();
            this.tb_TaiKhoan_DangKy = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lb_TieuDeDangKy = new System.Windows.Forms.Label();
            this.pn_DangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_DangKy
            // 
            this.pn_DangKy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_DangKy.Controls.Add(this.pictureBox5);
            this.pn_DangKy.Controls.Add(this.pictureBox4);
            this.pn_DangKy.Controls.Add(this.pictureBox3);
            this.pn_DangKy.Controls.Add(this.pictureBox1);
            this.pn_DangKy.Controls.Add(this.label1);
            this.pn_DangKy.Controls.Add(this.tb_NhapLaiMatKhau);
            this.pn_DangKy.Controls.Add(this.tb_MatKhau_DangKy);
            this.pn_DangKy.Controls.Add(this.lbConfirmPasswordl);
            this.pn_DangKy.Controls.Add(this.lbPassword);
            this.pn_DangKy.Controls.Add(this.btnExit);
            this.pn_DangKy.Controls.Add(this.btnSignup);
            this.pn_DangKy.Controls.Add(this.tb_Email_DangKy);
            this.pn_DangKy.Controls.Add(this.tb_TaiKhoan_DangKy);
            this.pn_DangKy.Controls.Add(this.lbEmail);
            this.pn_DangKy.Controls.Add(this.lbAccount);
            this.pn_DangKy.Controls.Add(this.lb_TieuDeDangKy);
            this.pn_DangKy.Location = new System.Drawing.Point(-16, -1);
            this.pn_DangKy.Margin = new System.Windows.Forms.Padding(2);
            this.pn_DangKy.Name = "pn_DangKy";
            this.pn_DangKy.Size = new System.Drawing.Size(929, 512);
            this.pn_DangKy.TabIndex = 12;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(153, 368);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(147, 290);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(147, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(179, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Don\'t you have a account? Sign up here!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_NhapLaiMatKhau
            // 
            this.tb_NhapLaiMatKhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_NhapLaiMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_NhapLaiMatKhau.Location = new System.Drawing.Point(216, 370);
            this.tb_NhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.tb_NhapLaiMatKhau.Multiline = true;
            this.tb_NhapLaiMatKhau.Name = "tb_NhapLaiMatKhau";
            this.tb_NhapLaiMatKhau.PasswordChar = '*';
            this.tb_NhapLaiMatKhau.Size = new System.Drawing.Size(593, 33);
            this.tb_NhapLaiMatKhau.TabIndex = 3;
            // 
            // tb_MatKhau_DangKy
            // 
            this.tb_MatKhau_DangKy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_MatKhau_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_MatKhau_DangKy.Location = new System.Drawing.Point(216, 292);
            this.tb_MatKhau_DangKy.Margin = new System.Windows.Forms.Padding(2);
            this.tb_MatKhau_DangKy.Multiline = true;
            this.tb_MatKhau_DangKy.Name = "tb_MatKhau_DangKy";
            this.tb_MatKhau_DangKy.PasswordChar = '*';
            this.tb_MatKhau_DangKy.Size = new System.Drawing.Size(593, 33);
            this.tb_MatKhau_DangKy.TabIndex = 2;
            // 
            // lbConfirmPasswordl
            // 
            this.lbConfirmPasswordl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConfirmPasswordl.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbConfirmPasswordl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbConfirmPasswordl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbConfirmPasswordl.Location = new System.Drawing.Point(91, 344);
            this.lbConfirmPasswordl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConfirmPasswordl.Name = "lbConfirmPasswordl";
            this.lbConfirmPasswordl.Size = new System.Drawing.Size(266, 24);
            this.lbConfirmPasswordl.TabIndex = 15;
            this.lbConfirmPasswordl.Text = "Confirm Password";
            this.lbConfirmPasswordl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPassword
            // 
            this.lbPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPassword.Location = new System.Drawing.Point(126, 263);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(119, 33);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.Location = new System.Drawing.Point(529, 450);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSignup.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.btnSignup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignup.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSignup.Location = new System.Drawing.Point(258, 450);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(144, 35);
            this.btnSignup.TabIndex = 12;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // tb_Email_DangKy
            // 
            this.tb_Email_DangKy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_Email_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Email_DangKy.Location = new System.Drawing.Point(216, 211);
            this.tb_Email_DangKy.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Email_DangKy.Multiline = true;
            this.tb_Email_DangKy.Name = "tb_Email_DangKy";
            this.tb_Email_DangKy.Size = new System.Drawing.Size(593, 34);
            this.tb_Email_DangKy.TabIndex = 1;
            // 
            // tb_TaiKhoan_DangKy
            // 
            this.tb_TaiKhoan_DangKy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_TaiKhoan_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_TaiKhoan_DangKy.Location = new System.Drawing.Point(216, 137);
            this.tb_TaiKhoan_DangKy.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TaiKhoan_DangKy.Multiline = true;
            this.tb_TaiKhoan_DangKy.Name = "tb_TaiKhoan_DangKy";
            this.tb_TaiKhoan_DangKy.Size = new System.Drawing.Size(593, 35);
            this.tb_TaiKhoan_DangKy.TabIndex = 0;
            // 
            // lbEmail
            // 
            this.lbEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmail.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEmail.Location = new System.Drawing.Point(108, 181);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(119, 34);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "Email";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAccount
            // 
            this.lbAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAccount.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAccount.Location = new System.Drawing.Point(119, 106);
            this.lbAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(122, 37);
            this.lbAccount.TabIndex = 8;
            this.lbAccount.Text = "Account";
            this.lbAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TieuDeDangKy
            // 
            this.lb_TieuDeDangKy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_TieuDeDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_TieuDeDangKy.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDeDangKy.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_TieuDeDangKy.Location = new System.Drawing.Point(303, 10);
            this.lb_TieuDeDangKy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TieuDeDangKy.Name = "lb_TieuDeDangKy";
            this.lb_TieuDeDangKy.Size = new System.Drawing.Size(370, 48);
            this.lb_TieuDeDangKy.TabIndex = 7;
            this.lb_TieuDeDangKy.Text = "Create a new account";
            this.lb_TieuDeDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pn_DangKy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pn_DangKy.ResumeLayout(false);
            this.pn_DangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pn_DangKy;
        private TextBox tb_NhapLaiMatKhau;
        private TextBox tb_MatKhau_DangKy;
        private Label lbConfirmPasswordl;
        private Label lbPassword;
        private Button btnExit;
        private Button btnSignup;
        private TextBox tb_Email_DangKy;
        private TextBox tb_TaiKhoan_DangKy;
        private Label lbEmail;
        private Label lbAccount;
        private Label lb_TieuDeDangKy;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}