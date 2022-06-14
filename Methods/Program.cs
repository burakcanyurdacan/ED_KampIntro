// See https://aka.ms/new-console-template for more information
using Metotlar;

Urun urun1 = new Urun()
{
    Id = 1,
    UrunAdi = "Elma",
    Fiyati = 6.5,
    UrunAciklama = "Amasya elması"
};

Urun urun2 = new Urun()
{
    Id = 2,
    UrunAdi = "Karpuz",
    Fiyati = 9.75,
    UrunAciklama = "Diyarbakır karpuzu"
};

Urun[] urunler = new Urun[] { urun1, urun2 };

foreach (Urun item in urunler)
{
    Console.WriteLine(item.UrunAdi);
    Console.WriteLine(item.Fiyati);
    Console.WriteLine(item.UrunAciklama);
    Console.WriteLine("-------------------");
}

Console.WriteLine("\n\n------------Metotlar-------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);
//encapsulation = bir sınıfa ait yeni bir özellik eklendiğinde, onu çağırılan her yerde değiştirmek yerine tek bir sınıftan kontrol etmeye yarar.
sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
sepetManager.Ekle2("Erik", "Yeşil erik", 12, 8);