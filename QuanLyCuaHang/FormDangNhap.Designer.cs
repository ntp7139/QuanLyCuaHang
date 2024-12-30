
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
            button1 = new Button();
            button2 = new Button();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            pn_DangNhap = new Panel();
            lbExit = new Label();
            btnSignUp = new Button();
            label3 = new Label();
            label2 = new Label();
            lbWelcomeBack = new Label();
            lbChangePassword = new Label();
            btnLogIn = new Button();
            tB_MatKhau = new TextBox();
            lbPassword = new Label();
            lbAccount = new Label();
            tB_TaiKhoan = new TextBox();
            pictureBox1 = new PictureBox();
            tCt_FormDangNhap = new TabControl();
            pn_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(793, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pn_DangNhap
            // 
            pn_DangNhap.BackColor = SystemColors.ButtonHighlight;
            pn_DangNhap.Controls.Add(lbExit);
            pn_DangNhap.Controls.Add(btnSignUp);
            pn_DangNhap.Controls.Add(label3);
            pn_DangNhap.Controls.Add(label2);
            pn_DangNhap.Controls.Add(lbWelcomeBack);
            pn_DangNhap.Controls.Add(lbChangePassword);
            pn_DangNhap.Controls.Add(btnLogIn);
            pn_DangNhap.Controls.Add(tB_MatKhau);
            pn_DangNhap.Controls.Add(lbPassword);
            pn_DangNhap.Controls.Add(lbAccount);
            pn_DangNhap.Controls.Add(tB_TaiKhoan);
            pn_DangNhap.Controls.Add(pictureBox1);
            pn_DangNhap.Dock = DockStyle.Fill;
            pn_DangNhap.Location = new Point(0, 0);
            pn_DangNhap.Margin = new Padding(2);
            pn_DangNhap.Name = "pn_DangNhap";
            pn_DangNhap.Size = new Size(800, 500);
            pn_DangNhap.TabIndex = 9;
            pn_DangNhap.Paint += pn_DangNhap_Paint;
            // 
            // lbExit
            // 
            lbExit.AutoSize = true;
            lbExit.Font = new Font("Trebuchet MS", 8F, FontStyle.Italic | FontStyle.Underline);
            lbExit.Location = new Point(671, 456);
            lbExit.Margin = new Padding(2, 0, 2, 0);
            lbExit.Name = "lbExit";
            lbExit.Size = new Size(33, 18);
            lbExit.TabIndex = 5;
            lbExit.Text = "Exit";
            lbExit.Click += lbExit_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.SteelBlue;
            btnSignUp.Font = new Font("Trebuchet MS", 9.5F, FontStyle.Bold);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(478, 395);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(269, 35);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(597, 370);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 13;
            label3.Text = "or";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9.5F, FontStyle.Bold);
            label2.Location = new Point(462, 95);
            label2.Name = "label2";
            label2.Size = new Size(230, 22);
            label2.TabIndex = 11;
            label2.Text = "Please log in to your account";
            // 
            // lbWelcomeBack
            // 
            lbWelcomeBack.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbWelcomeBack.ForeColor = Color.SteelBlue;
            lbWelcomeBack.Location = new Point(462, 7);
            lbWelcomeBack.Name = "lbWelcomeBack";
            lbWelcomeBack.Size = new Size(240, 86);
            lbWelcomeBack.TabIndex = 10;
            lbWelcomeBack.Text = "Welcome Back!";
            // 
            // lbChangePassword
            // 
            lbChangePassword.AutoSize = true;
            lbChangePassword.Font = new Font("Trebuchet MS", 8F, FontStyle.Italic | FontStyle.Underline);
            lbChangePassword.Location = new Point(499, 457);
            lbChangePassword.Margin = new Padding(2, 0, 2, 0);
            lbChangePassword.Name = "lbChangePassword";
            lbChangePassword.Size = new Size(117, 18);
            lbChangePassword.TabIndex = 4;
            lbChangePassword.Text = "Change Password";
            lbChangePassword.Click += lbChangePassword_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.SteelBlue;
            btnLogIn.Font = new Font("Trebuchet MS", 9.5F, FontStyle.Bold);
            btnLogIn.ForeColor = SystemColors.ButtonHighlight;
            btnLogIn.Location = new Point(478, 335);
            btnLogIn.Margin = new Padding(2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(269, 35);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // tB_MatKhau
            // 
            tB_MatKhau.Location = new Point(464, 262);
            tB_MatKhau.Margin = new Padding(2);
            tB_MatKhau.Name = "tB_MatKhau";
            tB_MatKhau.PasswordChar = '*';
            tB_MatKhau.Size = new Size(294, 27);
            tB_MatKhau.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lbPassword.Location = new Point(464, 238);
            lbPassword.Margin = new Padding(2, 0, 2, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(72, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbAccount
            // 
            lbAccount.AutoSize = true;
            lbAccount.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lbAccount.Location = new Point(460, 150);
            lbAccount.Margin = new Padding(2, 0, 2, 0);
            lbAccount.Name = "lbAccount";
            lbAccount.Size = new Size(67, 20);
            lbAccount.TabIndex = 1;
            lbAccount.Text = "Account";
            // 
            // tB_TaiKhoan
            // 
            tB_TaiKhoan.Location = new Point(461, 173);
            tB_TaiKhoan.Margin = new Padding(2);
            tB_TaiKhoan.Name = "tB_TaiKhoan";
            tB_TaiKhoan.Size = new Size(297, 27);
            tB_TaiKhoan.TabIndex = 0;
            // 
            // pictureBox1
            // 
           // pictureBox1.Image = Properties.Resources.anhbia1;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // tCt_FormDangNhap
            // 
            tCt_FormDangNhap.Location = new Point(0, 0);
            tCt_FormDangNhap.Name = "tCt_FormDangNhap";
            tCt_FormDangNhap.SelectedIndex = 0;
            tCt_FormDangNhap.Size = new Size(800, 500);
            tCt_FormDangNhap.TabIndex = 0;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 500);
            this.Controls.Add(pn_DangNhap);
            Margin = new Padding(2);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            pn_DangNhap.ResumeLayout(false);
            pn_DangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Label lbChangePassword;
        private Label lbWelcomeBack;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button btnSignUp;
        private Label lbExit;
    }
}
