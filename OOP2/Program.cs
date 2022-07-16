using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri
            {
                Id = 1,
                MusteriNo = "12345",
                Adi = "Burak",
                Soyadi = "Yurdacan",
                TcNo = "1111111"
            };

            TuzelMusteri musteri2 = new TuzelMusteri
            {
                Id = 2,
                MusteriNo = "45452342",
                SirketAdi = "Kodlama.IO",
                VergiNo = "45687451025"
            };

            //Gerçek ve Tüzel müşteri sınıfları, müşteri sınıfını referans aldığı için
            //Musteri sınıfı hem GercekMusteri hem de TuzelMusteri sınıflarının referans numaralarını tutabilir.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //CustomerManager sınıfı da Musteri tipinde parametre aldığı için yukarıda
            //oluşturduğumuz 4 müşteri tipini de alabilir.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);
        }
    }
}