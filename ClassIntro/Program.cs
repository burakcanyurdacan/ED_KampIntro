//Console.WriteLine("Hello");

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.IzlenmeOrani = 83;

Kurs kurs2 = new Kurs()
{
    KursAdi = "Java",
    Egitmen = "Kerem Varış",
    IzlenmeOrani = 56
};

Kurs kurs3 = new Kurs()
{
    KursAdi = "React",
    Egitmen = "Burak Yurdacan",
    IzlenmeOrani = 34
};

//Console.WriteLine(kurs1.KursAdi);

Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
foreach (var item in kurslar)
{
    Console.WriteLine(item.KursAdi+"\n"+item.Egitmen+"\n"+item.IzlenmeOrani);
    Console.WriteLine("-----------");
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}