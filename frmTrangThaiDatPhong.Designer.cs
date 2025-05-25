namespace GUI_KhachSan
{
    partial class frmTrangThaiDatPhong
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
            DataTrangThaiDatPhong = new DataGridView();
            label1 = new Label();
            butThem = new Button();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            txtMaKhach = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtMaHoaDonThue = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)DataTrangThaiDatPhong).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // butXoa
            // 
            butXoa.ForeColor = SystemColors.ActiveCaptionText;
            butXoa.Location = new Point(38, 525);
            butXoa.Name = "butXoa";
            butXoa.Size = new Size(119, 51);
            butXoa.TabIndex = 37;
            butXoa.Text = "Xóa";
            butXoa.UseVisualStyleBackColor = true;
            // 
            // butLamMoi
            // 
            butLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            butLamMoi.Location = new Point(240, 525);
            butLamMoi.Name = "butLamMoi";
            butLamMoi.Size = new Size(119, 51);
            butLamMoi.TabIndex = 36;
            butLamMoi.Text = "Làm mới";
            butLamMoi.UseVisualStyleBackColor = true;
            // 
            // butSua
            // 
            butSua.ForeColor = SystemColors.ActiveCaptionText;
            butSua.Location = new Point(240, 447);
            butSua.Name = "butSua";
            butSua.Size = new Size(119, 51);
            butSua.TabIndex = 35;
            butSua.Text = "Sửa";
            butSua.UseVisualStyleBackColor = true;
            // 
            // butTimKiem
            // 
            butTimKiem.ForeColor = SystemColors.ActiveCaptionText;
            butTimKiem.Location = new Point(811, 50);
            butTimKiem.Name = "butTimKiem";
            butTimKiem.Size = new Size(94, 27);
            butTimKiem.TabIndex = 34;
            butTimKiem.Text = "Tìm kiếm";
            butTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(916, 50);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(232, 27);
            txtTimKiem.TabIndex = 33;
            // 
            // DataTrangThaiDatPhong
            // 
            DataTrangThaiDatPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTrangThaiDatPhong.Location = new Point(404, 101);
            DataTrangThaiDatPhong.Name = "DataTrangThaiDatPhong";
            DataTrangThaiDatPhong.RowHeadersWidth = 51;
            DataTrangThaiDatPhong.Size = new Size(744, 484);
            DataTrangThaiDatPhong.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(219, 20);
            label1.Name = "label1";
            label1.Size = new Size(477, 46);
            label1.TabIndex = 28;
            label1.Text = "Quản lí trạng thái đặt phòng";
            // 
            // butThem
            // 
            butThem.ForeColor = SystemColors.ActiveCaptionText;
            butThem.Location = new Point(38, 447);
            butThem.Name = "butThem";
            butThem.Size = new Size(119, 51);
            butThem.TabIndex = 29;
            butThem.Text = "Thêm";
            butThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMaKhach);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMaHoaDonThue);
            groupBox2.Location = new Point(12, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 153);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin đặt phòng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(8, 99);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 13;
            label9.Text = "Tên trạng thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(8, 41);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 12;
            label8.Text = "Mã trạng thái";
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(140, 96);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(232, 27);
            txtMaKhach.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 96);
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
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // frmTrangThaiDatPhong
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
            Controls.Add(DataTrangThaiDatPhong);
            Controls.Add(label1);
            Controls.Add(butThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTrangThaiDatPhong";
            Text = "frmTrangThaiDatPhong";
            ((System.ComponentModel.ISupportInitialize)DataTrangThaiDatPhong).EndInit();
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
        private DataGridView DataTrangThaiDatPhong;
        private Label label1;
        private Button butThem;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private TextBox txtMaKhach;
        private Label label3;
        private Label label2;
        private TextBox txtMaHoaDonThue;
        private GroupBox groupBox1;
    }
}