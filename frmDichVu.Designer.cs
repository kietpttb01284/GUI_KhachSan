namespace Gui_KhachSan
{
    partial class frmDichVu
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
            txtMaDichVu = new TextBox();
            label1 = new Label();
            butThem = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            CBDonViTinh = new ComboBox();
            label5 = new Label();
            txtNgayTao = new TextBox();
            label4 = new Label();
            txtTenDichVu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            DataDichVu = new DataGridView();
            txtTimKiem = new TextBox();
            butTimKiem = new Button();
            butSua = new Button();
            butLamMoi = new Button();
            butXoa = new Button();
            rbutDaDat = new RadioButton();
            rbutTrong = new RadioButton();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataDichVu).BeginInit();
            SuspendLayout();
            // 
            // txtMaDichVu
            // 
            txtMaDichVu.Location = new Point(125, 41);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.Size = new Size(232, 27);
            txtMaDichVu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(338, 28);
            label1.Name = "label1";
            label1.Size = new Size(260, 46);
            label1.TabIndex = 1;
            label1.Text = "Quản lí dịch vụ";
            // 
            // butThem
            // 
            butThem.Location = new Point(38, 450);
            butThem.Name = "butThem";
            butThem.Size = new Size(119, 44);
            butThem.TabIndex = 2;
            butThem.Text = "Thêm";
            butThem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(297, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(10, 11);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbutTrong);
            groupBox2.Controls.Add(rbutDaDat);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CBDonViTinh);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtNgayTao);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTenDichVu);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMaDichVu);
            groupBox2.Location = new Point(12, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 315);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin dịch vụ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 158);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 10;
            label6.Text = "Trạng thái";
            // 
            // CBDonViTinh
            // 
            CBDonViTinh.FormattingEnabled = true;
            CBDonViTinh.Location = new Point(125, 210);
            CBDonViTinh.Name = "CBDonViTinh";
            CBDonViTinh.Size = new Size(232, 28);
            CBDonViTinh.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 213);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 8;
            label5.Text = "Đơn vị tính";
            // 
            // txtNgayTao
            // 
            txtNgayTao.Location = new Point(125, 261);
            txtNgayTao.Name = "txtNgayTao";
            txtNgayTao.Size = new Size(232, 27);
            txtNgayTao.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 264);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Ngày tạo";
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.Location = new Point(125, 97);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(232, 27);
            txtTenDichVu.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 97);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Mã dịch vụ";
            // 
            // DataDichVu
            // 
            DataDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDichVu.Location = new Point(404, 101);
            DataDichVu.Name = "DataDichVu";
            DataDichVu.RowHeadersWidth = 51;
            DataDichVu.Size = new Size(744, 484);
            DataDichVu.TabIndex = 5;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(916, 58);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(232, 27);
            txtTimKiem.TabIndex = 12;
            // 
            // butTimKiem
            // 
            butTimKiem.Location = new Point(811, 58);
            butTimKiem.Name = "butTimKiem";
            butTimKiem.Size = new Size(94, 27);
            butTimKiem.TabIndex = 13;
            butTimKiem.Text = "Tìm kiếm";
            butTimKiem.UseVisualStyleBackColor = true;
            // 
            // butSua
            // 
            butSua.Location = new Point(240, 450);
            butSua.Name = "butSua";
            butSua.Size = new Size(119, 44);
            butSua.TabIndex = 14;
            butSua.Text = "Sửa";
            butSua.UseVisualStyleBackColor = true;
            // 
            // butLamMoi
            // 
            butLamMoi.Location = new Point(240, 518);
            butLamMoi.Name = "butLamMoi";
            butLamMoi.Size = new Size(119, 44);
            butLamMoi.TabIndex = 15;
            butLamMoi.Text = "Làm mới";
            butLamMoi.UseVisualStyleBackColor = true;
            // 
            // butXoa
            // 
            butXoa.Location = new Point(38, 518);
            butXoa.Name = "butXoa";
            butXoa.Size = new Size(119, 44);
            butXoa.TabIndex = 16;
            butXoa.Text = "Xóa";
            butXoa.UseVisualStyleBackColor = true;
            // 
            // rbutDaDat
            // 
            rbutDaDat.AutoSize = true;
            rbutDaDat.Location = new Point(125, 156);
            rbutDaDat.Name = "rbutDaDat";
            rbutDaDat.Size = new Size(75, 24);
            rbutDaDat.TabIndex = 11;
            rbutDaDat.TabStop = true;
            rbutDaDat.Text = "Đã đặt";
            rbutDaDat.UseVisualStyleBackColor = true;
            // 
            // rbutTrong
            // 
            rbutTrong.AutoSize = true;
            rbutTrong.Location = new Point(247, 156);
            rbutTrong.Name = "rbutTrong";
            rbutTrong.Size = new Size(68, 24);
            rbutTrong.TabIndex = 12;
            rbutTrong.TabStop = true;
            rbutTrong.Text = "Trống";
            rbutTrong.UseVisualStyleBackColor = true;
            // 
            // frmDichVu
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
            Controls.Add(DataDichVu);
            Controls.Add(label1);
            Controls.Add(butThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDichVu";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataDichVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaDichVu;
        private Label label1;
        private Button butThem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView DataDichVu;
        private Label label2;
        private TextBox txtTimKiem;
        private Label label6;
        private ComboBox CBDonViTinh;
        private Label label5;
        private TextBox txtNgayTao;
        private Label label4;
        private TextBox txtTenDichVu;
        private Label label3;
        private Button butTimKiem;
        private Button butSua;
        private Button butLamMoi;
        private Button butXoa;
        private RadioButton rbutTrong;
        private RadioButton rbutDaDat;
    }
}
