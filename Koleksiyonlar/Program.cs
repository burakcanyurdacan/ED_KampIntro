string[] isimler = new string[]
{
    "Engin",
    "Murat",
    "Kerem",
    "Burak"
};

//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);
////isimler[4] = "İlker"; //--> Sistem buna hata verecek. Çünkü mevcut dizinin sınırı aşıldı. Dizi şu an 4 elemanlı.

/*
    Aşağıdaki şablonda isimler dizisi new'lendiğinde heap'te farklı bir adres ile oluşturuldu.
    Yukarıdaki dizinin heap adresiyle bağlantı koptu ve dizinin elemanları sıfırlanarak 5 elemanlı haliyle yeniden oluştu.
    Konsol çıktılarından 22.satırdaki İlker ismini gösterirken, 23.satırdaki boş gelecek. Çünkü yeni dizide 0. indexte eleman yok.
*/
//isimler = new string[5];
//isimler[4] = "İlker";
//Console.WriteLine(isimler[4]);
//Console.WriteLine(isimler[0]);

Console.WriteLine("********* List Collection ile oluşturulan dizi çıktısı *************");
List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("Burak");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);