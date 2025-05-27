namespace GUI_KhachSan
{
    partial class frmQLLP
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
            dataGridView1 = new DataGridView();
            labe1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            butTK = new Button();
            butXoa = new Button();
            butThem = new Button();
            buttsua = new Button();
            butLM = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(549, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(472, 419);
            dataGridView1.TabIndex = 0;
            // 
            // labe1
            // 
            labe1.AutoSize = true;
            labe1.Location = new Point(29, 97);
            labe1.Name = "labe1";
            labe1.Size = new Size(106, 20);
            labe1.TabIndex = 1;
            labe1.Text = "Mã loại phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 148);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên loại phòng";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 196);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Ngày tạo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 293);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "ghi chú";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 242);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 5;
            label5.Text = "Trạng thái \r\n";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(317, 15);
            label6.Name = "label6";
            label6.Size = new Size(324, 46);
            label6.TabIndex = 6;
            label6.Text = "Quản lý loại phòng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(647, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 290);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(172, 90);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 27);
            textBox5.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(172, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 28);
            comboBox1.TabIndex = 12;
            // 
            // butTK
            // 
            butTK.Location = new Point(927, 46);
            butTK.Name = "butTK";
            butTK.Size = new Size(94, 29);
            butTK.TabIndex = 13;
            butTK.Text = "Tìm kiếm";
            butTK.UseVisualStyleBackColor = true;
            // 
            // butXoa
            // 
            butXoa.Location = new Point(294, 350);
            butXoa.Name = "butXoa";
            butXoa.Size = new Size(179, 57);
            butXoa.TabIndex = 14;
            butXoa.Text = "xóa";
            butXoa.UseVisualStyleBackColor = true;
            // 
            // butThem
            // 
            butThem.Location = new Point(51, 350);
            butThem.Name = "butThem";
            butThem.Size = new Size(179, 57);
            butThem.TabIndex = 15;
            butThem.Text = "Thêm";
            butThem.UseVisualStyleBackColor = true;
            // 
            // buttsua
            // 
            buttsua.Location = new Point(51, 410);
            buttsua.Name = "buttsua";
            buttsua.Size = new Size(179, 57);
            buttsua.TabIndex = 16;
            buttsua.Text = "sửa";
            buttsua.UseVisualStyleBackColor = true;
            // 
            // butLM
            // 
            butLM.Location = new Point(294, 410);
            butLM.Name = "butLM";
            butLM.Size = new Size(179, 57);
            butLM.TabIndex = 17;
            butLM.Text = "Làm mới";
            butLM.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // frmQLLP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1024, 501);
            Controls.Add(dateTimePicker1);
            Controls.Add(butLM);
            Controls.Add(buttsua);
            Controls.Add(butThem);
            Controls.Add(butXoa);
            Controls.Add(butTK);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labe1);
            Controls.Add(dataGridView1);
            Name = "frmQLLP";
            Text = "frmQLLP";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labe1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Button butTK;
        private Button butXoa;
        private Button butThem;
        private Button buttsua;
        private Button butLM;
        private DateTimePicker dateTimePicker1;
    }
}