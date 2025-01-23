/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:3.öDEV PROJE ÖDEVİ
**				ÖĞRENCİ ADI............:ENNUR GÜRBÜZ
**				ÖĞRENCİ NUMARASI.......:B211210060
**              DERSİN ALINDIĞI GRUP...:1-A
****************************************************************************/
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

namespace ndp_3
{
    public partial class Form_hizmet : Form
    {
        string hizmet_data = @"hizmet_data.txt";     //hizmetlerin verilerini tutması için txt dosyası

        public Form_hizmet()
        {
            InitializeComponent();
            if (!File.Exists(hizmet_data))
            {
                File.Create(hizmet_data).Close();  // Dosyayı oluşturun ve kapat
            }


        }

        void Listele()
        {
            DataTable Tablo = new DataTable();

            Tablo.Columns.Add(new DataColumn("ID"));
            Tablo.Columns.Add(new DataColumn("Hizmet Türü"));
            Tablo.Columns.Add(new DataColumn("Hizmet Adı"));
            Tablo.Columns.Add(new DataColumn("Hizmet Ücreti"));
            Tablo.Columns.Add(new DataColumn("Hizmet Süresi"));


            string[] hizmetData = File.ReadAllLines(hizmet_data, Encoding.UTF8);

            foreach (string line in hizmetData)
            {
                var cols = line.Split(':');

                DataRow dr = Tablo.NewRow();

                for (int cIndex = 0; cIndex < 5; cIndex++)
                {
                    dr[cIndex] = cols[cIndex];
                }

                Tablo.Rows.Add(dr);
            }
            dataGridView1.DataSource = Tablo;
        }

        void Temizle()
        {

            textBox2.Clear();                 //id
            textBox3.Clear();                 //adı
            textBox4.Clear();                 //ücret
            comboBox1.SelectedIndex = 0;      //türü
            comboBox2.SelectedIndex = 0;      //süre
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

        private void btnEkle_Click(object sender, EventArgs e) //ekleme butonu 
        {
            try
            {
                string[] hizmetData = File.ReadAllLines(hizmet_data, Encoding.UTF8);
                File.AppendAllText(hizmet_data, textBox2.Text + ":" + comboBox1.Text + ":" + textBox3.Text + ":" + textBox4.Text + ":" + comboBox2.Text + ":" + Environment.NewLine);

                MessageBox.Show("Hizmet Bilgileri Eklendi", "Ekleme İşlemi Başarılı");

                Listele();
                Temizle();
            }
            catch (Exception a)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı." + a.Message, "Tekrar Deneyiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)  //silme butonu
        {
            try
            {
                string[] hizmetData = File.ReadAllLines(hizmet_data);


                string lineToBeRemoved = hizmetData[dataGridView1.CurrentCell.RowIndex];

                File.WriteAllText(hizmet_data, String.Empty);

                using (StreamWriter writer = new StreamWriter(hizmet_data))
                {
                    foreach (string s in hizmetData)
                    {
                        if (!s.Equals(lineToBeRemoved))
                        {
                            writer.Write(s + Environment.NewLine);
                        }
                    }
                }

                MessageBox.Show("Hizmet Bilgileri Silindi", "Silme İşlemi Başarılı");

                Listele();
                Temizle();

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı.", "Tekrar Deneyiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e) //güncelleme butonu
        {
            try
            {
                using (TextWriter tw = new StreamWriter(hizmet_data))
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

                MessageBox.Show("Hizmet Bilgileri Güncellendi", "Güncelleme İşlemi Başarılı");
                Listele();
                Temizle();


            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı.", "Tekrar Deneyiniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }
        private void btnListele_Click(object sender, EventArgs e)  //listele butonu
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form_hizmet_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
