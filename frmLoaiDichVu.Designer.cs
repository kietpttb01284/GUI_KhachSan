namespace GUI_KhachSan
{
    partial class frmLoaiDichVu
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
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtMaPhong = new TextBox();
            label6 = new Label();
            txtGiaDichVu = new TextBox();
            label4 = new Label();
            txtTenDichVu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtMaDichVu = new TextBox();
            groupBox1 = new GroupBox();
            rbutDadat = new RadioButton();
            rbutTrong = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)DataDatPhong).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // butXoa
            // 
            butXoa.ForeColor = SystemColors.ActiveCaptionText;
            butXoa.Location = new Point(38, 521);
            butXoa.Name = "butXoa";
            butXoa.Size = new Size(119, 51);
            butXoa.TabIndex = 36;
            butXoa.Text = "Xóa";
            butXoa.UseVisualStyleBackColor = true;
            // 
            // butLamMoi
            // 
            butLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            butLamMoi.Location = new Point(240, 521);
            butLamMoi.Name = "butLamMoi";
            butLamMoi.Size = new Size(119, 51);
            butLamMoi.TabIndex = 35;
            butLamMoi.Text = "Làm mới";
            butLamMoi.UseVisualStyleBackColor = true;
            // 
            // butSua
            // 
            butSua.ForeColor = SystemColors.ActiveCaptionText;
            butSua.Location = new Point(240, 443);
            butSua.Name = "butSua";
            butSua.Size = new Size(119, 51);
            butSua.TabIndex = 34;
            butSua.Text = "Sửa";
            butSua.UseVisualStyleBackColor = true;
            // 
            // butTimKiem
            // 
            butTimKiem.ForeColor = SystemColors.ActiveCaptionText;
            butTimKiem.Location = new Point(811, 46);
            butTimKiem.Name = "butTimKiem";
            butTimKiem.Size = new Size(94, 27);
            butTimKiem.TabIndex = 33;
            butTimKiem.Text = "Tìm kiếm";
            butTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(916, 46);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(232, 27);
            txtTimKiem.TabIndex = 32;
            // 
            // DataDatPhong
            // 
            DataDatPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDatPhong.Location = new Point(404, 97);
            DataDatPhong.Name = "DataDatPhong";
            DataDatPhong.RowHeadersWidth = 51;
            DataDatPhong.Size = new Size(744, 484);
            DataDatPhong.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(338, 16);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 27;
            label1.Text = "Quản lí đặt phòng";
            // 
            // butThem
            // 
            butThem.ForeColor = SystemColors.ActiveCaptionText;
            butThem.Location = new Point(38, 443);
            butThem.Name = "butThem";
            butThem.Size = new Size(119, 51);
            butThem.TabIndex = 28;
            butThem.Text = "Thêm";
            butThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbutTrong);
            groupBox2.Controls.Add(rbutDadat);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMaPhong);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtGiaDichVu);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTenDichVu);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMaDichVu);
            groupBox2.Location = new Point(12, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 331);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin đặt phòng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(10, 289);
            label13.Name = "label13";
            label13.Size = new Size(78, 20);
            label13.TabIndex = 17;
            label13.Text = "Trạng thái:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(8, 230);
            label11.Name = "label11";
            label11.Size = new Size(84, 20);
            label11.TabIndex = 15;
            label11.Text = "Đơn vị tính:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(10, 168);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 14;
            label10.Text = "Giá dịch vụ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(8, 106);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 13;
            label9.Text = "Tên dịch vụ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(8, 41);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 12;
            label8.Text = "Mã loại dịch vụ:";
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
            // txtGiaDichVu
            // 
            txtGiaDichVu.Location = new Point(140, 165);
            txtGiaDichVu.Name = "txtGiaDichVu";
            txtGiaDichVu.Size = new Size(232, 27);
            txtGiaDichVu.TabIndex = 7;
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
            // txtTenDichVu
            // 
            txtTenDichVu.Location = new Point(140, 103);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(232, 27);
            txtTenDichVu.TabIndex = 5;
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
            // txtMaDichVu
            // 
            txtMaDichVu.Location = new Point(140, 41);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.Size = new Size(232, 27);
            txtMaDichVu.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(297, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(10, 11);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rbutDadat
            // 
            rbutDadat.AutoSize = true;
            rbutDadat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbutDadat.Location = new Point(140, 287);
            rbutDadat.Name = "rbutDadat";
            rbutDadat.Size = new Size(75, 24);
            rbutDadat.TabIndex = 19;
            rbutDadat.TabStop = true;
            rbutDadat.Text = "Đã đặt";
            rbutDadat.UseVisualStyleBackColor = true;
            // 
            // rbutTrong
            // 
            rbutTrong.AutoSize = true;
            rbutTrong.Location = new Point(255, 285);
            rbutTrong.Name = "rbutTrong";
            rbutTrong.Size = new Size(68, 24);
            rbutTrong.TabIndex = 20;
            rbutTrong.TabStop = true;
            rbutTrong.Text = "Trống";
            rbutTrong.UseVisualStyleBackColor = true;
            // 
            // frmLoaiDichVu
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
            Name = "frmLoaiDichVu";
            Text = "frmLoaiDichVu";
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
        private RadioButton rbutDadat;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtMaPhong;
        private Label label6;
        private TextBox txtGiaDichVu;
        private Label label4;
        private TextBox txtTenDichVu;
        private Label label3;
        private Label label2;
        private TextBox txtMaDichVu;
        private GroupBox groupBox1;
        private RadioButton rbutTrong;
    }
}