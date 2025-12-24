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

namespace AppointmentSystem
{
    public partial class Form_randevualma : Form
    {
        string randevu_data = @"randevu_data.txt";     //randevuların verilerini tutması için txt dosyası

        public Form_randevualma()
        {
            InitializeComponent();
            if (!File.Exists(randevu_data))
            {
                File.Create(randevu_data).Close();  // Dosyayı oluşturma ve kapat
            }
        }
        void Listele()
        {
            DataTable Tablo = new DataTable();

            Tablo.Columns.Add(new DataColumn("Tarih"));
            Tablo.Columns.Add(new DataColumn("Müşteri Adı Soyadı"));
            Tablo.Columns.Add(new DataColumn("Müşteri Telefon Numarası"));
            Tablo.Columns.Add(new DataColumn("Hizmet Türü"));
            Tablo.Columns.Add(new DataColumn("Hizmet"));
            Tablo.Columns.Add(new DataColumn("Saat"));

            string[] randevuData = File.ReadAllLines(randevu_data, Encoding.UTF8);

            foreach (string line in randevuData)
            {
                var cols = line.Split(':');

                DataRow dr = Tablo.NewRow();

                for (int cIndex = 0; cIndex < 6; cIndex++)
                {
                    dr[cIndex] = cols[cIndex];
                }

                Tablo.Rows.Add(dr);
            }
            dataGridView1.DataSource = Tablo;
        }
        void Temizle()
        {
            textBox1.Clear();                 //müşteriadısoyadı        
            textBox5.Clear();                 //müşteritelno
            comboBox1.SelectedIndex = 0;      //hizmettürü
            comboBox2.SelectedIndex = 0;      //saat
            comboBox3.SelectedIndex = 0;      //hizmet
            dateTimePicker1.Value = DateTime.Now;    //tarih
        }


        private void pictureBox2_Click(object sender, EventArgs e) //anasayfa
        {
            try
            {
                Form_randevu randevu = new Form_randevu();
                randevu.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e) //çıkış
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

        private void button1_Click(object sender, EventArgs e) //ekleme butonu
        {
            // Geçmiş tarih kontrolü
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Geçmiş bir tarihe randevu alınamaz.", "Geçersiz Tarih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hafta sonu kontrolü
            DayOfWeek dayOfWeek = dateTimePicker1.Value.DayOfWeek;
            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Hafta sonları randevu alınamaz.", "Geçersiz Tarih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Telefon numarası kontrolü
            string phoneNumber = textBox5.Text;
            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Geçersiz telefon numarası. Lütfen geçerli bir telefon numarası giriniz.", "Geçersiz Telefon Numarası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Personel sayısını okuma ve ilgili uzmanların sayısını bulma
            string[] personelLines = File.ReadAllLines("personel_data.txt", Encoding.UTF8);
            Dictionary<string, int> uzmanSayilari = new Dictionary<string, int>
    {
        {"Makyaj", 0},
        {"Saç", 0},
        {"Bakım", 0}
    };

           
            foreach (string line in personelLines)
            {
                if (line.Contains("Aktif"))
                {
                    if (line.Contains("Makyaj Uzmanı")) uzmanSayilari["Makyaj"]++;
                    else if (line.Contains("Saç Uzmanı")) uzmanSayilari["Saç"]++;
                    else if (line.Contains("Bakım Uzmanı")) uzmanSayilari["Bakım"]++;
                }
            }

            // Aynı gün, saat ve hizmet türünde randevu kontrolü
            string tarihFormati = dateTimePicker1.Text;
            string saat = comboBox2.Text.Split('.')[0];
            string hizmetTuru = comboBox1.Text;  // Hizmet türünü comboBox1'den alıyoruz
            string yeniRandevu = tarihFormati + ":" + saat + ":" + hizmetTuru;  // Tarih, saat ve hizmet türü bilgisini birleştir

            string[] mevcutRandevular = File.ReadAllLines(randevu_data, Encoding.UTF8);
            Dictionary<string, int> randevuSayaci = new Dictionary<string, int>();

            foreach (string randevu in mevcutRandevular)
            {
                string[] randevuDetaylari = randevu.Split(':');
                if (randevuDetaylari.Length > 5)
                {
                    string mevcutSaat = randevuDetaylari[5].Split('.')[0].Trim(); // Sadece saat kısmını alıyoruz
                    string anahtar = randevuDetaylari[0].Trim() + ":" + mevcutSaat + ":" + randevuDetaylari[3].Trim(); // Sadece saat kısmını kontrol ediyoruz

                    if (randevuSayaci.ContainsKey(anahtar))
                    {
                        randevuSayaci[anahtar]++;
                    }
                    else
                    {
                        randevuSayaci[anahtar] = 1;
                    }

                }
            }

            if (randevuSayaci.ContainsKey(yeniRandevu) && randevuSayaci[yeniRandevu] >= uzmanSayilari[hizmetTuru])
            {
                MessageBox.Show($"Bu tarih, saat ve {hizmetTuru} hizmet türünde personel kapasitesine göre maksimum randevu sınırına ulaşılmıştır.", "Randevu Sınırı Aşıldı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string[] randevuData = File.ReadAllLines(randevu_data, Encoding.UTF8);
                File.AppendAllText(randevu_data, dateTimePicker1.Text + ":" + textBox1.Text + ":" + textBox5.Text + ":" + comboBox1.Text + ":" + comboBox3.Text + ":" + comboBox2.Text + ":" + Environment.NewLine);

                MessageBox.Show("Randevu Bilgileri Eklendi", "Ekleme İşlemi Başarılı");

                Listele();
                Temizle();
            }
            catch (Exception a)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı." + a.Message, "Tekrar Deneyiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }

        private void button2_Click(object sender, EventArgs e) //silme butonu
        {
            try
            {
                string[] randevuData = File.ReadAllLines(randevu_data);


                string lineToBeRemoved = randevuData[dataGridView1.CurrentCell.RowIndex];

                File.WriteAllText(randevu_data, String.Empty);

                using (StreamWriter writer = new StreamWriter(randevu_data))
                {
                    foreach (string s in randevuData)
                    {
                        if (!s.Equals(lineToBeRemoved))
                        {
                            writer.Write(s + Environment.NewLine);
                        }
                    }
                }

                MessageBox.Show("Randevu Bilgileri Silindi", "Silme İşlemi Başarılı");

                Listele();
                Temizle();

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı.", "Tekrar Deneyiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button3_Click(object sender, EventArgs e) //güncelleme butonu
        {
            try
            {
                using (TextWriter tw = new StreamWriter(randevu_data))
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dataGridView1.Columns.Count - 1)
                            {
                                tw.Write(":");
                            }
                        }
                        tw.WriteLine();
                    }
                }

                MessageBox.Show("Randevu Bilgileri Güncellendi", "Güncelleme İşlemi Başarılı");
                Listele();
                Temizle();


            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı.", "Tekrar Deneyiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }

        }

        private void button4_Click(object sender, EventArgs e) //listeleme butonu
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear(); // Önceki hizmet adlarını temizle

            // comboBox1'deki seçim null ise veya hiçbir öğe seçilmemişse işlem yapma
            if (comboBox1.SelectedItem == null || comboBox1.SelectedIndex == -1)
            {
                return;
            }

            // Seçilen hizmet türünü güvenli bir şekilde al ve boş kontrolü yap
            string selectedServiceType = comboBox1.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(selectedServiceType))
            {
                return;
            }

            // Hizmet verilerini oku
            string[] serviceDataLines = File.ReadAllLines(@"hizmet_data.txt", Encoding.UTF8);
            foreach (string line in serviceDataLines)
            {
                string[] parts = line.Split(':');
                if (parts.Length > 1 && parts[1].Trim() == selectedServiceType)
                {
                    comboBox3.Items.Add(parts[2].Trim());
                }
            }

            // Eğer hizmet adları varsa ilkini seç
            if (comboBox3.Items.Count > 0)
                comboBox3.SelectedIndex = 0;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear(); // Mevcut saatleri temizle

            if (comboBox3.SelectedItem == null)
                return;

            string selectedService = comboBox3.SelectedItem.ToString() ?? string.Empty; //null kontrolüde ekledim

            // Hizmet süresini bul
            string serviceDuration = GetServiceDuration(selectedService);

            // Saat aralıklarını doldur
            PopulateTimeSlots(serviceDuration);
        }
        private string GetServiceDuration(string serviceName)
        {
            string[] serviceDataLines = File.ReadAllLines(@"hizmet_data.txt", Encoding.UTF8);
            foreach (string line in serviceDataLines)
            {
                string[] parts = line.Split(':');
                if (parts.Length > 2 && parts[2].Trim() == serviceName)
                {
                    return parts[4].Trim(); // Hizmet süresini döndür
                }
            }
            return "Belirsiz"; // Varsayılan değer
        }

        private void PopulateTimeSlots(string duration)
        {
            if (duration == "30 Dakika")
            {
                // Örnek: 09:00, 09:30, 10:00, ... gibi yarım saat aralıklarla saatler ekle
                for (int hour = 9; hour < 18; hour++) // 09:00'dan 17:30'a kadar
                {
                    comboBox2.Items.Add($"{hour:00}.00");
                    comboBox2.Items.Add($"{hour:00}.30");
                }
            }
            else if (duration == "1 Saat")
            {
                // Örnek: 09:00, 10:00, 11:00, ... gibi bir saat aralıklarla saatler ekle
                for (int hour = 9; hour < 18; hour++) // 09:00'dan 17:00'a kadar
                {
                    comboBox2.Items.Add($"{hour:00}.00");
                }
            }
            else
            {
                // "Diğer" seçeneği için özel bir durum veya kullanıcıya saat aralığını girmesi için bir diyalog açabilirsiniz.
                comboBox2.Items.Add("Özel Saat Aralığı");
            }

            // Varsayılan olarak ilk seçeneği seç
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
        }
        private bool IsValidPhoneNumber(string phoneNumber) //telefon no geçerliliği kontrolü
        {
            // Telefon numarasının sadece rakamlardan oluştuğunu ve 10 haneli olduğunu kontrol eder
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }
    }
}
