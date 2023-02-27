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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public SoundPlayer ses;
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            foreach (var item in Telefon.telefonlar)
            {
                comboBox1.Items.Add(item.Marka + " " + item.Model + " " + item.Yil);
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = Telefon.telefonlar[comboBox1.SelectedIndex].Marka;
            label6.Text = Telefon.telefonlar[comboBox1.SelectedIndex].Model;
            label7.Text = Telefon.telefonlar[comboBox1.SelectedIndex].Yil;
            label9.Text = Telefon.telefonlar[comboBox1.SelectedIndex].Durumu;

            if (Telefon.telefonlar[comboBox1.SelectedIndex].Pic != null)
            {
                pictureBox1.ImageLocation = Telefon.telefonlar[comboBox1.SelectedIndex].Pic;

            }
            if (Telefon.telefonlar[comboBox1.SelectedIndex].SesDosyasi != null)
            {
                ses = new SoundPlayer();
                ses.SoundLocation = Telefon.telefonlar[comboBox1.SelectedIndex].SesDosyasi;
                ses.Stop();
                ses.Play();
            }
            
        }
    }
}
