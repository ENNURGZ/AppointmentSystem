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
    public partial class Form_randevu : Form
    {
        public Form_randevu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                Form_randevuListe randevuListe = new Form_randevuListe();
                randevuListe.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                Form_randevualma randevualma = new Form_randevualma();
                randevualma.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
