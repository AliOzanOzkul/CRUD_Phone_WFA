using _27._02Uygulama.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27._02Uygulama
{
    public partial class TelefonForm : Form
    {
        public TelefonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telefon tf = new Telefon();
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string yil = textBox3.Text;
            string durum = DurumuBelirle();
            tf.TelefonOlustur(marka, model, yil, durum);
            Telefon.TelefonListeEkle(tf);
            listBox1.Items.Add(tf.Marka + " | " + tf.Model + " | " + tf.Yil + " | " + tf.Durumu);
        }

        public string DurumuBelirle()
        {
            string durum = " ";
            if (radioButton1.Checked)
            {
                durum = "Satışta";
            }
            else if (radioButton2.Checked)
            {
                durum = "Kullanılabilir";
            }
            else if (radioButton3.Checked)
            {
                durum = "Hasarlı";
            }
            return durum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Telefon.telefonlar[listBox1.SelectedIndex].Marka = textBox1.Text;
            Telefon.telefonlar[listBox1.SelectedIndex].Model = textBox2.Text;
            Telefon.telefonlar[listBox1.SelectedIndex].Yil = textBox3.Text;
            Telefon.telefonlar[listBox1.SelectedIndex].Durumu = DurumuBelirle();
            listBox1.Items[listBox1.SelectedIndex] = Telefon.telefonlar[listBox1.SelectedIndex].Marka + " | " + Telefon.telefonlar[listBox1.SelectedIndex].Model + " | " + Telefon.telefonlar[listBox1.SelectedIndex].Yil + " | " + Telefon.telefonlar[listBox1.SelectedIndex].Durumu;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = 0;
            if (listBox1.SelectedIndex == -1)
            {
                a = 1;
            }
            textBox1.Text = Telefon.telefonlar[listBox1.SelectedIndex + a].Marka;
            textBox2.Text = Telefon.telefonlar[listBox1.SelectedIndex + a].Model;
            textBox3.Text = Telefon.telefonlar[listBox1.SelectedIndex + a].Yil;

            if (Telefon.telefonlar[listBox1.SelectedIndex + a].Durumu == "Satşta")
            {
                radioButton1.Checked = true;
            }
            else if (Telefon.telefonlar[listBox1.SelectedIndex + a].Durumu == "Kullanılabilir")
            {
                radioButton2.Checked = true;
            }
            else if (Telefon.telefonlar[listBox1.SelectedIndex + a].Durumu == "Hasarlı")
            {
                radioButton3.Checked = true;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            Telefon.telefonlar.RemoveAt(sayi);
            
        }

        private void TelefonForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Telefon.telefonlar)
            {
                listBox1.Items.Add(item.Marka + " | " + item.Model + " | " + item.Yil + " | " + item.Durumu);
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                Telefon.telefonlar[listBox1.SelectedIndex].Pic = open.FileName;
            }
            catch (Exception)
            {

                MessageBox.Show("Telefon Eklendikten Sonra Resim Eklenebilir!!!");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                Telefon.telefonlar[listBox1.SelectedIndex].SesDosyasi = open.FileName;
                

            }
            catch (Exception)
            {

                MessageBox.Show("Telefon Eklendikten Sonra Ses Dosyası Eklenebilir!!!");
            }
        }
    }
}
