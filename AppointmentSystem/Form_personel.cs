using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Text.RegularExpressions;  // Regex kullanmak için

namespace AppointmentSystem
{
    public partial class Form_personel : Form
    {
        string personel_data = @"personel_data.txt";     // personel verilerini tutması için txt dosyası
        public Form_personel()
        {
            InitializeComponent();
            if (!File.Exists(personel_data))
            {
                File.Create(personel_data).Close();  // Dosyayı oluşturun ve kapat
            }
        }

        void Listele()
        {
            DataTable Tablo = new DataTable();

            Tablo.Columns.Add(new DataColumn("ID"));
            Tablo.Columns.Add(new DataColumn("Adı Soyadı"));
            Tablo.Columns.Add(new DataColumn("Pozisyon"));
            Tablo.Columns.Add(new DataColumn("Telefon Numarası"));
            Tablo.Columns.Add(new DataColumn("Maaş"));
            Tablo.Columns.Add(new DataColumn("Çalışma Saatleri"));
            Tablo.Columns.Add(new DataColumn("İş Durumu"));

            string[] personelData = File.ReadAllLines(personel_data, Encoding.UTF8);

            foreach (string line in personelData)
            {
                var cols = line.Split(':');

                DataRow dr = Tablo.NewRow();

                for (int cIndex = 0; cIndex < 7; cIndex++)
                {
                    dr[cIndex] = cols[cIndex];
                }

                Tablo.Rows.Add(dr);
            }
            dataGridView2.DataSource = Tablo;
        }

        void Temizle()
        {
            textBox1.Clear();                 // id
            textBox2.Clear();                 // adı soyadı
            textBox3.Clear();                 // telefon numarası
            comboBox1.SelectedIndex = 0;      // pozisyon
            comboBox4.SelectedIndex = 0;      // maaş
            comboBox3.SelectedIndex = 0;      // iş durumu
            comboBox2.SelectedIndex = 0;      // çalışma saatleri
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Form_salon salon = new Form_salon();
                salon.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Telefon numarasının 10 haneli olup olmadığını kontrol eden bir regex
            return Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        private void btnEkle_Click(object sender, EventArgs e) // ekleme butonu 
        {
            try
            {
                // Telefon numarası doğrulaması
                if (!IsPhoneNumberValid(textBox3.Text))
                {
                    MessageBox.Show("Geçersiz telefon numarası. Lütfen 10 haneli bir numara girin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] personelData = File.ReadAllLines(personel_data, Encoding.UTF8);
                File.AppendAllText(personel_data, textBox1.Text + ":" + textBox2.Text + ":" + comboBox1.Text + ":" + textBox3.Text + ":" + comboBox4.Text + ":" + comboBox2.Text + ":" + comboBox3.Text + ":" + Environment.NewLine);

                MessageBox.Show("Personel Bilgileri Eklendi", "Ekleme İşlemi Başarılı");

                Listele();
                Temizle();
            }
            catch (Exception a)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı." + a.Message, "Tekrar Deneyiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)  // sil butonu
        {
            try
            {
                string[] personelData = File.ReadAllLines(personel_data);

                string lineToBeRemoved = personelData[dataGridView2.CurrentCell.RowIndex];

                File.WriteAllText(personel_data, String.Empty);

                using (StreamWriter writer = new StreamWriter(personel_data))
                {
                    foreach (string s in personelData)
                    {
                        if (!s.Equals(lineToBeRemoved))
                        {
                            writer.Write(s + Environment.NewLine);
                        }
                    }
                }

                MessageBox.Show("Personel Bilgileri Silindi", "Silme İşlemi Başarılı");

                Listele();
                Temizle();

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı.", "Tekrar Deneyiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)  // güncelle butonu
        {
            try
            {
                using (TextWriter tw = new StreamWriter(personel_data))
                {
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            tw.Write($"{dataGridView2.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dataGridView2.Columns.Count - 1)
                            {
                                tw.Write(":");
                            }
                        }
                        tw.WriteLine();
                    }
                }

                MessageBox.Show("Personel Bilgileri Güncellendi", "Güncelleme İşlemi Başarılı");
                Listele();
                Temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı.", "Tekrar Deneyiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }

        private void btnListele_Click(object sender, EventArgs e) // listele butonu
        {
            try
            {
                Listele();
                Temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı.", "Tekrar Deneyiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // pozisyona göre çalışma saatleri kontrolü yapılır
        {
            comboBox2.Items.Clear(); // Mevcut saatleri temizle

            // Seçilen pozisyona göre saat aralıklarını ayarla
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Stajyer":
                    // Stajyerler için iki zaman aralığı eklenebilir
                    comboBox2.Items.Add("09.00-18.00");
                    comboBox2.Items.Add("09.00-15.00");
                    break;
                case "Yönetici":
                    // Yöneticiler için bütün saatler eklenebilir
                    comboBox2.Items.Add("09.00-18.00");
                    comboBox2.Items.Add("09.00-15.00");
                    comboBox2.Items.Add("Belirsiz");
                    break;
                case "Saç Uzmanı":
                case "Bakım Uzmanı":
                case "Makyaj Uzmanı":
                    // Bu pozisyonlar için sadece uzun saatler eklenebilir
                    comboBox2.Items.Add("09.00-18.00");
                    break;
                default:
                    // Diğer durumlar için varsayılan saatler
                    comboBox2.Items.Add("Belirsiz");
                    break;
            }

            // Varsayılan olarak ilk seçeneği seç
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
        }
    }
}
