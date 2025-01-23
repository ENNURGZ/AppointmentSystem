namespace ndp_3
{
    partial class Form_personel
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView2 = new DataGridView();
            btnEkle = new Button();
            btnSil = new Button();
            btnGüncelle = new Button();
            btnListele = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.SizeAll;
            pictureBox1.Image = Properties.Resources.Ekran_görüntüsü_12_5_2024_01342_;
            pictureBox1.Location = new Point(1348, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Ekran_görüntüsü_12_5_2024_0142_;
            pictureBox2.Location = new Point(25, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(531, 20);
            label1.Name = "label1";
            label1.Size = new Size(392, 52);
            label1.TabIndex = 10;
            label1.Text = "Personel İşlemleri";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(482, 80);
            label2.Name = "label2";
            label2.Size = new Size(121, 24);
            label2.TabIndex = 11;
            label2.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(715, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 27);
            textBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Yönetici", "Saç Uzmanı", "Bakım Uzmanı", "Makyaj Uzmanı", "Stajyer" });
            comboBox1.Location = new Point(715, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.HighlightText;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(0, 461);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1504, 339);
            dataGridView2.TabIndex = 15;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEkle.Image = Properties.Resources.add_32_;
            btnEkle.ImageAlign = ContentAlignment.MiddleRight;
            btnEkle.Location = new Point(99, 374);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(235, 55);
            btnEkle.TabIndex = 16;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSil.Image = Properties.Resources.minus_32_;
            btnSil.ImageAlign = ContentAlignment.MiddleRight;
            btnSil.Location = new Point(440, 374);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(233, 55);
            btnSil.TabIndex = 17;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGüncelle.Image = Properties.Resources.update;
            btnGüncelle.ImageAlign = ContentAlignment.MiddleRight;
            btnGüncelle.Location = new Point(823, 374);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(234, 55);
            btnGüncelle.TabIndex = 18;
            btnGüncelle.Text = "GÜNCELLE";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnListele
            // 
            btnListele.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnListele.Image = Properties.Resources.report1;
            btnListele.ImageAlign = ContentAlignment.MiddleRight;
            btnListele.Location = new Point(1164, 374);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(228, 55);
            btnListele.TabIndex = 19;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(482, 120);
            label3.Name = "label3";
            label3.Size = new Size(121, 24);
            label3.TabIndex = 20;
            label3.Text = "Adı Soyadı:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(715, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 27);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(715, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 27);
            textBox3.TabIndex = 22;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(482, 157);
            label4.Name = "label4";
            label4.Size = new Size(150, 38);
            label4.TabIndex = 23;
            label4.Text = "Pozisyon:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(482, 327);
            label5.Name = "label5";
            label5.Size = new Size(123, 30);
            label5.TabIndex = 24;
            label5.Text = "İş Durumu:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(482, 281);
            label6.Name = "label6";
            label6.Size = new Size(180, 34);
            label6.TabIndex = 25;
            label6.Text = "Çalışma Saatleri:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(482, 240);
            label7.Name = "label7";
            label7.Size = new Size(129, 32);
            label7.TabIndex = 26;
            label7.Text = "Maaş:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(482, 196);
            label8.Name = "label8";
            label8.Size = new Size(191, 33);
            label8.TabIndex = 27;
            label8.Text = "Telefon Numarası:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "09.00-18.00", "09.00-15.00", "Belirsiz" });
            comboBox2.Location = new Point(715, 287);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(208, 28);
            comboBox2.TabIndex = 28;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Aktif", "İzinli", "İşten Ayrılmış" });
            comboBox3.Location = new Point(715, 331);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(208, 28);
            comboBox3.TabIndex = 29;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "10000-20000", "20000-30000", "30000-40000", "40000-50000" });
            comboBox4.Location = new Point(715, 244);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(208, 28);
            comboBox4.TabIndex = 30;
            // 
            // Form_personel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 800);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(btnListele);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_personel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_personel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView2;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnListele;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}