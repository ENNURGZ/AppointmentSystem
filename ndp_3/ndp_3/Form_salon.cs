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

namespace ndp_3
{
    public partial class Form_salon : Form
    {
        public Form_salon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                Form1 anasayfa = new Form1();
                anasayfa.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_hizmet hizmet = new Form_hizmet();
            hizmet.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form_personel personel = new Form_personel();
            personel.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
