using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Berfin";
            musteri1.Soyadi = "BUDAK";
            musteri1.Yasi = 29;
            musteri1.YasadigiYer = "İstanbul/KÜÇÜKÇEKMECE";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Tülay";
            musteri2.Soyadi = "BALCIOĞLU";
            musteri2.Yasi = 60;
            musteri2.YasadigiYer = "İstanbul/KÜÇÜKÇEKMECE";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Ayşe";



            musteri3.Soyadi = "ERÇİN";
            musteri3.Yasi = 23;
            musteri3.YasadigiYer = "İstanbul/BEYLİKDÜZÜ";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(musteri.YasadigiYer);
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            musteriManager.Sil(musteri3);
            
        }
    }
}

