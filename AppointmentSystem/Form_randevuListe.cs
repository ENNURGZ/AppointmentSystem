using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentSystem
{
    public partial class Form_randevuListe : Form
    {
        string randevu_data = @"randevu_data.txt";
        string hizmet_data = @"hizmet_data.txt";
        public Form_randevuListe()
        {
            InitializeComponent();
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
                Form_randevu randevu = new Form_randevu();
                randevu.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void ListAppointments()
        {
            DataTable table = new DataTable();
            double totalPrice = 0.0;

            table.Columns.Add(new DataColumn("Tarih"));
            table.Columns.Add(new DataColumn("Müşteri Adı Soyadı"));
            table.Columns.Add(new DataColumn("Müşteri Telefon Numarası"));
            table.Columns.Add(new DataColumn("Hizmet Türü"));
            table.Columns.Add(new DataColumn("Hizmet"));
            table.Columns.Add(new DataColumn("Saat"));
            table.Columns.Add(new DataColumn("Fiyat"));

            string[] lines = File.ReadAllLines(randevu_data, Encoding.UTF8);
            Dictionary<string, string> servicePrices = File.ReadAllLines(hizmet_data)
                                                          .ToDictionary(line => line.Split(':')[2].Trim(), line => line.Split(':')[3].Trim());

            string selectedDate = dateTimePicker1.Value.ToString("dd MMMM yyyy dddd", new CultureInfo("tr-TR"));

            foreach (var line in lines)
            {
                string[] columns = line.Split(':');
                if (columns.Length > 5 && columns[0].Trim() == selectedDate)
                {
                    bool isHair = checkBox1.Checked && columns[3].Trim() == "Saç";
                    bool isMakeup = checkBox2.Checked && columns[3].Trim() == "Makyaj";
                    bool isMaintenance = checkBox3.Checked && columns[3].Trim() == "Bakım";

                    if (isHair || isMakeup || isMaintenance)
                    {
                        DataRow row = table.NewRow();
                        row["Tarih"] = columns[0];
                        row["Müşteri Adı Soyadı"] = columns[1];
                        row["Müşteri Telefon Numarası"] = columns[2];
                        row["Hizmet Türü"] = columns[3];
                        row["Hizmet"] = columns[4];
                        row["Saat"] = columns[5];

                        string priceString = servicePrices.ContainsKey(columns[4].Trim()) ? servicePrices[columns[4].Trim()] : "Bilinmiyor";
                        row["Fiyat"] = priceString;

                        if (double.TryParse(priceString, out double price))
                        {
                            totalPrice += price;
                        }

                        table.Rows.Add(row);
                    }
                }
            }

            dataGridView1.DataSource = table;
            textBox1.Text = totalPrice.ToString("C", CultureInfo.GetCultureInfo("tr-TR"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListAppointments();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

