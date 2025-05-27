namespace GUI_PolyCafe_
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            rbut_HienThi = new RadioButton();
            butDangNhap = new Button();
            butThoat = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(421, 34);
            label1.Name = "label1";
            label1.Size = new Size(211, 42);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 240);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(291, 153);
            label3.Name = "label3";
            label3.Size = new Size(137, 22);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(461, 239);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(260, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(461, 151);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(260, 27);
            txtTenDangNhap.TabIndex = 4;
            // 
            // rbut_HienThi
            // 
            rbut_HienThi.AutoSize = true;
            rbut_HienThi.BackColor = Color.Transparent;
            rbut_HienThi.Location = new Point(610, 280);
            rbut_HienThi.Margin = new Padding(3, 4, 3, 4);
            rbut_HienThi.Name = "rbut_HienThi";
            rbut_HienThi.Size = new Size(82, 24);
            rbut_HienThi.TabIndex = 5;
            rbut_HienThi.TabStop = true;
            rbut_HienThi.Text = "Hiển thị";
            rbut_HienThi.UseVisualStyleBackColor = false;
            rbut_HienThi.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // butDangNhap
            // 
            butDangNhap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butDangNhap.Location = new Point(295, 345);
            butDangNhap.Margin = new Padding(3, 4, 3, 4);
            butDangNhap.Name = "butDangNhap";
            butDangNhap.Size = new Size(426, 47);
            butDangNhap.TabIndex = 6;
            butDangNhap.Text = "Đăng nhập";
            butDangNhap.UseVisualStyleBackColor = true;
            // 
            // butThoat
            // 
            butThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butThoat.Location = new Point(295, 434);
            butThoat.Margin = new Padding(3, 4, 3, 4);
            butThoat.Name = "butThoat";
            butThoat.Size = new Size(426, 47);
            butThoat.TabIndex = 7;
            butThoat.Text = "Thoát";
            butThoat.UseVisualStyleBackColor = true;
            butThoat.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(580, 515);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(141, 31);
            button3.TabIndex = 10;
            button3.Text = "Đổi mật khẩu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1002, 579);
            Controls.Add(button3);
            Controls.Add(butThoat);
            Controls.Add(butDangNhap);
            Controls.Add(rbut_HienThi);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FORM_Login_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.RadioButton rbut_HienThi;
        private System.Windows.Forms.Button butDangNhap;
        private System.Windows.Forms.Button butThoat;
        private System.Windows.Forms.Button button3;
    }
}

