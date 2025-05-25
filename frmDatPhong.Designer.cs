namespace GUI_KhachSan
{
    partial class frmDatPhong
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
            butXoa = new Button();
            butLamMoi = new Button();
            butSua = new Button();
            butTimKiem = new Button();
            txtTimKiem = new TextBox();
            DataDatPhong = new DataGridView();
            label1 = new Label();
            butThem = new Button();
            groupBox2 = new GroupBox();
            txtMaPhong = new TextBox();
            label6 = new Label();
            txtMaNhanVien = new TextBox();
            label4 = new Label();
            txtMaKhach = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtMaHoaDonThue = new TextBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            txtGhiChu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataDatPhong).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // butXoa
            // 
            butXoa.ForeColor = SystemColors.ActiveCaptionText;
            butXoa.Location = new Point(38, 525);
            butXoa.Name = "butXoa";
            butXoa.Size = new Size(119, 51);
            butXoa.TabIndex = 26;
            butXoa.Text = "Xóa";
            butXoa.UseVisualStyleBackColor = true;
            // 
            // butLamMoi
            // 
            butLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            butLamMoi.Location = new Point(240, 525);
            butLamMoi.Name = "butLamMoi";
            butLamMoi.Size = new Size(119, 51);
            butLamMoi.TabIndex = 25;
            butLamMoi.Text = "Làm mới";
            butLamMoi.UseVisualStyleBackColor = true;
            // 
            // butSua
            // 
            butSua.ForeColor = SystemColors.ActiveCaptionText;
            butSua.Location = new Point(240, 447);
            butSua.Name = "butSua";
            butSua.Size = new Size(119, 51);
            butSua.TabIndex = 24;
            butSua.Text = "Sửa";
            butSua.UseVisualStyleBackColor = true;
            // 
            // butTimKiem
            // 
            butTimKiem.ForeColor = SystemColors.ActiveCaptionText;
            butTimKiem.Location = new Point(811, 50);
            butTimKiem.Name = "butTimKiem";
            butTimKiem.Size = new Size(94, 27);
            butTimKiem.TabIndex = 23;
            butTimKiem.Text = "Tìm kiếm";
            butTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(916, 50);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(232, 27);
            txtTimKiem.TabIndex = 22;
            // 
            // DataDatPhong
            // 
            DataDatPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDatPhong.Location = new Point(404, 101);
            DataDatPhong.Name = "DataDatPhong";
            DataDatPhong.RowHeadersWidth = 51;
            DataDatPhong.Size = new Size(744, 484);
            DataDatPhong.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(338, 20);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 17;
            label1.Text = "Quản lí đặt phòng";
            // 
            // butThem
            // 
            butThem.ForeColor = SystemColors.ActiveCaptionText;
            butThem.Location = new Point(38, 447);
            butThem.Name = "butThem";
            butThem.Size = new Size(119, 51);
            butThem.TabIndex = 18;
            butThem.Text = "Thêm";
            butThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtGhiChu);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMaPhong);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtMaNhanVien);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtMaKhach);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMaHoaDonThue);
            groupBox2.Location = new Point(12, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 331);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin đặt phòng";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(140, 227);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(232, 27);
            txtMaPhong.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 289);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 10;
            label6.Text = "Đơn giá";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(140, 165);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(232, 27);
            txtMaNhanVien.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 168);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 6;
            label4.Text = "Mô tả";
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(140, 103);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(232, 27);
            txtMaKhach.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 103);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 41);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Mã dịch vụ";
            // 
            // txtMaHoaDonThue
            // 
            txtMaHoaDonThue.Location = new Point(140, 41);
            txtMaHoaDonThue.Name = "txtMaHoaDonThue";
            txtMaHoaDonThue.Size = new Size(232, 27);
            txtMaHoaDonThue.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(297, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(10, 11);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(8, 41);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 12;
            label8.Text = "Mã hóa đơn thuế:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(8, 106);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 13;
            label9.Text = "Mã khách";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(10, 168);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 14;
            label10.Text = "Mã nhân viên";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(8, 230);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 15;
            label11.Text = "Mã phòng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(10, 289);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 17;
            label13.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(140, 286);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(232, 27);
            txtGhiChu.TabIndex = 18;
            // 
            // frmDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1160, 597);
            Controls.Add(butXoa);
            Controls.Add(butLamMoi);
            Controls.Add(butSua);
            Controls.Add(butTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(DataDatPhong);
            Controls.Add(label1);
            Controls.Add(butThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.AntiqueWhite;
            Name = "frmDatPhong";
            Text = "frmDatPhong";
            Load += frmDatPhong_Load;
            ((System.ComponentModel.ISupportInitialize)DataDatPhong).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butXoa;
        private Button butLamMoi;
        private Button butSua;
        private Button butTimKiem;
        private TextBox txtTimKiem;
        private DataGridView DataDatPhong;
        private Label label1;
        private Button butThem;
        private GroupBox groupBox2;
        private TextBox txtMaPhong;
        private Label label6;
        private TextBox txtMaNhanVien;
        private Label label4;
        private TextBox txtMaKhach;
        private Label label3;
        private Label label2;
        private TextBox txtMaHoaDonThue;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label13;
        private Label label11;
        private Label label10;
        private TextBox txtGhiChu;
    }
}