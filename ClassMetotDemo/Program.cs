using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "AHMET";
            musteri1.Yaş = 56;
            musteri1.Id = "234567";

            Musteri musteri2 = new Musteri();
            musteri1.Ad = "mehme";
            musteri1.Id = "12345678";
            musteri1.Yaş = 34;;


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            
                
        }
    }
}
