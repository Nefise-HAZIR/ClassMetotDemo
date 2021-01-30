using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("MUSTERI EKLENDI" + musteri.Ad + " " + musteri.Id + " " + musteri.Yaş);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("MUSTERI SILINDI" + musteri.Ad + " " + musteri.Id + " " + musteri.Yaş);
        }
       
    }
}
