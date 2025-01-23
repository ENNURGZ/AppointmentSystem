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
namespace ndp_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form_salon salonForm = new Form_salon();
            salonForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_randevu randevu = new Form_randevu();
            randevu.Show();
            this.Hide();
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
    }
}