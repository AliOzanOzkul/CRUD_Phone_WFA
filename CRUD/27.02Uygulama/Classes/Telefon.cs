using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02Uygulama.Classes
{
    class Telefon
    {
        public static List<Telefon> telefonlar = new List<Telefon>();
        public static int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Durumu { get; set; }
        public string Yil { get; set; }
        public string Pic { get; set; }
        public string SesDosyasi { get; set; }

        static int i = 0;
        public Telefon()
        {
            ID += i;
            i++;
        }

        public Telefon TelefonOlustur(string marka,string model,string yil,string durum)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
            Durumu = durum;
            return this;
        }

        public static void TelefonListeEkle(Telefon telefon)
        {
            telefonlar.Add(telefon);
        }

        public void Yazdir()
        {
            foreach (var item in telefonlar)
            {
                Console.WriteLine(item.Model);
            }
        }
        
    }
}
