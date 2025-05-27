namespace TB01284_PolyCafe
{
    partial class frmResetPassword
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
            rbut_HTMatKhauMoi = new RadioButton();
            rbut_HTXacNhanMatKhau = new RadioButton();
            rbut_HTMatKhauCu = new RadioButton();
            but_ThoatDoiMatKhau = new Button();
            but_DoiMatKhau = new Button();
            label5 = new Label();
            txt_MatKhauCu = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_TenTaKhoanDoiMatKhau = new TextBox();
            txt_XacNhanMatKhau = new TextBox();
            txt_MatKhauMoi = new TextBox();
            SuspendLayout();
            // 
            // rbut_HTMatKhauMoi
            // 
            rbut_HTMatKhauMoi.AutoSize = true;
            rbut_HTMatKhauMoi.Location = new Point(710, 342);
            rbut_HTMatKhauMoi.Margin = new Padding(3, 4, 3, 4);
            rbut_HTMatKhauMoi.Name = "rbut_HTMatKhauMoi";
            rbut_HTMatKhauMoi.Size = new Size(82, 24);
            rbut_HTMatKhauMoi.TabIndex = 29;
            rbut_HTMatKhauMoi.TabStop = true;
            rbut_HTMatKhauMoi.Text = "Hiển thị";
            rbut_HTMatKhauMoi.UseVisualStyleBackColor = true;
            rbut_HTMatKhauMoi.CheckedChanged += rbut_HTMatKhauMoi_CheckedChanged;
            // 
            // rbut_HTXacNhanMatKhau
            // 
            rbut_HTXacNhanMatKhau.AutoSize = true;
            rbut_HTXacNhanMatKhau.Location = new Point(710, 427);
            rbut_HTXacNhanMatKhau.Margin = new Padding(3, 4, 3, 4);
            rbut_HTXacNhanMatKhau.Name = "rbut_HTXacNhanMatKhau";
            rbut_HTXacNhanMatKhau.Size = new Size(82, 24);
            rbut_HTXacNhanMatKhau.TabIndex = 28;
            rbut_HTXacNhanMatKhau.TabStop = true;
            rbut_HTXacNhanMatKhau.Text = "Hiển thị";
            rbut_HTXacNhanMatKhau.UseVisualStyleBackColor = true;
            rbut_HTXacNhanMatKhau.CheckedChanged += rbut_HTXacNhanMatKhau_CheckedChanged;
            // 
            // rbut_HTMatKhauCu
            // 
            rbut_HTMatKhauCu.AutoSize = true;
            rbut_HTMatKhauCu.Location = new Point(710, 259);
            rbut_HTMatKhauCu.Margin = new Padding(3, 4, 3, 4);
            rbut_HTMatKhauCu.Name = "rbut_HTMatKhauCu";
            rbut_HTMatKhauCu.Size = new Size(82, 24);
            rbut_HTMatKhauCu.TabIndex = 27;
            rbut_HTMatKhauCu.TabStop = true;
            rbut_HTMatKhauCu.Text = "Hiển thị";
            rbut_HTMatKhauCu.UseVisualStyleBackColor = true;
            rbut_HTMatKhauCu.CheckedChanged += rbut_HTMatKhauCu_CheckedChanged;
            // 
            // but_ThoatDoiMatKhau
            // 
            but_ThoatDoiMatKhau.BackColor = SystemColors.MenuHighlight;
            but_ThoatDoiMatKhau.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_ThoatDoiMatKhau.Location = new Point(579, 507);
            but_ThoatDoiMatKhau.Margin = new Padding(3, 4, 3, 4);
            but_ThoatDoiMatKhau.Name = "but_ThoatDoiMatKhau";
            but_ThoatDoiMatKhau.Size = new Size(203, 54);
            but_ThoatDoiMatKhau.TabIndex = 26;
            but_ThoatDoiMatKhau.Text = "Thoát";
            but_ThoatDoiMatKhau.UseVisualStyleBackColor = false;
            but_ThoatDoiMatKhau.Click += but_ThoatDoiMatKhau_Click;
            // 
            // but_DoiMatKhau
            // 
            but_DoiMatKhau.BackColor = Color.DarkSalmon;
            but_DoiMatKhau.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_DoiMatKhau.Location = new Point(166, 507);
            but_DoiMatKhau.Margin = new Padding(3, 4, 3, 4);
            but_DoiMatKhau.Name = "but_DoiMatKhau";
            but_DoiMatKhau.Size = new Size(203, 54);
            but_DoiMatKhau.TabIndex = 25;
            but_DoiMatKhau.Text = "Đổi mật khẩu";
            but_DoiMatKhau.UseVisualStyleBackColor = false;
            but_DoiMatKhau.Click += but_DoiMatKhau_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(200, 256);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 24;
            label5.Text = "Mật khẩu cũ:";
            // 
            // txt_MatKhauCu
            // 
            txt_MatKhauCu.Location = new Point(422, 256);
            txt_MatKhauCu.Margin = new Padding(3, 4, 3, 4);
            txt_MatKhauCu.Name = "txt_MatKhauCu";
            txt_MatKhauCu.ReadOnly = true;
            txt_MatKhauCu.Size = new Size(276, 27);
            txt_MatKhauCu.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(383, 50);
            label4.Name = "label4";
            label4.Size = new Size(211, 41);
            label4.TabIndex = 22;
            label4.Text = "Đổi mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(200, 425);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 21;
            label3.Text = "Xác nhận mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 343);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 20;
            label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 175);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 19;
            label1.Text = "Tên tài khoản:";
            // 
            // txt_TenTaKhoanDoiMatKhau
            // 
            txt_TenTaKhoanDoiMatKhau.Location = new Point(422, 172);
            txt_TenTaKhoanDoiMatKhau.Margin = new Padding(3, 4, 3, 4);
            txt_TenTaKhoanDoiMatKhau.Name = "txt_TenTaKhoanDoiMatKhau";
            txt_TenTaKhoanDoiMatKhau.ReadOnly = true;
            txt_TenTaKhoanDoiMatKhau.Size = new Size(276, 27);
            txt_TenTaKhoanDoiMatKhau.TabIndex = 18;
            // 
            // txt_XacNhanMatKhau
            // 
            txt_XacNhanMatKhau.Location = new Point(422, 425);
            txt_XacNhanMatKhau.Margin = new Padding(3, 4, 3, 4);
            txt_XacNhanMatKhau.Name = "txt_XacNhanMatKhau";
            txt_XacNhanMatKhau.Size = new Size(276, 27);
            txt_XacNhanMatKhau.TabIndex = 17;
            // 
            // txt_MatKhauMoi
            // 
            txt_MatKhauMoi.Location = new Point(422, 341);
            txt_MatKhauMoi.Margin = new Padding(3, 4, 3, 4);
            txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            txt_MatKhauMoi.Size = new Size(276, 27);
            txt_MatKhauMoi.TabIndex = 16;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(949, 626);
            Controls.Add(rbut_HTMatKhauMoi);
            Controls.Add(rbut_HTXacNhanMatKhau);
            Controls.Add(rbut_HTMatKhauCu);
            Controls.Add(but_ThoatDoiMatKhau);
            Controls.Add(but_DoiMatKhau);
            Controls.Add(label5);
            Controls.Add(txt_MatKhauCu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_TenTaKhoanDoiMatKhau);
            Controls.Add(txt_XacNhanMatKhau);
            Controls.Add(txt_MatKhauMoi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmResetPassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmResetPassword";
            Load += frmResetPassword_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbut_HTMatKhauMoi;
        private System.Windows.Forms.RadioButton rbut_HTXacNhanMatKhau;
        private System.Windows.Forms.RadioButton rbut_HTMatKhauCu;
        private System.Windows.Forms.Button but_ThoatDoiMatKhau;
        private System.Windows.Forms.Button but_DoiMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MatKhauCu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenTaKhoanDoiMatKhau;
        private System.Windows.Forms.TextBox txt_XacNhanMatKhau;
        private System.Windows.Forms.TextBox txt_MatKhauMoi;
    }
}