namespace GUI_KhachSan
{
    partial class frmQLNV
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
            Button butLM;
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            txtHT = new TextBox();
            txtEmail = new TextBox();
            txtdc = new TextBox();
            comTT = new ComboBox();
            butTK = new Button();
            butxoa = new Button();
            butTHEM = new Button();
            butSUA = new Button();
            txtMNV = new TextBox();
            comGT = new ComboBox();
            comVT = new ComboBox();
            butLM = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(398, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(657, 513);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 92);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "MÃ NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(325, 9);
            label2.Name = "label2";
            label2.Size = new Size(308, 46);
            label2.TabIndex = 3;
            label2.Text = "Quản lý nhân viên";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 141);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Họ tên ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 187);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 5;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 280);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 6;
            label5.Text = "Dịa chỉ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 235);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 7;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 329);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 8;
            label7.Text = "Vai trò\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 381);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 9;
            label8.Text = "Tình trạng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(658, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 10;
            // 
            // txtHT
            // 
            txtHT.Location = new Point(144, 134);
            txtHT.Name = "txtHT";
            txtHT.Size = new Size(225, 27);
            txtHT.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtdc
            // 
            txtdc.Location = new Point(144, 273);
            txtdc.Name = "txtdc";
            txtdc.Size = new Size(225, 27);
            txtdc.TabIndex = 14;
            // 
            // comTT
            // 
            comTT.FormattingEnabled = true;
            comTT.Location = new Point(144, 373);
            comTT.Name = "comTT";
            comTT.Size = new Size(225, 28);
            comTT.TabIndex = 16;
            comTT.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // butTK
            // 
            butTK.Location = new Point(942, 60);
            butTK.Name = "butTK";
            butTK.Size = new Size(94, 29);
            butTK.TabIndex = 17;
            butTK.Text = "Tìm kiếm";
            butTK.UseVisualStyleBackColor = true;
            // 
            // butxoa
            // 
            butxoa.Location = new Point(39, 517);
            butxoa.Name = "butxoa";
            butxoa.Size = new Size(141, 47);
            butxoa.TabIndex = 18;
            butxoa.Text = "Xóa";
            butxoa.UseVisualStyleBackColor = true;
            // 
            // butTHEM
            // 
            butTHEM.Location = new Point(39, 436);
            butTHEM.Name = "butTHEM";
            butTHEM.Size = new Size(141, 47);
            butTHEM.TabIndex = 19;
            butTHEM.Text = "Thêm";
            butTHEM.UseVisualStyleBackColor = true;
            // 
            // butSUA
            // 
            butSUA.Location = new Point(251, 436);
            butSUA.Name = "butSUA";
            butSUA.Size = new Size(141, 47);
            butSUA.TabIndex = 20;
            butSUA.Text = "sửa";
            butSUA.UseVisualStyleBackColor = true;
            // 
            // butLM
            // 
            butLM.Location = new Point(251, 517);
            butLM.Name = "butLM";
            butLM.Size = new Size(141, 47);
            butLM.TabIndex = 21;
            butLM.Text = "Làm mới";
            butLM.UseVisualStyleBackColor = true;
            // 
            // txtMNV
            // 
            txtMNV.Location = new Point(144, 85);
            txtMNV.Name = "txtMNV";
            txtMNV.Size = new Size(225, 27);
            txtMNV.TabIndex = 22;
            // 
            // comGT
            // 
            comGT.FormattingEnabled = true;
            comGT.Location = new Point(144, 179);
            comGT.Name = "comGT";
            comGT.Size = new Size(225, 28);
            comGT.TabIndex = 23;
            // 
            // comVT
            // 
            comVT.FormattingEnabled = true;
            comVT.Location = new Point(144, 321);
            comVT.Name = "comVT";
            comVT.Size = new Size(225, 28);
            comVT.TabIndex = 24;
            // 
            // frmQLNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1067, 617);
            Controls.Add(comVT);
            Controls.Add(comGT);
            Controls.Add(txtMNV);
            Controls.Add(butLM);
            Controls.Add(butSUA);
            Controls.Add(butTHEM);
            Controls.Add(butxoa);
            Controls.Add(butTK);
            Controls.Add(comTT);
            Controls.Add(txtdc);
            Controls.Add(txtEmail);
            Controls.Add(txtHT);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmQLNV";
            Text = "frmQLNV";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox txtHT;
        private TextBox txtEmail;
        private TextBox txtdc;
        private ComboBox comTT;
        private Button butTK;
        private Button butxoa;
        private Button butTHEM;
        private Button butSUA;
        private Button butLM;
        private TextBox txtMNV;
        private ComboBox comGT;
        private ComboBox comVT;
    }
}