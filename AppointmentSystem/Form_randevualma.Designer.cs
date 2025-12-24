namespace AppointmentSystem
{
    partial class Form_randevualma
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
            dateTimePicker1 = new DateTimePicker();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(226, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(331, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Ekran_görüntüsü_12_5_2024_0142_;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.SizeAll;
            pictureBox1.Image = Properties.Resources.Ekran_görüntüsü_12_5_2024_01342_;
            pictureBox1.Location = new Point(1339, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 373);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1482, 380);
            dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(541, 12);
            label1.Name = "label1";
            label1.Size = new Size(359, 58);
            label1.TabIndex = 21;
            label1.Text = "RANDEVU ALMA";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Image = Properties.Resources.add_32_;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(91, 301);
            button1.Name = "button1";
            button1.Size = new Size(235, 55);
            button1.TabIndex = 22;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Image = Properties.Resources.minus_32_;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(421, 301);
            button2.Name = "button2";
            button2.Size = new Size(227, 55);
            button2.TabIndex = 23;
            button2.Text = "SİL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Image = Properties.Resources.update;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(743, 301);
            button3.Name = "button3";
            button3.Size = new Size(234, 55);
            button3.TabIndex = 24;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Image = Properties.Resources.report1;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(1102, 301);
            button4.Name = "button4";
            button4.Size = new Size(228, 55);
            button4.TabIndex = 25;
            button4.Text = "LİSTELE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(580, 224);
            label6.Name = "label6";
            label6.Size = new Size(134, 26);
            label6.TabIndex = 26;
            label6.Text = "Saat:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(580, 185);
            label2.Name = "label2";
            label2.Size = new Size(134, 26);
            label2.TabIndex = 27;
            label2.Text = "Hizmet:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(580, 147);
            label3.Name = "label3";
            label3.Size = new Size(134, 26);
            label3.TabIndex = 28;
            label3.Text = "Hizmet Türü:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(580, 108);
            label4.Name = "label4";
            label4.Size = new Size(301, 26);
            label4.TabIndex = 29;
            label4.Text = "Müşteri Telefon Numarası:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(580, 70);
            label5.Name = "label5";
            label5.Size = new Size(285, 26);
            label5.TabIndex = 30;
            label5.Text = "Müşteri Adı Soyadı:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(871, 112);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 27);
            textBox5.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(871, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 32;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "30 Dakika", "1 Saat", "Diğer" });
            comboBox2.Location = new Point(871, 228);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 28);
            comboBox2.TabIndex = 33;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Saç", "Makyaj", "Bakım" });
            comboBox1.Location = new Point(871, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 28);
            comboBox1.TabIndex = 34;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "30 Dakika", "1 Saat", "Diğer" });
            comboBox3.Location = new Point(871, 185);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(213, 28);
            comboBox3.TabIndex = 35;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // Form_randevualma
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1482, 753);
            Controls.Add(comboBox3);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_randevualma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_randevualma";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
    }
}