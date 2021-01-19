using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "Ferhat";
            musteri1.MusteriSoyad = "Atesoglu";
            musteri1.SubeKodu = 1299;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Barkın";
            musteri2.MusteriSoyad = "Atesoglu";
            musteri2.SubeKodu = 1566;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAd = "Ilhami";
            musteri3.MusteriSoyad = "Kotel";
            musteri3.SubeKodu = 2544;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriAd = "Mehtap ";
            musteri4.MusteriSoyad = "Yazgan";
            musteri4.SubeKodu = 1540;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + "\n");

            }

            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz" + "\n" + " 1-Müşteri Silme" + "\n" + "2-Müşteri Ekleme");
            Console.Write("Lütfen Klavyenizden değer giriniz : "); Console.ReadLine();

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Sil(musteri2);


        }
    }
}
