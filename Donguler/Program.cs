string kurs1 = "C#";
string kurs2 = "Java";
string kurs3 = "React";
string kurs4 = "Python";

string[] kurslar = new string[] { kurs1, kurs2, kurs3, kurs4 };

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("--------------------");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}