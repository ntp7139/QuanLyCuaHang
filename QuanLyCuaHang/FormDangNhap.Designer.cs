
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;
using System;
namespace QuanLyCuaHang
{
    partial class FormDangNhap : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pn_DangNhap = new System.Windows.Forms.Panel();
            this.lbExit = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWelcomeBack = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tB_MatKhau = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.tB_TaiKhoan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tCt_FormDangNhap = new System.Windows.Forms.TabControl();
            this.pn_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pn_DangNhap
            // 
            this.pn_DangNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_DangNhap.Controls.Add(this.lbExit);
            this.pn_DangNhap.Controls.Add(this.btnSignUp);
            this.pn_DangNhap.Controls.Add(this.label3);
            this.pn_DangNhap.Controls.Add(this.label2);
            this.pn_DangNhap.Controls.Add(this.lbWelcomeBack);
            this.pn_DangNhap.Controls.Add(this.btnLogIn);
            this.pn_DangNhap.Controls.Add(this.tB_MatKhau);
            this.pn_DangNhap.Controls.Add(this.lbPassword);
            this.pn_DangNhap.Controls.Add(this.lbAccount);
            this.pn_DangNhap.Controls.Add(this.tB_TaiKhoan);
            this.pn_DangNhap.Controls.Add(this.pictureBox1);
            this.pn_DangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_DangNhap.Location = new System.Drawing.Point(0, 0);
            this.pn_DangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.pn_DangNhap.Name = "pn_DangNhap";
            this.pn_DangNhap.Size = new System.Drawing.Size(900, 500);
            this.pn_DangNhap.TabIndex = 9;
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font("Trebuchet MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lbExit.Location = new System.Drawing.Point(662, 460);
            this.lbExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(39, 22);
            this.lbExit.TabIndex = 5;
            this.lbExit.Text = "Exit";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSignUp.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignUp.Location = new System.Drawing.Point(538, 395);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(303, 35);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(672, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "or";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(520, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please log in to your account";
            // 
            // lbWelcomeBack
            // 
            this.lbWelcomeBack.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeBack.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbWelcomeBack.Location = new System.Drawing.Point(520, 7);
            this.lbWelcomeBack.Name = "lbWelcomeBack";
            this.lbWelcomeBack.Size = new System.Drawing.Size(270, 86);
            this.lbWelcomeBack.TabIndex = 10;
            this.lbWelcomeBack.Text = "Welcome Back!";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogIn.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.Location = new System.Drawing.Point(538, 335);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(303, 35);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click_1);
            // 
            // tB_MatKhau
            // 
            this.tB_MatKhau.Location = new System.Drawing.Point(522, 262);
            this.tB_MatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.tB_MatKhau.Name = "tB_MatKhau";
            this.tB_MatKhau.PasswordChar = '*';
            this.tB_MatKhau.Size = new System.Drawing.Size(330, 26);
            this.tB_MatKhau.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.lbPassword.Location = new System.Drawing.Point(522, 238);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(88, 23);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.lbAccount.Location = new System.Drawing.Point(518, 150);
            this.lbAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(78, 23);
            this.lbAccount.TabIndex = 1;
            this.lbAccount.Text = "Account";
            // 
            // tB_TaiKhoan
            // 
            this.tB_TaiKhoan.Location = new System.Drawing.Point(519, 173);
            this.tB_TaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.tB_TaiKhoan.Name = "tB_TaiKhoan";
            this.tB_TaiKhoan.Size = new System.Drawing.Size(334, 26);
            this.tB_TaiKhoan.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tCt_FormDangNhap
            // 
            this.tCt_FormDangNhap.Location = new System.Drawing.Point(0, 0);
            this.tCt_FormDangNhap.Name = "tCt_FormDangNhap";
            this.tCt_FormDangNhap.SelectedIndex = 0;
            this.tCt_FormDangNhap.Size = new System.Drawing.Size(800, 500);
            this.tCt_FormDangNhap.TabIndex = 0;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pn_DangNhap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.pn_DangNhap.ResumeLayout(false);
            this.pn_DangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button button2;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Panel pn_DangNhap;
        private Button btnLogIn;
        private TextBox tB_MatKhau;
        private Label lbPassword;
        private Label lbAccount;
        private TextBox tB_TaiKhoan;
        private TabControl tCt_FormDangNhap;
        private Label lbWelcomeBack;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button btnSignUp;
        private Label lbExit;
    }
}
