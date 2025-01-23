namespace ndp_3
{
    partial class Form_hizmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_hizmet));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            btnEkle = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox2 = new ComboBox();
            btnSil = new Button();
            btnGüncelle = new Button();
            btnListele = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.SizeAll;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1316, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Ekran_görüntüsü_12_5_2024_0142_;
            pictureBox2.Location = new Point(25, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 431);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1500, 369);
            dataGridView1.TabIndex = 10;
            // 
            // btnEkle
            // 
            btnEkle.Image = Properties.Resources.add_32_;
            btnEkle.ImageAlign = ContentAlignment.MiddleRight;
            btnEkle.Location = new Point(107, 356);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(243, 52);
            btnEkle.TabIndex = 11;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(572, 21);
            label1.Name = "label1";
            label1.Size = new Size(311, 58);
            label1.TabIndex = 13;
            label1.Text = "HİZMETLERİMİZ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Saç", "Makyaj", "Bakım" });
            comboBox1.Location = new Point(759, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(555, 92);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 15;
            label2.Text = "ID:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(555, 277);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 17;
            label4.Text = "Hizmet Süresi:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(555, 236);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 18;
            label5.Text = "Hizmet Ücreti:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(555, 188);
            label6.Name = "label6";
            label6.Size = new Size(134, 26);
            label6.TabIndex = 19;
            label6.Text = "Hizmet Adı:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(555, 141);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 20;
            label7.Text = "Hizmet Türü";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(759, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 27);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(759, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 27);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(759, 234);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 27);
            textBox4.TabIndex = 23;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1 Saat", "30 Dakika", "Diğer" });
            comboBox2.Location = new Point(759, 277);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 28);
            comboBox2.TabIndex = 24;
            // 
            // btnSil
            // 
            btnSil.Image = Properties.Resources.minus_32_;
            btnSil.ImageAlign = ContentAlignment.MiddleRight;
            btnSil.Location = new Point(455, 356);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(234, 51);
            btnSil.TabIndex = 25;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Image = Properties.Resources.update;
            btnGüncelle.ImageAlign = ContentAlignment.MiddleRight;
            btnGüncelle.Location = new Point(776, 357);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(261, 51);
            btnGüncelle.TabIndex = 26;
            btnGüncelle.Text = "GÜNCELLE";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnListele
            // 
            btnListele.Image = Properties.Resources.report1;
            btnListele.ImageAlign = ContentAlignment.MiddleRight;
            btnListele.Location = new Point(1124, 356);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(255, 52);
            btnListele.TabIndex = 27;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // Form_hizmet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 800);
            Controls.Add(btnListele);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_hizmet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_hizmet";
            Load += Form_hizmet_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Button btnEkle;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox2;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnListele;

    }
}